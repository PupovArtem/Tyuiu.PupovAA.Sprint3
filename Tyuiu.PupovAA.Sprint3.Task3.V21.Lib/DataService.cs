
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PupovAA.Sprint3.Task3.V21.Lib
{
    public class DataService : ISprint3Task3V21
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string str = value;
            foreach (char x in str)
            {
                if (Char.IsDigit(x))
                {
                    str = str.Replace(x, item);
                }

            }
            return str;
        }
    }
}
