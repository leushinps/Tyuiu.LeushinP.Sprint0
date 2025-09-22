using System.ComponentModel.Design;
using System.Globalization;
using System.Numerics;

namespace Tyuiu.LeushinP.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] numbers);
        {

            var total = 0;
            for (var i = 0; i < numbers.Length; i++)
            { 
                total = total + numbers[i];
            }
            return total;
        }
                                // пред условие цикл фунц while
        public static object SubbractionArray(int[] numbers)
        {
            var total = 0;
            int index = 0;


            while (index < numbers.Length)
            {
                total = total - numbers[index];
                index++;
            }
            return total;
        }

                                                // пост условие do while
        public static object MultiplucationArray(int[] numbers)
        {
            var total = 1;
            int index = 0;
            do
            {
                total = total - numbers[index];
                index++;
            }
            while (index < numbers.Length);
            return total;

        }

    }
}