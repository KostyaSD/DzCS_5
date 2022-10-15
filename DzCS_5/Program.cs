using System;

namespace DzCS_5
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
                         Напишите программу, которая покажет количество чётных чисел в массиве.

                         [345, 897, 568, 234] -> 2*/

            Console.WriteLine("Задача № 34");
            int[] arr = new int[5];
            RandArr(arr);
            PrintArr(arr);
            EvenSum(arr);
            
        }

        private static void EvenSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum++;
                }
            }
            Console.WriteLine($"Количество четных чисел: {sum}");
        }

        private static void RandArr(int[] arr) //метод принимает на вход массив и заполняет его полож. трех.знач числами
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100, 1000);
            }
        }
        private static void PrintArr(int[] arr) //метода принимает на вход массив и выводит его в консоль
        {
            Console.Write("{");
            for (int i = 0; i < arr.Length; i++)
            {
                if(i == arr.Length - 1) Console.WriteLine(arr[i] + "}");
                else Console.Write($"{arr[i]}, ");
            }
        }
    }
            /*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

                [3, 7, 23, 12] -> 19

                [-4, -6, 89, 6] -> 0

            Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

                [3 7 22 2 78] -> 76#1#*/
            
}
