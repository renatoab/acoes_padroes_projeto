using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acoes
{
    public class Results
    {
        public Dictionary<string, int> AssetTotalQuantity;
        public Dictionary<string, double> AssetTotalValue;
        public Dictionary<string, double> AssetUnitValue;

        public Results()
        {
            AssetTotalQuantity = new Dictionary<string, int>();
            AssetTotalValue = new Dictionary<string, double>();
            AssetUnitValue = new Dictionary<string, double>();
        }

        public string TextResult()
        {
            string aux = $"Ativo   Quant   Val.Unit.   Val.Total\r\n";

            for (int i = 0; i < AssetTotalValue.Count(); i++)
            {
                if (AssetTotalQuantity.ElementAt(i).Value > 0)
                    aux = $"{aux + AssetTotalValue.ElementAt(i).Key}     " +
                          $"{AssetTotalQuantity.ElementAt(i).Value}     " +
                          $"{AssetUnitValue.ElementAt(i).Value}     " +   
                          $"{AssetTotalValue.ElementAt(i).Value}\r\n";
            }
            return aux;
        }

        public void RestoreMemento(ResultsMemento memento)
        {            
            AssetTotalQuantity = memento.AssetTotalQuantity;
            AssetTotalValue = memento.AssetTotalValue;
            AssetUnitValue = memento.AssetUnitValue;
        }
    }
}
