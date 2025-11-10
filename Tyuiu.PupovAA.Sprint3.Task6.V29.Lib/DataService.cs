using System.Security.Cryptography;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PupovAA.Sprint3.Task6.V29.Lib
{
    public class DataService : ISprint3Task6V29
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sim = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int j = 1; j<= stopValue; j++)
                {
                    if (i%j == 0)
                    {
                        sim += j;
                    }
                }
            }
            return sim;
        }
    }
}
