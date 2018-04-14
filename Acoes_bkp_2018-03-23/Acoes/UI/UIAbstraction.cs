using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acoes
{
    public class UIAbstraction
    {
        protected UIImplementor implementor;
        
        // Property
        public UIImplementor Implementor
        {
            set { implementor = value; }
        }

        //public virtual void Operation()
        //{
        //    implementor.Operation();
        //}

        //public virtual void Start()
        //{
        //    implementor.Start();
        //}

        public virtual void OpenFile()
        {
            implementor.OpenFile();
        }

        public virtual void ProcessFile()
        {
            implementor.ProcessFile();
        }

        public virtual void ProcessFile(bool lastYear, bool allAsset, string assetName)
        {
            implementor.ProcessFile(lastYear, allAsset, assetName);
        }

        public virtual void Search()
        {
            implementor.Search();
        }

        public virtual void ShowResults()
        {
            implementor.ShowResults();
        }

        public virtual void RestoreLastResult()
        {
            implementor.RestoreLastResult();
        }

    }
}
