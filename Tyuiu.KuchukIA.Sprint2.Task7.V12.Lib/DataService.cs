using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KuchukIA.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (((x >= 0) && (x <= 2) && (y >= 0) && (y <= 1) && (y <= 2 - x) && (y <= Math.Pow(x, 2))) || ((y <= -2) && (y >= 4) && (y >= 2 - x) && (y <= Math.Pow(x, y))))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
