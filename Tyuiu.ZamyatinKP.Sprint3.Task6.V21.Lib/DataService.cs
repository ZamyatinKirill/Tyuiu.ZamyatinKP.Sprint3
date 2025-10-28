﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZamyatinKP.Sprint3.Task6.V21.Lib
{
    public class DataService : ISprint3Task6V21
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int res = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        res += d;
                    }
                }
            }
            return res;
        }
    }
}
