using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Nativa_1
{
    internal class Program
    {
        internal class CascaDLLNativa
        {
            [StructLayout(LayoutKind.Sequential)]   
            public struct MinhaEstrutura
            {
                public int valor1;
                public double valor2;
                public char valor3;
            }

            [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern double Soma(double a, double b);

            [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern double Media(double[] a, int quantidade);

            [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern void RecebeVetor([In, Out] int[] Vetor, int tamanho);

            [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool EnviaFrase(char[] Frase);

            [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern void LimpaMemoria();

            [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr RetornaString();

            [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr RetornaArrayDeBytes();

            [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern void RecebeEstrutura(ref MinhaEstrutura minhaEstrutura);

            [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool EnviaEstrutura(ref MinhaEstrutura minhaEstrutura);

            [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr RetornaEstrutura();
        }
        static void Main(string[] args)
        {
            double resultadoSoma = CascaDLLNativa.Soma(10, 20);
            Console.WriteLine(resultadoSoma);

            double[] valoresMedia = { 10, 20, 30 };
            double resultadoMedia = CascaDLLNativa.Media(valoresMedia, valoresMedia.Length);
            Console.WriteLine(resultadoMedia);

            int[] meuVetorInt = new int[3];
            CascaDLLNativa.RecebeVetor(meuVetorInt, meuVetorInt.Length);
            if (meuVetorInt[0] == 0 && meuVetorInt[1] == 1 && meuVetorInt[2] == 2)
            {
                Console.WriteLine("deu certo");
            }
            else
            {
                Console.WriteLine("deu errado");
            }

            char[] charEnviaFrase1 = ("EnviaFrase").ToCharArray();
            bool resultadoEnviaFrase1 = CascaDLLNativa.EnviaFrase(charEnviaFrase1);
            if (resultadoEnviaFrase1 == true) Console.WriteLine("String certa");
            else Console.WriteLine("String incorreta");

            IntPtr ptrParaStr = CascaDLLNativa.RetornaString();
            string minhaString = Marshal.PtrToStringAnsi(ptrParaStr);
            CascaDLLNativa.LimpaMemoria();
            Console.WriteLine(minhaString);

            IntPtr ptrParaByteArray = CascaDLLNativa.RetornaArrayDeBytes();
            byte[] byteArray = new byte[3];
            Marshal.Copy(ptrParaByteArray, byteArray, 0, byteArray.Length);
            CascaDLLNativa.LimpaMemoria();
            Console.WriteLine(ptrParaByteArray);

            CascaDLLNativa.MinhaEstrutura minhaEstrutura = new CascaDLLNativa.MinhaEstrutura();
            CascaDLLNativa.RecebeEstrutura(ref minhaEstrutura);

            if (minhaEstrutura.valor1 == 10 && minhaEstrutura.valor2 == 20 && minhaEstrutura.valor3 == 30) Console.WriteLine("correta estrtura");
            else Console.WriteLine("errada estrutura");

            CascaDLLNativa.MinhaEstrutura minhaEstrutura2 = new CascaDLLNativa.MinhaEstrutura();
            minhaEstrutura2.valor1 = 10;
            minhaEstrutura2.valor2 = 20;
            minhaEstrutura2.valor3 = 'a';

            bool returnEstrutura = CascaDLLNativa.EnviaEstrutura(ref minhaEstrutura2);
            Console.WriteLine(returnEstrutura);

            IntPtr ptrParaStruct = CascaDLLNativa.RetornaEstrutura();
            CascaDLLNativa.MinhaEstrutura minhaEstrutura3 = new CascaDLLNativa.MinhaEstrutura();
            minhaEstrutura3 = (CascaDLLNativa.MinhaEstrutura)Marshal.PtrToStructure(ptrParaStruct, typeof(CascaDLLNativa.MinhaEstrutura));
            CascaDLLNativa.LimpaMemoria();
            if (minhaEstrutura3.valor1 == 10 && minhaEstrutura3.valor2 == 20 && minhaEstrutura3.valor3 == 30) Console.WriteLine("correta estrtura");
            else Console.WriteLine("errada estrutura");

            Console.ReadKey();
        }
    }
}
