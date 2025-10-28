using Tyuiu.ZamyatinKP.Sprint3.Task5.V25.Lib;

namespace Tyuiu.ZamyatinKP.Sprint3.Task5.V25.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            int start1 = 1;
            int stop1 = 3;
            int start2 = 1;
            int stop2 = 10;
            int x = 2;
            double res = ds.GetSumSumSeries(x, start1, stop1, start2, stop2);
            double wait = 2038.458;

            Assert.Equal(wait, res);
        }
    }
}