using Tyuiu.ZamyatinKP.Sprint3.Task2.V30.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение переменной x:");
        double value = Convert.ToDouble(Console.ReadLine());
        int startValue = 1;
        int stopValue = 11;

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.GetMultiplySeries(value, startValue, stopValue);
        Console.WriteLine(res);
    }
}