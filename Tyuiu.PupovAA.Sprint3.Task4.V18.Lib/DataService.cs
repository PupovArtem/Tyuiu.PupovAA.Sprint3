using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PupovAA.Sprint3.Task4.V18.Lib
{
    public class DataService : ISprint3Task4V8
    {
        public double Calculate(int startValue, int stopValue)
        {
            double count = 0;
            for (int i = startValue; i <= stopValue; i++)
            { 
                if (i == 0)
                {
                    break;
                }
                double y = Math.Tan(i);
                count += y;

            
            }
            return Math.Round(count,3);


        }
    }
}
