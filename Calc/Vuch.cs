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
    public static class Vuc
    {
	public static string Vuch(string st1, string st2)//вычитание
        {
            BigInteger s1 = BigInteger.Parse(st1);
            BigInteger s2 = BigInteger.Parse(st2);
            BigInteger r = s1 - s2;
            string result = r + "";
            return result;
        }
    }
}
