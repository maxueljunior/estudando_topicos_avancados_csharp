using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Programação_Paralela_Two
{
    internal class ParametroDaThread
    {
        public int InicioContador
        {
            get; set;
        }
        public string Nome
        {
            get; set;   
        }

        public ParametroDaThread(int inicioContador, string nome)
        {
            InicioContador = inicioContador;
            Nome = nome;
        }   
    }
    internal class Program
    {
        public static void MinhaThreadSemParam()
        {
            int contador = 10;
            do
            {
                Console.WriteLine(contador++);
                Thread.Sleep(250);
            } while (contador <= 20);

        }

        public static void MinhaThreadComParam(object initCont)
        {
            int contador = (int) initCont;
            int final = contador + 10;
            do
            {
                Console.WriteLine(contador++);
                Thread.Sleep(250);
            } while (contador <= final);
        }

        public static void MinhaThreadComParam2(object paramThread)
        {
            ParametroDaThread parametroDaThread = (ParametroDaThread) paramThread;
            int contador = parametroDaThread.InicioContador;
            Console.WriteLine(parametroDaThread.Nome);
            int final = contador + 10;
            do
            {
                Console.WriteLine(contador++);
                Thread.Sleep(250);
            } while (contador <= final);
        }

        public static void MinhaThreadComParam3(int initCont, string nome)
        {
            int contador = initCont;
            Console.WriteLine(nome);
            int final = contador + 10;
            do
            {
                Console.WriteLine(contador++);
                Thread.Sleep(250);
            } while (contador <= final);
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(MinhaThreadSemParam));
            t1.Start();

            Console.ReadKey();
            Console.Clear();

            Thread t2 = new Thread(new ParameterizedThreadStart(MinhaThreadComParam));
            t2.Start(11);

            Console.ReadKey();
            Console.Clear();

            Thread t3 = new Thread(new ParameterizedThreadStart(MinhaThreadComParam2));
            ParametroDaThread paramThread = new ParametroDaThread(0, "Maxuel");
            t3.Start(paramThread);

            Console.ReadKey();
            Console.Clear();

            Thread t4 = new Thread(() => MinhaThreadComParam3(10, "João"));
            t4.Start();

            Console.ReadKey();
            Console.Clear();

            int initCont = 5;
            string nome = "Ketlhyn";
            Thread t5 = new Thread(() =>
            {
                int contador = initCont;
                Console.WriteLine(nome);
                int final = contador + 5;
                do
                {
                    Console.WriteLine(contador++);
                    Thread.Sleep(250);
                } while (contador <= final);
            });
            t5.Start();

            Console.ReadKey();
            Console.Clear();
        }
    }
}
