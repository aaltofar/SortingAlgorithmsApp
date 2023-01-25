using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms;

internal class SortingMethods
{
    public int[] BubbleSort(int[] arr)
    {
        var num = arr.Length;
        for (int i = 0; i < num - 1; i++)
        {
            for (int j = 0; j < num - i - 1; j++)
            {
                var temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
        return arr;
    }

    public int[] InsertionSort(int[] arr)
    {

        return arr;
    }

    public void PrintArr(int[] ints)
    {

        foreach (var n in ints)
        {
            Console.Write(n);
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("#");
                Console.ResetColor();
            }
        }
    }
}

