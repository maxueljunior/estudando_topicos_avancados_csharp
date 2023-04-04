using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Programação_Paralela_Mutex_Semaphore
{
    internal class Program
    {
        static Mutex mutexTask;
        static Semaphore semaphoreTask;

        static void MostraMensagem(int numeroTask)
        {
            semaphoreTask.WaitOne();
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("Numero da TASK: " + numeroTask + " contador nº " + i);
                Thread.Sleep(500);
            }
            semaphoreTask.Release();
        }

        static void Main(string[] args)
        {
            mutexTask = new Mutex();
            semaphoreTask = new Semaphore(2, 2);
            Task t1 = Task.Run(() => MostraMensagem(1));
            Task t2 = Task.Run(() => MostraMensagem(2));
            Task t3 = Task.Run(() => MostraMensagem(3));
            Task t4 = Task.Run(() => MostraMensagem(4));

            Console.ReadKey();
        }
    }
}
