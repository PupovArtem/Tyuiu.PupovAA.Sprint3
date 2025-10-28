using Tyuiu.PupovAA.Sprint3.Task0.V25.Lib;
namespace Tyuiu.PupovAA.Sprint3.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int s = 1;
            int k = 14;
            var number = ds.GetSumSeries(x , s, k);
            Assert.AreEqual(0.690, number);


        }
    }
}
