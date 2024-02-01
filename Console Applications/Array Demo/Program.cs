using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Array_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] noArray = { 1, 3, 2, 4 };
            Console.WriteLine(noArray.Length);

            int[] noArray2 = new int[] { 1, 3, 1, 2, 4 };
            Console.WriteLine(noArray2.Length);

            int[] noArray3 = new int[5];
            Console.WriteLine(noArray3.Length);

            int[] dynamicArray;
            int size;
            Console.Write("Enter the size of an array:- ");
            bool success = int.TryParse(Console.ReadLine(), out size);
            if(success)
            {
                dynamicArray = new int[size];
            }
            else
            {
                Console.Beep();
                dynamicArray = new int[1];
                Thread.Sleep(500);
            }
            Console.WriteLine($"Size of Dynamic Array: {dynamicArray.Length}");
            Console.WriteLine("Value of noArray2");
            PrintArray(noArray2);
            Console.WriteLine();
            Console.WriteLine("Value of dynamicArray");
            PrintArray(dynamicArray);
            Console.WriteLine();
            Console.WriteLine("Value of Param Parameter");
            PrintParam(3, 4, 5, 1, 2, 45, 22, 44, 66, 11);
            Console.WriteLine();
            int max, min;
            MinMax(out max, out min, 12, 10, 2, 22);
            Console.WriteLine($"Max:- {max} \n Min:- {min}");
            // 2-D array
            int[,] d2 = new int[2, 3]
            {
                {1,2,3 },
                {3,4,6 }
            };
            Console.WriteLine(d2.Length);
            Console.WriteLine(d2.GetLength(0));//Row
            Console.WriteLine(d2.GetLength(1));//Column
            int s = 0;
            foreach(int v in d2)
            {
                Console.WriteLine(v.GetType().ToString() + " : " + v + "\t");
                s += v;
            }

            //Jagged Array

            int[][] jarray = new int[3][];
            jarray[0] = new int[2] { 1, 2 };
            jarray[1] = new int[3] { 3, 4, 5 };
            jarray[2] = new int[1] { 6 };

            foreach(int[] v in jarray)
            {
                s = 0;
                Array.ForEach(v, each => Console.Write(each + "\t"));
                Array.ForEach(v, each => s += each);
                Console.WriteLine(s);
            }
            Console.Read();
        }
        static void PrintArray(int[] arr)
        {
            foreach (int value in arr)
                Console.Write($"{value}\t");
        }
        static void PrintParam(int a, params int[] arr)
        {
            /*foreach (int value in arr)
                Console.Write($"{value}\t");*/
            Array.ForEach(arr, each => Console.Write(each+"\t"));
        }
        static void MinMax(out int max, out int min, params int[] arr)
        {
            /*max = arr[0];
            min = arr[0];


            foreach(int value in arr)
            {
                max = max > value ? max : value;
                min = min > value ? value : min;*/
            int tmax, tmin;
            tmin = tmax = arr[0];
            Array.ForEach(arr, each => tmax = each > tmax ? each : tmax);
            Array.ForEach(arr, each => tmin = each > tmin ? tmin : each);
            max = tmax;
            min = tmin;
            }
        }
 }
