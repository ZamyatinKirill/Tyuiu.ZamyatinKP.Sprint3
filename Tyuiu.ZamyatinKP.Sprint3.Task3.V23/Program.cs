using Tyuiu.ZamyatinKP.Sprint3.Task3.V23.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string str = "fdsst siu vsrs";
        char replaceable = 's';
        char replacement = '8';

        Console.WriteLine("Строка: " + str);
        Console.WriteLine("Заменить букву: " + replaceable);
        Console.WriteLine("На цифру: " + replacement);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.ReplaceCharOnNum(str, replaceable, replacement);
        Console.WriteLine(res);
    }
}