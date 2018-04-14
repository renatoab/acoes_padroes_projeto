using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acoes
{
    public class UIWindows : UIImplementor
    {
        Form1 form;

        public UIWindows()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1(this);
            Application.Run(form);
        }

        //Form form;

        public override void OpenFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Arquivo txt|*.txt";
            openFileDialog1.Title = "Abrir arquivo de histórico de operações";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                stringArquivoOperacoes = sr.ReadToEnd();
                sr.Close();
            }
            else
            {
                throw new Exception();
            }
        }

        public override void ProcessFile()
        {
            throw new NotImplementedException();
        }

        //public override void ProcessFile(bool lastYear, bool allAsset, string assetName)
        //{
        //    if (results != null)
        //    {
        //        resultsMemento = SaveMemento(results);
        //    }

        //    try
        //    {
        //        OperationBase.Instance.LastYear = lastYear;
        //        OperationBase.Instance.AllAssets = allAsset;
        //        if (!OperationBase.Instance.AllAssets) OperationBase.Instance.assetName = assetName;
        //        results = OperationBase.Instance.ProcessFile(stringArquivoOperacoes);
        //    }
        //    catch
        //    {
        //        throw new Exception();
        //    }
        //}

        //public override void Operation()
        //{
        //    Console.WriteLine("ConcreteImplementorA Operation");
        //}

        public override void Search()
        {
            throw new NotImplementedException();
        }

        public override void ShowResults()
        {
            throw new NotImplementedException();
        }

        public override void RestoreLastResult()
        {
            try
            {
                results.RestoreMemento(resultsMemento);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }


        //public override void Start()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
