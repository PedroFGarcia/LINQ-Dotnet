using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesLista opLista = new OperacoesLista();
            List<string> estados = new List<string>{"SP", "MG","SC"};
            string[] estadosArray = new string[2] {"RS", "PR"};

            System.Console.WriteLine($"Quanditade de elementos na lista: {estados.Count}");

            opLista.ImprimirListaString(estados);

            // System.Console.WriteLine("Removendo elemento");
            // estados.Remove("MG");

            // estados.AddRange(estadosArray);
            estados.Insert(1, "RJ");

            opLista.ImprimirListaString(estados);

            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[5] {6, 3, 8, 1, 9};
            // int[] arrayCopia = new int[10];
            // string[] arrayString = op.ConverterParaArrayString(array);

            // int valorProcurado = 8;

            // System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

            // op.RedimensionarArray(ref array, array.Length * 2);

            // System.Console.WriteLine($"Capacidade após redimensionar: {array.Length}");

            // int indice = op.ObterIndice(array, valorProcurado);

            // if(indice > -1)
            // {
            //     System.Console.WriteLine("O indice do elemento {0} é: {1}", valorProcurado, indice);
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não existe no array");
            // }

            // int valorAchado = op.ObterValor(array, valorProcurado);

            // if(valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei");
            // }

            // bool existe = op.Existe(array, valorProcurado);

            // if(existe)
            // {
            //     System.Console.WriteLine("Encontrado {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrado {0}", valorProcurado);
            // }

            // System.Console.WriteLine("Array original");
            // op.ImprimirArray(array);

            // op.OrdernarBubbleSort(ref array);
            // op.Ordernar(ref array);

            // System.Console.WriteLine("Array ordenado:");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da cópia:");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array pós copia");
            // op.ImprimirArray(arrayCopia);

            // int[,] matriz = new int[4,2]
            // {
            //     {8 , 8},
            //     {10, 20},
            //     {50, 100},
            //     {90, 200},
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i,j]);
            //     }
            // }

            // int[] arrayInteiros = new int[3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = int.Parse("30");
            // arrayInteiros[3] = 30;

            // System.Console.WriteLine("For");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("Foreach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}