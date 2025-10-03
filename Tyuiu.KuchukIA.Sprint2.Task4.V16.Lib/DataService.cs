using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KuchukIA.Sprint2.Task4.V16.Lib
{
    public class DataService : ISprint2Task4V16
    {
        public double Calculate(double x, double y)
        {
            double z = (x * 2) < (y * 2) ? Math.Pow((1 + 1 / (y * y)), x) : y - (1 / (x * x));
            return Math.Round(z, 3);
        }
    }
}