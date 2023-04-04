using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Programação_Paralela_Async_Awaits
{
    internal class Program
    {
        public static string compraBolo(string nomeDoFilho)
        {
            Console.WriteLine(nomeDoFilho + " foi no mercado. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            Thread.Sleep(2000);
            Console.WriteLine(nomeDoFilho + " Comprou o bolo. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            Thread.Sleep(2000);
            Console.WriteLine(nomeDoFilho + " Voltou para casa. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            Thread.Sleep(2000);
            return "Abacaxi";
        }

        public static string compraBexiga(string nomeDoFilho)
        {
            Console.WriteLine(nomeDoFilho + " foi no mercado. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            Thread.Sleep(2000);
            Console.WriteLine(nomeDoFilho + " Comprou a bexiga. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            Thread.Sleep(2000);
            Console.WriteLine(nomeDoFilho + " Voltou para casa. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            Thread.Sleep(2000);
            return "Vermelho";
        }

        /*AQUI ESTÃO OS METODOS ASYNCS
         */
        public static async Task<string> compraBoloAsync(string nomeDoFilho)
        {
            Console.WriteLine(nomeDoFilho + " foi no mercado. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            await Task.Delay(2000);
            Console.WriteLine(nomeDoFilho + " Comprou o bolo. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            await Task.Delay(2000);
            Console.WriteLine(nomeDoFilho + " Voltou para casa. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            await Task.Delay(2000);
            return "Abacaxi";
        }

        public static async Task<string> compraBexigaAsync(string nomeDoFilho)
        {
            Console.WriteLine(nomeDoFilho + " foi no mercado. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            await Task.Delay(2000);
            Console.WriteLine(nomeDoFilho + " Comprou a bexiga. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            await Task.Delay(2000);
            Console.WriteLine(nomeDoFilho + " Voltou para casa. A hora atual é: " + DateTime.Now.ToString("HH:mm:ss tt"));
            await Task.Delay(2000);
            return "Vermelho";
        }

        public static async void FazFesta()
        {
            Task<string> compraBolo = compraBoloAsync("José");
            Task<string> compraBexiga = compraBexigaAsync("Maxuel");

            string sabor = await compraBolo;
            string cor = await compraBexiga;

            Console.WriteLine("Sabor do Bolo: " + sabor + " Cor: " + cor);
        }
        static void Main(string[] args)
        {
            //string sabor = compraBolo("José");
            //string cor = compraBexiga("Maxuel");
            FazFesta();
            Console.ReadKey();
        }
    }
}
