using Tyuiu.PupovAA.Sprint3.Task3.V21.Lib;
namespace Tyuiu.PupovAA.Sprint3.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "f3g5ht g4j 34kg4";
            char ch = 'e';
            var res = ds.ReplaceNumOnChar(str, ch);
            Assert.AreEqual("fegeht gej eekge", res);
        }
    }
}
