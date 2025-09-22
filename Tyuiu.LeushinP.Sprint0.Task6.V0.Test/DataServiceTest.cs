using Tyuiu.LeushinP.Sprint0.Task6.V0.Lib;

using System;

namespace Tyuiu.LeushinP.Sprint0.Task6.V0.Test
{
    public class DataServiceTest
    {


        [Test]
        public void CheckAdditionValid()
        {
            var numbres = new int[] {1, 2, 3, 4, 5};
            var res = DataService.AdditionArry(numbers);
            // ожидаем 15 от рес
            Assert.AreEqual(15, res);

        }
        [Test]
        public void CheckSubtractionValid()
        {
            var numbres = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtractionArray(numbers);
            // ожидаем 15 от рес
            Assert.AreEqual(-15, res);

        }
        [Test]
        public void CheckMultiplicationValid()
        {
            var numbres = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numbers);
            // ожидаем 15 от рес
            Assert.AreEqual(120, res);

        }
    }
}