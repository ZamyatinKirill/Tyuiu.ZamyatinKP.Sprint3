using Tyuiu.ZamyatinKP.Sprint3.Task2.V30.Lib;

namespace Tyuiu.ZamyatinKP.Sprint3.Task2.V30.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 11;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 13051.34;

            Assert.Equal(res, wait);
        }
    }
}