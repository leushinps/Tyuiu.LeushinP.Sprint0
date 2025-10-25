using System.ComponentModel.Design;
using System.Globalization;
using System.Numerics;

namespace Tyuiu.LeushinP.Sprint0.Task7.V0.Lib;


public class DataService
{
    public static int[] AdditionArrays(int[] numOne, int[] numTwo)
    {
        int[] resultArray = new int[numOne.Length];
        for (var i = 0; i < numOne.Length; i++)
        {
            resultArray[i] = numOne[i] + numTwo[i];
        }
        return resultArray;
    }
}
