using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZamyatinKP.Sprint3.Task2.V30.Lib
{
    public class DataService : ISprint3Task2V30
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double res = 1.0;
            int i = startValue;

            do
            {
                res *= (Math.Pow(value, 2) * i) + 2;
                i++;
            }   while (i <= stopValue);

            return Math.Round(res, 3);
        }
    }
}
