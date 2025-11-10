using Tyuiu.PupovAA.Sprint3.Task6.V29.Lib;
namespace Tyuiu.PupovAA.Sprint3.Task6.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 12;
            int y = 18;
            var result = ds.GetSumTheDivisors(x, y);
            Assert.AreEqual(178, result);
        }
    }
}
