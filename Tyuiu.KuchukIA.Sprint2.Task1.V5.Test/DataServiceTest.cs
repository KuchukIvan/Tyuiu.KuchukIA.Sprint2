using Tyuiu.KuchukIA.Sprint2.Task1.V5.Lib;
namespace Tyuiu.KuchukIA.Sprint2.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 154;
            int b = 163;
            int c = 134;
            int d = 137;

            bool[] res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, false, false, false, true, false };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
