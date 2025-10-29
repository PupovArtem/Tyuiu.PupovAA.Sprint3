using Tyuiu.PupovAA.Sprint3.Task5.V14.Lib;
namespace Tyuiu.PupovAA.Sprint3.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int k1 = 1;
            int l1 = 1;
            int k2 = 3;
            int l2 = 14;
            var res = ds.GetSumSumSeries(x, k1, l1, k2, l2);
            Assert.AreEqual(-31.275, res);
        }
    }
}
