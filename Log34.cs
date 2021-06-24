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
    public static class Log34
    {
	public static string Logarifm(string st1, string st2)//логарифм числа
        {
            string result = "";
            if (!(st1.ToLower().Contains('-')) && !(st2.ToLower().Contains('-')))
            {
                BigInteger s1 = BigInteger.Parse(st1);
                double s2 = double.Parse(st2);
                double u = BigInteger.Log(s1, s2);
                Math.Round(u, 15);
                result = u + "";
            }
            else
            {
                result = "Вы ввели отрицательное число!";
            }
            return result;
        }
    }
}
