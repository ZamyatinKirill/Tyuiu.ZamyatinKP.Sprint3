using Tyuiu.ZamyatinKP.Sprint3.Task3.V23.Lib;

namespace Tyuiu.ZamyatinKP.Sprint3.Task3.V23.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            string str = "fdsst siu vsrs";
            char replaceable = 's';
            char replacement = '8';
            string res = ds.ReplaceCharOnNum(str, replaceable, replacement);
            string wait = "fd88t 8iu v8r8";

            Assert.Equal(res, wait);
        }
    }
}