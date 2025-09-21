using Tyuiu.LeushinP.Sprint0.Task3.V0.Lib;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
namespace Tyuiu.LeushinP.Sprint0.Task3.V0.Test




{
    public class DataServiceTest
    {

        [Test]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));

        }
    }
}