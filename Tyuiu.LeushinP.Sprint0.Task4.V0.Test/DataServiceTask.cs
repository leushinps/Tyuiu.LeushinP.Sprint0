using Tyuiu.LeushinP.Sprint0.Task4.V0.Lib;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
namespace Tyuiu.LeushinP.Sprint0.Task4.V0.Test
{
    public class DataServiceTest
    {

        [Test]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));

        }
        [Test]
        public void CheckedSabtrationValid()
        {
            Assert.AreEqual(10, DataService.Sabtration(10, 5));

        }
        [Test]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(10, DataService.Multiplication(10, 5));

        }
        [Test]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(10, DataService.Division(9, 3));

        }
    }
}