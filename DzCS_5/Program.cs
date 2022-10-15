using System;

namespace DzCS_5
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 38: Задайте массив вещественных чисел. Найдите разницу
             между максимальным и минимальным элементов массива.

                [3 7 22 2 78] -> 76*/
            int[] arr = new int[new Random().Next(5, 11)]; //массив целых чисел
            double[] realArr = new Double[new Random().Next(5, 11)]; //массив вещественных чисел
            
            Console.WriteLine("Выберите задачу: \n" +
                              "1. Задача № 34; \n" +
                              "2. Задача № 36; \n" +
                              "3. Задача № 38; \n");
            
            int num = Convert.ToInt32(Console.ReadLine());
            
            switch (num)
            {
                case 1:
                    Console.WriteLine("Задача № 34");
                    RandThrArr(arr);
                    PrintArr(arr);
                    PrintEvenSum(arr);
                    break;
                case 2:
                    Console.WriteLine("Задача № 36");
                    RandArr(arr);
                    PrintArr(arr);
                    PrintSumOddPos(arr);
                    break;
                case 3:
                    Console.WriteLine("Задача № 38");
                    RandRealArr(realArr);
                    PrintRealArr(realArr);
                    DifMaxMinRealArr(realArr);
                    break;
            }
        }

        private static void DifMaxMinRealArr(double[] realArr)
        {
            Double max = realArr[0];
            Double min = realArr[0];

            for (int i = 0; i < realArr.Length; i++)
            {
                if (realArr[i] > max) max = realArr[i];
                else if (realArr[i] < min) min = realArr[i];
            }

            Double dif = max - min;
            Console.WriteLine($"Разница между Max и Min: {dif}");
        }

        private static void RandRealArr(double[] realArr)
        {
            Random rand = new Random();
            for (int i = 0; i < realArr.Length; i++)
            {
                realArr[i] = Math.Round(rand.NextDouble() * 100, 2);
            }
        }

        private static void PrintSumOddPos(int[] arr) // метод прин. масс и выводит в консл. сумму элемент на нечет поз.
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine($"Сумма элементов на не четных позициях: {sum}");
        }

        private static void PrintEvenSum(int[] arr) //метод принимает массив и выводит в консоль кол. пол. чисел
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

        private static void RandArr(int[] arr) //метод принимает на вход массив и заполняет его случ. числами
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-99, 100);
            }
        }
        
        private static void RandThrArr(int[] arr) //метод принимает на вход массив и заполняет его полож. трех.знач числами
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100, 1000);
            }
        }
        private static void PrintArr(int[] arr) //метода принимает на вход массив и выводит его в консоль
        {
            Console.Write("Массив: {");
            for (int i = 0; i < arr.Length; i++)
            {
                if(i == arr.Length - 1) Console.WriteLine(arr[i] + "}");
                else Console.Write($"{arr[i]}, ");
            }
        }
        
        private static void PrintRealArr(Double[] arr) //метода принимает на вход массив и выводит его в консоль
        {
            Console.Write("Массив: {");
            for (int i = 0; i < arr.Length; i++)
            {
                if(i == arr.Length - 1) Console.WriteLine(arr[i] + "}");
                else Console.Write($"{arr[i]}, ");
            }
        }
    }
}
