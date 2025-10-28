using Tyuiu.ZamyatinKP.Sprint3.Task5.V25.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int start1 = 1;
        int stop1 = 3;
        int start2 = 1;
        int stop2 = 10;
        int x = 2;
        double res = ds.GetSumSumSeries(x, start1, stop1, start2, stop2);

        Console.WriteLine(res);
    }
}