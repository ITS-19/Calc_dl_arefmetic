
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Calc
{
    public static class VozN
    {
        public static string Vozv_n_stp(string st1, string st2)//возведения в n-ю степень
        {
            BigInteger s1 = BigInteger.Parse(st1);
            int s2 = int.Parse(st2);
            string result = "";
            if (s1 >= 0 && s2 >= 0)
            {
                BigInteger u = BigInteger.Pow(s1, s2);
                result = u + "";

            }
            else if (s1 < 0 && s2 >= 0)
            {
                s1 *= -1;
                BigInteger u = BigInteger.Pow(s1, s2);
                if (s2 % 2 == 0) result = u + "";
                else
                {
                    u *= -1; result = u + "";
                }
            }
            else if (s1 > 0 && s2 < 0)
            {
                s2 *= -1;
                BigInteger u = BigInteger.Pow(s1, s2);
                string rat = u + "", rat1 = 1 + "";
                ExtendedNumerics.BigRational ss = ExtendedNumerics.BigRational.Parse(rat);
                ExtendedNumerics.BigRational sd = ExtendedNumerics.BigRational.Parse(rat1);
                ExtendedNumerics.BigRational ss1 = sd / ss;
                result = ss1 + "";
            }
            else if (s1 < 0 && s2 < 0)
            {
                s2 *= -1; s1 *= -1;
                BigInteger u = BigInteger.Pow(s1, s2);
                string rat = u + "", rat1 = 1 + "";
                ExtendedNumerics.BigRational ss = ExtendedNumerics.BigRational.Parse(rat);
                ExtendedNumerics.BigRational sd = ExtendedNumerics.BigRational.Parse(rat1);
                ExtendedNumerics.BigRational ss1 = sd / ss;
                if (s2 % 2 == 0)
                {
                    result = ss1 + "";
                }
                else result = "-" + ss1 + "";
            }

            return result;

        }
    }
}