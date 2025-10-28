using Tyuiu.ZamyatinKP.Sprint3.Task7.V9.Lib;

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
        int start = -5;
        int stop = 5;
        double[] res = ds.GetMassFunction(start, stop);

        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine($"results[{i}] = {res[i]}");
        }
    }
}