using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using static ExtendedNumerics.BigRational;
using System.Media;




namespace Calc
{
    public static class F
    {
        public static string Fact(string st1)//нахождение факториала
        {
            BigInteger s1 = BigInteger.Parse(st1);
            string result;
            if (s1 < 0)
            {
                result = "Ошибка, вы ввели отрицательное число!";
            }
            else
            {
                BigInteger p;
                p = 1;
                for (int i = 1; i < s1; i++)
                {
                    p += p * i;
                }
                result = p + "";
            }
            return result;
        }
    }
}
