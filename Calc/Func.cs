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
        public static string Summa(string st1, string st2)//сложение
        {
            BigInteger s1 = BigInteger.Parse(st1);
            BigInteger s2 = BigInteger.Parse(st2);
            BigInteger r = s1 + s2;
            string result = r + "";
            return result;
        }
        public static string Vuch(string st1, string st2)//вычитание
        {
            BigInteger s1 = BigInteger.Parse(st1);
            BigInteger s2 = BigInteger.Parse(st2);
            BigInteger r = s1 - s2;
            string result = r + "";
            return result;
        }
        public static string Umn(string st1, string st2)//умножение
        {

            BigInteger s1 = BigInteger.Parse(st1);
            BigInteger s2 = BigInteger.Parse(st2);
            BigInteger r = s1 * s2;
            string result = r + "";
            return result;
        }
        public static string Delenie(string st1, string st2)//деление
        {
            if (st1.Length <= 15 && st2.Length <= 15)
            {
                string result2;
                double s1_1 = double.Parse(st1);
                double s1_2 = double.Parse(st2);
                if (s1_2 != 0)
                    result2 = (s1_1 / s1_2) + "";
                else
                    result2 = "Ошибка! Вы поделили на ноль!";
                return result2;
            }
            else
            {
                ExtendedNumerics.BigRational s1 = ExtendedNumerics.BigRational.Parse(st1);
                ExtendedNumerics.BigRational s2 = ExtendedNumerics.BigRational.Parse(st2);
                string result;
                ExtendedNumerics.BigRational u, o = ExtendedNumerics.BigRational.Parse("0");
                if (s2 != o)
                {
                    u = s1 / s2;
                    result = u + "";
                }
                else result = "Ошибка! Вы поделили на 0!";
                return result;
            }
        }
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
        public static string Vozv_kv(string st1)//возведение в квадрат
        {
            BigInteger s1 = BigInteger.Parse(st1);
            BigInteger p;
            p = s1 * s1;
            string result = p + "";
            return result;
        }
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
            else if(s1 < 0 && s2 >= 0)
            {
                s1 *= -1;
                BigInteger u = BigInteger.Pow(s1, s2);
                if (s2 % 2 == 0) result = u + "";
                else
                {
                    u *= -1; result = u + "";
                }
            }
            else if(s1 > 0 && s2 < 0)
            {
                s2 *= -1;
                BigInteger u = BigInteger.Pow(s1, s2);
                string rat = u + "", rat1 = 1 + "";
                ExtendedNumerics.BigRational ss = ExtendedNumerics.BigRational.Parse(rat);
                ExtendedNumerics.BigRational sd = ExtendedNumerics.BigRational.Parse(rat1);
                ExtendedNumerics.BigRational ss1 = sd / ss;
                result = ss1 + "";
            }
            else if(s1 < 0 && s2 < 0)
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
