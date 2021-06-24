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
    public static class Func
    {
	public static string NLogarifm(string st1)//натуральный логарифм 
        {
            string result = "";
            if (!(st1.ToLower().Contains('-')))
            {
                BigInteger s1 = BigInteger.Parse(st1);
                double u = BigInteger.Log(s1);
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
