using System;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] {6, 3, 8, 1, 9};

            System.Console.WriteLine("Array original");
            op.ImprimirArray(array);

            op.OrdernarBubbleSort(ref array);

            System.Console.WriteLine("Array ordenado:");
            op.ImprimirArray(array);

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