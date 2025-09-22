using Tyuiu.LeushinP.Sprint0.Task6.V0.Lib;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;


namespace Tyuiu.LeushinP.Sprint0.Task6.V0

{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArry(numsArray));
            Console.WriteLine("Разность элементов массива = " + DataService.SubtrationArray(numsArray));
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(numsArray));
            Console.ReadKey();
        }
    }
}