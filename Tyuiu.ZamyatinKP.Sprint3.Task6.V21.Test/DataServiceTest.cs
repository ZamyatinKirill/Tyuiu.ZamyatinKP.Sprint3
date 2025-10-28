using Tyuiu.ZamyatinKP.Sprint3.Task6.V21.Lib;

namespace Tyuiu.ZamyatinKP.Sprint3.Task6.V21.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            int start = 19;
            int stop = 30;
            int res = ds.GetSumTheDivisors(start, stop);
            int wait = 485;

            Assert.Equal(wait, res);
        }
    }
}