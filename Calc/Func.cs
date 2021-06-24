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

            string result = Su.Summ(st1, st2);
            return result;
        }
        public static string Vuch(string st1, string st2)//вычитание
        {
            
            string result = Vuc.Vuch(st1, st2);
            return result;
        }
        public static string Umn(string st1, string st2)//умножение
        {
            
            string result = Um.Umn(st1, st2);
            return result;
        }
        public static string Delenie(string st1, string st2)//деление
        {
            string result = Del.Delenie(st1, st2);
            return result;
        }
        public static string Fact(string st1)//нахождение факториала
        {
            string result = F.Fact(st1);
            return result;
        }
        public static string Vozv_kv(string st1)//возведение в квадрат
        {
            
            string result = VozKv.Vozv_kv(st1);
            return result;
        }
        public static string Vozv_n_stp(string st1, string st2)//возведения в n-ю степень
        {
            string result = VozN.Vozv_n_stp(st1, st2);
            return result;
        }
        public static string Logarifm(string st1, string st2)//логарифм числа
        {
            string result = Log34.Logarifm(st1, st2);
            return result;
        }
        public static string NLogarifm(string st1)//натуральный логарифм 
        {
            string result = Ln.NLogarifm(st1);
            return result;
        }
        
    }

}
