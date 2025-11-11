using Tyuiu.PupovAA.Sprint3.Task7.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        
        Console.Title = "Спринт #3 | Выполнил: Пупов А. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                               *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #20                                                              *");
        Console.WriteLine("* Выполнил: Пупов Артём Андреевич | ИБКСб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл for, которая                           *");
        Console.WriteLine("* вычисляет сумму ряда по формуле, при X=5                                 *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
        Console.WriteLine("***************************************************************************");
        int startValue = -5;
        int stopValue = 5;
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);
        int len = ds.GetMassFunction(startValue, stopValue).Length;
        double[] valuearray; 
        valuearray = new double[len];

        valuearray = ds.GetMassFunction(startValue, stopValue);


        
       
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*-------------+------------+");
        Console.WriteLine("|     x       |     f(x)   |");
        Console.WriteLine("*-------------+------------+");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("|{0,5:d}        |    {1,5:f2}  |", startValue, valuearray[i]);
            startValue++;
        }
        Console.WriteLine("*-------------+------------+");
        Console.ReadKey();
    }
}