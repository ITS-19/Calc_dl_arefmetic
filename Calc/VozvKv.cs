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
    public static class VozKv
    {
        public static string Vozv_kv(string st1)//возведение в квадрат
        {
            BigInteger s1 = BigInteger.Parse(st1);
            BigInteger p;
            p = s1 * s1;
            string result = p + "";
            return result;
        }
    }
}
