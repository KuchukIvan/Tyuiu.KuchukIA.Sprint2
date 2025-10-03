using Tyuiu.KuchukIA.Sprint2.Task5.V11.Lib;
namespace Tyuiu.KuchukIA.Sprint2.Task5.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            int g = 2020;
            int m = 2;
            int n = 28;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "1.3.2020";
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            int g = 2020;
            int m = 6;
            int n = 30;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "1.7.2020";
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            int g = 2020;
            int m = 12;
            int n = 31;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "1.1.2021";
            Assert.AreEqual(wait, res);

        }
    }
}
