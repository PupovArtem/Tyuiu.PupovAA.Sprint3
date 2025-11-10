using Tyuiu.PupovAA.Sprint3.Task6.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 12;
        int y = 18;
        var result = ds.GetSumTheDivisors(x, y);
        Console.WriteLine(result);
    }
}