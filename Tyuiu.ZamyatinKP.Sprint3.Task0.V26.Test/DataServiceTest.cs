using Tyuiu.ZamyatinKP.Sprint3.Task0.V26.Lib;

namespace Tyuiu.ZamyatinKP.Sprint3.Task0.V26.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 9;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = -15.642;

            Assert.Equal(wait, res);
        }
    }
}