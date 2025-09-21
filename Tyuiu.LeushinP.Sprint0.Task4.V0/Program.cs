using Tyuiu.LeushinP.Sprint0.Task4.V0.Lib;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
namespace Tyuiu.LeushinP.Sprint0.Task4.V0

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));
            // сложение
            Console.WriteLine(DataService.Sabtration(15, 5));
            // вычитание
            Console.WriteLine(DataService.Multiplication(10, 10));
            // умножения
            Console.WriteLine(DataService.Division(5, 5));
            // деления
            Console.ReadKey();
        }
    }
}