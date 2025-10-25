using System;

namespace Tyuiu.LeushinP.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static int AdditionArray(int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            return total;
        }

        public static int SubtractionArray(int[] numbers)
        {
            if (numbers.Length == 0) return 0;

            int total = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                total -= numbers[i];
            }
            return total;
        }

        public static int MultiplicationArray(int[] numbers)
        {
            if (numbers.Length == 0) return 0;

            int total = 1;
            foreach (int number in numbers)
            {
                total *= number;
            }
            return total;
        }
    }
}