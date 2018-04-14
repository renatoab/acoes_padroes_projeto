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
            // Essa chamada do metodo nao está disponível para esta implementação de interface
            throw new NotImplementedException();
        }

        public override void ShowResults()
        {
            form.refreshTextBox();
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

    }
}
