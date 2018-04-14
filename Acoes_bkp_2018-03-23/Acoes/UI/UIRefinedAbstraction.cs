using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acoes
{
    class UIRefinedAbstraction : UIAbstraction
    {
        //public override void Operation()
        //{
        //    implementor.Operation();
        //}

        //public override void Start()
        //{
        //    implementor.Start();
        //}

        public override void OpenFile()
        {
            implementor.OpenFile();
        }

        public override void Search()
        {
            implementor.Search();
        }

        public override void ShowResults()
        {
            implementor.ShowResults();
        }

        public override void RestoreLastResult()
        {
            implementor.RestoreLastResult();
        }

        public ResultsMemento SaveMemento(Results results)
        {
            return implementor.SaveMemento(results);
        }

    }
}
