using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZamyatinKP.Sprint3.Task3.V23.Lib
{
    public class DataService : ISprint3Task3V23
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            string str = value;
            string res = "";
            foreach (char c in str)
            {
                if (c == replaceable)
                {
                    res += replacement;
                }
                else
                {
                    res += c;
                }
            }

            return res;
        }
    }
}
