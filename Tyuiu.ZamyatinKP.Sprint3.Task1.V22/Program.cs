using Tyuiu.ZamyatinKP.Sprint3.Task1.V22.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        
        Console.WriteLine("Введите значение переменной a:");
        double value = Convert.ToDouble(Console.ReadLine());
        int startValue = 1;
        int stopValue = 20;

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.GetSumSeries(value, startValue, stopValue);
        Console.WriteLine(res);
    }
}