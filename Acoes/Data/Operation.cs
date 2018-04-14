using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acoes
{
    public class Operation               // operação (compra/venda de ações)
    {
        public string asset;             // nome do ativo
        public DateTime dateInclusion;   // data de inclusao
        public DateTime dateProcess;     //
        public int quantity;             // quantidade
        public double unitValue;         // valor unitario
        public double totalValue;        // valor total
        public double taxValue;          // valor de taxa
        public string code;              // codigo da operacao
        public OperationStatus status;   // status da operação
        public OperationType type;       // 
        
        public Operation(string[] operationStringData)
        {
            code = operationStringData[0];

            if ((operationStringData[1].ToUpper()) == "VENDA")
            {
                type = OperationType.Venda;
            }
            else if((operationStringData[1].ToUpper()) == "COMPRA")
            {
                type = OperationType.Compra;
            }
            else
            {
                throw new Exception();
            }

            asset = operationStringData[2].ToUpper();

            if ((operationStringData[3].ToUpper()) == "PROCESSADA")
            {
                status = OperationStatus.Processada;
            }
            else if ((operationStringData[3].ToUpper()) == "CONFIRMADA")
            {
                status = OperationStatus.Confirmada;
            }
            else if ((operationStringData[3].ToUpper()) == "CANCELADA")
            {
                status = OperationStatus.Cancelada;
            }
            else if ((operationStringData[3].ToUpper()) == "VENCIDA")
            {
                status = OperationStatus.Vencida;
            }
            else
            {
                throw new Exception();
            }

            unitValue = Convert.ToDouble(operationStringData[4]);

            quantity = Convert.ToInt16(operationStringData[5]);

            // operationStringData[6]

            // operationStringData[7]

            // operationStringData[8]

            // operationStringData[9]

            dateInclusion = Convert.ToDateTime(operationStringData[10]);

            dateProcess = Convert.ToDateTime(operationStringData[11]);

        }
    }
}
