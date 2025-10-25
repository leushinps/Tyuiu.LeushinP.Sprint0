using NUnit.Framework;
using Tyuiu.LeushinP.Sprint0.Task6.V0.Lib;
using System;

namespace Tyuiu.LeushinP.Sprint0.Task6.V0.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void CheckAdditionValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }

        [Test]
        public void CheckSubtractionValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtractionArray(numbers);
            Assert.AreEqual(-15, res);
        }

        [Test]
        public void CheckMultiplicationValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}