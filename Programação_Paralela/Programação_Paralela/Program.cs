using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Programação_Paralela
{
    internal class Program
    {
        static Thread t1;
        static Thread t2;
        static bool podeFinalizar;
        static int numeroDaThread;
        static object objLock;
        static Mutex meuMutex;

        static void MinhaThread1()
        {
            try
            {
                int i = 1;
                while (podeFinalizar == false)
                {
                    /*lock(objLock)
                    {
                        numeroDaThread = 1;
                        Thread.Sleep(1000);
                        Console.WriteLine("**Thread One** Passou " + i + " segundos, Numero da Thread " + numeroDaThread);
                        i++;
                    }*/

                    meuMutex.WaitOne();
                    numeroDaThread = 1;
                    Thread.Sleep(1000);
                    Console.WriteLine("**Thread One** Passou " + i + " segundos, Numero da Thread " + numeroDaThread);
                    i++;
                    meuMutex.ReleaseMutex();
                }
            }catch(ThreadAbortException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void MinhaThread2() {
            try
            {
                int i = 1;
                while (podeFinalizar == false)
                {
                    /*lock (objLock)
                    {
                        numeroDaThread = 2;
                        Thread.Sleep(1000);
                        Console.WriteLine("##Thread Two## Passou " + i + " segundos , Numero da Thread " + numeroDaThread);
                        i++; 
                    }*/

                    meuMutex.WaitOne();
                    numeroDaThread = 2;
                    Thread.Sleep(1000);
                    Console.WriteLine("##Thread Two## Passou " + i + " segundos , Numero da Thread " + numeroDaThread);
                    i++;
                    meuMutex.ReleaseMutex();
                }
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine(e.Message);
            }
        }  
        static void Main(string[] args)
        {
            /*for (int i =1; i<=5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Passou " + i + " segundo");
            }
            Console.ReadKey();*/

            objLock = new object();
            meuMutex = new Mutex();

            podeFinalizar = false;
            t1 = new Thread(new ThreadStart(MinhaThread1));
            t1.Priority = ThreadPriority.BelowNormal;
            t2 = new Thread(new ThreadStart(MinhaThread2));
            t2.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();

            Console.ReadKey();

            t1.Abort();
            t2.Abort();

            Console.WriteLine("Threads pararam...");
            Console.ReadKey();
        }
    }
}
