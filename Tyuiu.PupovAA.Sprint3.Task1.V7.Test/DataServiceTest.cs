using Tyuiu.PupovAA.Sprint3.Task1.V7.Lib;
namespace Tyuiu.PupovAA.Sprint3.Task1.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 0.25;
            int k = 1;
            int k2 = 9;

            var result = ds.GetMultiplySeries(a, k, k2);
            Assert.AreEqual(-8.950, result);
            
               
        }
    }
}