using Tyuiu.PupovAA.Sprint3.Task4.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Пупов А. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #18                                                              *");
        Console.WriteLine("* Выполнил: Пупов Артём Андреевич | ИБКСб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:   При х = 0 прервать цикл. Полученные значения суммировать.                *");
        Console.WriteLine("*На отрезке, где x принимает значения от -5 до 5, вычислить значение функции y=sin(x)/cos(x)*");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
        Console.WriteLine("***************************************************************************"); 
        int x1 = -5;
        int x2 = 5;
        var res = ds.Calculate(x1, x2);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);
        Console.ReadLine();

    }
}