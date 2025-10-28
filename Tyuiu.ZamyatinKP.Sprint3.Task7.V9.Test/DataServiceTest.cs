using Tyuiu.ZamyatinKP.Sprint3.Task7.V9.Lib;

namespace Tyuiu.ZamyatinKP.Sprint3.Task7.V9.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            double[] res = ds.GetMassFunction(start, stop);
            double[] wait = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

            Assert.Equal(res, wait);
        }
    }
}