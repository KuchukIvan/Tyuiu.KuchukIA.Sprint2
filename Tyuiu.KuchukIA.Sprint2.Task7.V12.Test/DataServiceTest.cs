using Tyuiu.KuchukIA.Sprint2.Task7.V12.Lib;
namespace Tyuiu.KuchukIA.Sprint2.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea1()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 0.5;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
