using Tyuiu.ZamyatinKP.Sprint3.Task4.V21.Lib;

namespace Tyuiu.ZamyatinKP.Sprint3.Task4.V21.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            double res = ds.Calculate(start, stop);
            double wait = 0;

            Assert.Equal(wait, res);
        }
    }
}