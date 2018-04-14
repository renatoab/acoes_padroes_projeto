using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acoes
{
    class UIConsole : UIImplementor
    {
        public override void OpenFile()
        {
            try
            {
                StreamReader sr = new StreamReader("extrato_exemplo.txt");
                stringArquivoOperacoes = sr.ReadToEnd();
                sr.Close();
            }
            catch
            {

            }
        }

        public override void ProcessFile()
        {
            Console.WriteLine("Digite o nome do ativo a pesquisar, ou tecle ENTER para pesquisar todos");
            Console.WriteLine("Resultado:\n");

            string s = Console.ReadLine();
            if (s == "")
                base.ProcessFile(true, true, "");
            else
                try
                {
                    base.ProcessFile(true, false, s.ToUpper());
                }
                catch
                {
                    Console.WriteLine("Ativo não encontrado");
                }
        }

        public override void RestoreLastResult()
        {
            throw new NotImplementedException();
        }

        public override void ShowResults()
        {
            Console.WriteLine(results.TextResult());
        }
    }
}
