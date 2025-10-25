using Tyuiu.LeushinP.Sprint0.Task2.V0.Lib;
namespace Tyuiu.LeushinP.Sprint0.Task2.V0.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckGetMessageValid()
        {
            var name = "Павел";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет., Павел", res);
        }
    }
}