using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using static ExtendedNumerics.BigRational;




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
            ExtendedNumerics.BigRational s4 = ExtendedNumerics.BigRational.Parse(st1);
            ExtendedNumerics.BigRational s5 = ExtendedNumerics.BigRational.Parse(st2);
            BigInteger s1 = BigInteger.Parse(st1);
            BigInteger s2 = BigInteger.Parse(st2);
            BigInteger r = s1 * s2;
            ExtendedNumerics.BigRational re = s4 * s5;
            string result = re + "";
            return result;
        }
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
        public static string Fact(string st1)//нахождение факториала
        {
            BigInteger s1 = BigInteger.Parse(st1);
            BigInteger p;
            p = 1;
            for (int i = 1; i < s1; i++)
            {
                p += p * i;
            }
            string result = p + "";
            return result;
        }
        public static string Vozv_kv(string st1)//возведение в квадрат
        {
            BigInteger s1 = BigInteger.Parse(st1);
            BigInteger p;
            p = s1*s1;
            string result = p + "";
            return result;
        }
        public static string Vozv_n_stp(string st1, string st2)//возведения в n-ю степень
        {
            BigInteger s1 = BigInteger.Parse(st1);
            int s2 = int.Parse(st2);
            BigInteger u = BigInteger.Pow(s1, s2);
            string result = u + "";
            return result;
        }
        public static string Logarifm(string st1, string st2)//логарифм числа
        {
            BigInteger s1 = BigInteger.Parse(st1);
            double s2 = double.Parse(st2);
            double u= BigInteger.Log(s1, s2);
            string result = u + "";
            return result;
        }
        public static string NLogarifm(string st1)//натуральный логарифм 
        {
            BigInteger s1 = BigInteger.Parse(st1);
            double u = BigInteger.Log(s1);
            string result = u + "";
            return result;
        }
        public static string Kv_koren(string st1)//квадратный корень(ДОРАБОТАТЬ)
        {
            System.Numerics.BigInteger N = System.Numerics.BigInteger.Parse(st1);
            BigInteger rootN = N;
            int bitLength = 1; 
            while (rootN / 2 != 0)
            {
                rootN /= 2;
                bitLength++;
            }
            bitLength = (bitLength + 1) / 2;
            rootN = N >> bitLength;

            BigInteger lastRoot = BigInteger.Zero;
            do
            {
                lastRoot = rootN;
                rootN = (BigInteger.Divide(N, rootN) + rootN) >> 1;
            }
            while (!((rootN ^ lastRoot).ToString() == "0"));
            string rootN1 = rootN + "";
            return rootN1;
        }
    }
}
