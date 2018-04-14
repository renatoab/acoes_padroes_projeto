using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acoes
{
    public class OperationBase // base de dados de operações de compra/venda
    {
        //public OrderBase;

        private static OperationBase instance; // indica classe singleton

        public List<Operation> AllOperations;

        public List<string> AvailableAssets;

        //public List<AssetTotal> AssetTotals;

        //public Dictionary<string, int> AssetTotalQuantity;
        //public Dictionary<string, double> AssetTotalValue;
        //public Dictionary<string, double> AssetUnitValue;

        public DateTime BaseDate;
        public string assetName;

        private bool lastYear;
        private bool allAssets;

        public bool LastYear
        {
            get
            {
                return lastYear;
            }
            set
            {
                lastYear = value;
                if (lastYear)
                {
                    BaseDate = new DateTime(DateTime.Now.Year - 1, 12, 31);
                }
            }
        }

        public bool AllAssets
        {
            get
            {
                return allAssets;
            }
            set
            {
                allAssets = value;
            }
        }

        private OperationBase()
        {

        }

        public static OperationBase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OperationBase();
                }
                return instance;
            }
        }

        public Results ProcessFile(string fileLines)
        {
            fileLines = fileLines.Replace("\r", "");
            fileLines = fileLines.Replace("A Mercado", "A_Mercado");
            string[] lines = fileLines.Split('\n');
            int nlines = lines.Length;

            string[] elements;

            Operation operation;
            AllOperations = new List<Operation>();
            AvailableAssets = new List<string>();

            for (int i = 0; i < nlines; i++)
            {
                if (lines[i] != "")
                {
                    elements = lines[i].Split();
                    operation = new Operation(elements);
                    if (operation.status == OperationStatus.Confirmada && operation.dateProcess <= BaseDate && (allAssets || operation.asset == assetName))
                    {
                        AllOperations.Add(operation);
                        if (!AvailableAssets.Contains(operation.asset))
                        {
                            AvailableAssets.Add(operation.asset);
                        }
                    }   
                }  
            }

            AllOperations = AllOperations.OrderBy(x => x.dateProcess).ToList();

            Results res = new Results();

            foreach (Operation op in AllOperations)
            {
                if (!res.AssetUnitValue.ContainsKey(op.asset))
                {
                    res.AssetUnitValue[op.asset] = 0.0;
                    res.AssetTotalValue[op.asset] = 0.0;
                    res.AssetTotalQuantity[op.asset] = 0;
                    if (!allAssets && op.asset != assetName) continue;
                }

                if (op.type == OperationType.Compra)
                {
                    res.AssetUnitValue[op.asset] = (res.AssetUnitValue[op.asset] * res.AssetTotalQuantity[op.asset] + op.quantity * op.unitValue) / (res.AssetTotalQuantity[op.asset] + op.quantity);
                    res.AssetTotalQuantity[op.asset] = res.AssetTotalQuantity[op.asset] + op.quantity;
                    res.AssetTotalValue[op.asset] = res.AssetTotalValue[op.asset] + op.quantity * op.unitValue;                    
                }
                else
                {
                    res.AssetTotalQuantity[op.asset] = res.AssetTotalQuantity[op.asset] - op.quantity;
                    res.AssetTotalValue[op.asset] = res.AssetTotalValue[op.asset] - op.quantity * op.unitValue;
                }

                //if (!allAssets && op.asset != assetName)
                //{
                //    res.AssetTotalQuantity[op.asset] = 0;
                //}
            }

            return res;
        }
    }
}
