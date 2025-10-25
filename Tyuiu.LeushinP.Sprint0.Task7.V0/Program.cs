using System;
using Tyuiu.LeushinP.Sprint0.Task7.V0.Lib;

namespace Tyuiu.LeushinP.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Леушин П.С | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Леушин Павел Сергеевич | СМАРТб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
            Console.WriteLine("* одинаковых по длине массивов поэлементно.                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arrayNums2 = new int[] { 6, 7, 8, 9, 10 };

            Console.WriteLine("Значение элементов массива 1:");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.WriteLine($"arrayNums1[{i}] = {arrayNums1[i]}");
            }
            Console.WriteLine();

            Console.WriteLine("Значение элементов массива 2:");
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.WriteLine($"arrayNums2[{i}] = {arrayNums2[i]}");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);
                Console.WriteLine("Сумма элементов массивов равна:");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.WriteLine($"arrayNums1[{i}] + arrayNums2[{i}] = {resultArray[i]}");
                }
            }
            else
            {
                Console.WriteLine("Ошибка!");
            }

            Console.ReadKey();
        }
    }
}
