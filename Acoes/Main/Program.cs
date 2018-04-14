using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acoes
{
    static class Program
    {        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UIAbstraction uIAbstraction = new UIRefinedAbstraction();

            Console.WriteLine("Este programa interpreta um arquivo gerado por uma corretora de ações,");
            Console.WriteLine("(arquivo extrato_exemplo.txt, que se encontra junto ao projeto)");
            Console.WriteLine("e calcula o valor médio de compra por ativo para auxiliar na declaração");
            Console.WriteLine("de imposto de renda");

            Console.WriteLine("\nForam usados os seguintes padrões de projeto: Singleton, Bridge e Memento");
            Console.WriteLine("-> O Singleton é utilizado na classe que tem o banco de dados (classe OperationBase),");
            Console.WriteLine("   para que ela não possa ter mais de uma instância.");
            Console.WriteLine("-> O Bridge é utilizado de forma que haja 2 opções de interface do usuário:");
            Console.WriteLine("   uma Windows Forms e outra Console Application, tendo suas implementações");
            Console.WriteLine("   separadas da abstração");
            Console.WriteLine("-> O Memento é utilizado para armazenar o resultado de uma busca no modo Windows Forms");
            Console.WriteLine("   para que seja possível recuperar uma busca anterior");

            Console.WriteLine("\nTecle 1 para modo Console ou 2 para modo Windows Application");

            string s = Console.ReadLine();

            //ConsoleKeyInfo k = Console.ReadKey();
            //if (k.KeyChar == '1')
            if (s == "1")
            {
                Console.WriteLine();
                uIAbstraction.Implementor = new UIConsole();
                uIAbstraction.OpenFile();
                try
                {
                    uIAbstraction.ProcessFile();
                    uIAbstraction.ShowResults();
                }
                catch
                {
                    Console.WriteLine("\nEste ativo não foi encontrado. Favor executar o programa de novo");
                    return;
                }
                               

                Console.WriteLine("\nDigite qualquer tecla para encerrar");
                Console.ReadKey();
            }
            else
            {
                uIAbstraction.Implementor = new UIWindows();
                
            }            
        }
    }
}
