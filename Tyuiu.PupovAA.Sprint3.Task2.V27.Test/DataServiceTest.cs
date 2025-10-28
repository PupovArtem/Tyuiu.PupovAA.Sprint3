using Tyuiu.PupovAA.Sprint3.Task2.V27.Lib;
namespace Tyuiu.PupovAA.Sprint3.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int k = 1;
            int k2 = 14;
            double res = ds.GetSumSeries(x, k, k2);
            Assert.AreEqual(0.69, res);

        }
    }
}
