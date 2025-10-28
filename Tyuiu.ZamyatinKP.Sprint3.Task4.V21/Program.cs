using Tyuiu.ZamyatinKP.Sprint3.Task4.V21.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int start = -5;
        Console.WriteLine("Начало отрезка: " +  start);
        int stop = 5;
        Console.WriteLine("Конец отрезка: " + stop);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        double res = ds.Calculate(start, stop);
        Console.WriteLine(res);
    }
}