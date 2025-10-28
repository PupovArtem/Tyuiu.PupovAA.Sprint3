using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PupovAA.Sprint3.Task0.V25.Lib
{
    public class DataService : ISprint3Task0V25
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double s = 0;
            for (int i = startValue; i < stopValue; i++)
            {
                s =  s+ Math.Pow((4 / (1 + Math.Pow(value, i))), i);
            }
            return Math.Round(s, 3);
        }
    }
}
