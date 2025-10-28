using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PupovAA.Sprint3.Task2.V27.Lib
{
    public class DataService : ISprint3Task2V27
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double s = 0;
            do
            {
                s= s + Math.Pow((4/(1+Math.Pow(value, startValue))),startValue);
                startValue++;

            }while(startValue <= stopValue);
            return Math.Round(s, 3);
        }
    }
}
