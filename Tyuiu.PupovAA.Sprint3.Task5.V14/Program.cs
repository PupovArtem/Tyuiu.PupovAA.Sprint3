using Tyuiu.PupovAA.Sprint3.Task5.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 5;
        int k1 = 1;
        int l1 = 1;
        int k2 = 3;
        int l2 = 14;
        var res = ds.GetSumSumSeries(x, k1, l1, k2, l2);
        Console.WriteLine(res);
    }
}