using Tyuiu.ZamyatinKP.Sprint3.Task1.V22.Lib;

namespace Tyuiu.ZamyatinKP.Sprint3.Task1.V22.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            double value = 1.5;
            int startValue = 1;
            int stopValue = 20;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 3550.301;

            Assert.Equal(res, wait);
        }
    }
}