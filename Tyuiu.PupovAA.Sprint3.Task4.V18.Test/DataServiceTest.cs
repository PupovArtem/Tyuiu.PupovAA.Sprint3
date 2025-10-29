using Tyuiu.PupovAA.Sprint3.Task4.V18.Lib;
namespace Tyuiu.PupovAA.Sprint3.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x1 = -5;
            int x2 = 5;
            var res = ds.Calculate(x1, x2);
            Assert.AreEqual(2.993, res);
        }
    }
}
