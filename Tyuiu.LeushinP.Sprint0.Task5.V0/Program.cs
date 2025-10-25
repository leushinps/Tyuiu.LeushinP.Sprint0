using Tyuiu.LeushinP.Sprint0.Task5.V0.Lib;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;


namespace Tyuiu.LeushinP.Sprint0.Task5.V0

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Sabtration(15, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));
            Console.WriteLine("A / B = " + DataService.Division(9, 4));
            Console.ReadKey();
        }
    }
}