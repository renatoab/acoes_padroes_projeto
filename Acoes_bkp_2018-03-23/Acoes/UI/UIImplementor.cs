using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acoes
{
    public abstract class UIImplementor
    {
        public ResultsMemento resultsMemento;
        public Results results;
        public OperationBase operationBase;
        public string stringArquivoOperacoes;

        //public abstract void Start();
        public abstract void OpenFile();
        //public abstract void ProcessFile(bool lastYear, bool allAsset, string assetName);
        public abstract void Search();
        public abstract void ShowResults();
        //public abstract void Operation();
        public abstract void RestoreLastResult();
        public abstract void ProcessFile();

        public ResultsMemento SaveMemento(Results results)
        {
            return new ResultsMemento(results);
        }

        public virtual void ProcessFile(bool lastYear, bool allAsset, string assetName)
        {
            if (results != null)
            {
                resultsMemento = SaveMemento(results);
            }

            try
            {
                OperationBase.Instance.LastYear = lastYear;                
                OperationBase.Instance.AllAssets = allAsset;
                if (assetName.Trim() == "")
                    OperationBase.Instance.AllAssets = true;
                if (!OperationBase.Instance.AllAssets) OperationBase.Instance.assetName = assetName.ToUpper();
                results = OperationBase.Instance.ProcessFile(stringArquivoOperacoes);
            }
            catch
            {
                throw new Exception();
            }
        }

    }
}
