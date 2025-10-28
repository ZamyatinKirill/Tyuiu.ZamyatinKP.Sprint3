using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZamyatinKP.Sprint3.Task7.V9.Lib
{
    public class DataService : ISprint3Task7V9
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[11];
            int i = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double d = Math.Cos(x) - 2 * x;

                if (Math.Abs(d) < 0.000001)
                {
                    res[i] = 0;
                }
                else
                {
                    double frac = (2 * x - 3) / d;
                    double funcValue = frac + 5 * x - Math.Sin(x);
                    res[i] = Math.Round(funcValue, 2);
                }
                i++;
            }
            return res;
        }
    }
}
