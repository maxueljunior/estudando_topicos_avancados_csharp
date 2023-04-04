using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Programação_Paralela_Three
{
    internal class Program
    {
        static int ImprimeMensagem(int valorInit)
        {
            for (int i = valorInit; i < 10; i++)
            {
                Console.WriteLine("Eu sou um a TASK " + i);
                Thread.Sleep(500);
            }
            return 10;
        }
        static void Main(string[] args)
        {
            int resultadoTask = 0;
            Console.WriteLine(resultadoTask);
            Task taskImprimeMensagem = Task.Run(() => resultadoTask = ImprimeMensagem(5));
            
            if(taskImprimeMensagem.Wait(10000) == false)
            {
                Console.WriteLine("Erro, task não finalizou");
            }
            else
            {
                Console.WriteLine(resultadoTask);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Eu sou um a TASK MAIN " + i);
                Thread.Sleep(500);
            }
            Console.ReadKey();
        }
    }
}
