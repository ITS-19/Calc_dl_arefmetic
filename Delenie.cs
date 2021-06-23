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
        public static string Delenie(string st1, string st2)//деление
        {
            if (st1.Length <= 15 && st2.Length <= 15)
            {
                double s1_1 = double.Parse(st1);
                double s1_2 = double.Parse(st2);
                string result2 = (s1_1 / s1_2) + "";
                return result2;
            }
            else
            {
                ExtendedNumerics.BigRational s1 = ExtendedNumerics.BigRational.Parse(st1);
                ExtendedNumerics.BigRational s2 = ExtendedNumerics.BigRational.Parse(st2);
                string result;
                ExtendedNumerics.BigRational u;
                u = s1 / s2;
                result = u + "";

                return result;
            }
        }

}
