using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*#region Смещение в listbox
        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(listBox1.Items[e.Index].ToString(), listBox1.Font, listBox1.Width).Height;
        }

        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }
        #endregion Смещение в listbox*/

        int count = 0, cl = 0;
        bool znak = true, YT = false;
        string s1, s2, r;

        private void calculate()//функции расчета чисел
        {
            switch (count)
            {
                case 0:
                    break;
                case 1://сумма
                    s2 = textBox1.Text;
                    r = Func.Summa(s1, s2);
                    textBox1.Clear();
                    listBox1.Items.RemoveAt(cl);
                    listBox1.Items.Insert(cl,s1 +"+"+ s2 + "=" + r);
                    s1 = ""; s2 = ""; count = 0;
                    break;
                case 2://вычитание
                    s2 = textBox1.Text;
                    r = Func.Vuch(s1, s2);
                    textBox1.Clear();
                    listBox1.Items.RemoveAt(cl);
                    listBox1.Items.Insert(cl, s1 + "-" + s2 + "=" + r);
                    s1 = ""; s2 = ""; count = 0;
                    break;
                case 3://умножение
                    s2 = textBox1.Text;
                    r = Func.Umn(s1, s2);
                    textBox1.Clear();
                    listBox1.Items.RemoveAt(cl);
                    listBox1.Items.Insert(cl, s1 + "*" + s2 + "=" + r);
                    s1 = ""; s2 = ""; count = 0;
                    break;
                case 4://деление
                    s2 = textBox1.Text;
                    r = Func.Delenie(s1, s2);
                    textBox1.Clear();
                    listBox1.Items.RemoveAt(cl);
                    listBox1.Items.Insert(cl, s1 + "/" + s2 + "=" + r);
                    s1 = ""; s2 = ""; count = 0;
                    break;
                case 5://факториал
                    r = Func.Fact(s1);
                    textBox1.Clear();
                    listBox1.Items.RemoveAt(cl);
                    listBox1.Items.Insert(cl, s1 + "!" + "=" + r);
                    s1 = ""; s2 = ""; count = 0;
                    break;
                case 6://возведение в квадрат
                    r = Func.Vozv_kv(s1);
                    textBox1.Clear();
                    listBox1.Items.RemoveAt(cl);
                    listBox1.Items.Insert(cl, s1 + "²" + "=" + r);
                    s1 = ""; s2 = ""; count = 0;
                    break;
                case 7://возведение в n-ю степень
                    s2 = textBox1.Text;
                    r = Func.Vozv_n_stp(s1, s2);
                    textBox1.Clear();
                    listBox1.Items.RemoveAt(cl);
                    listBox1.Items.Insert(cl,"("+ s1 + "ⁿ" + " n=" + s2 + ") " +"=" + r);
                    s1 = ""; s2 = ""; count = 0;
                    break;
                case 8://нахождение логарифма
                    s2 = textBox1.Text;
                    r = Func.Logarifm(s1, s2);
                    textBox1.Clear();
                    listBox1.Items.RemoveAt(cl);
                    listBox1.Items.Insert(cl, "(logₙ(" + s1 + ") n=" + s2 + ") " + "=" + r);
                    s1 = ""; s2 = ""; count = 0;
                    break;
                case 9://нахождение натурального логарифма
                    r = Func.NLogarifm(s1);
                    textBox1.Clear();
                    listBox1.Items.RemoveAt(cl);
                    listBox1.Items.Insert(cl,"ln("+ s1 + ")=" + r);
                    s1 = ""; s2 = ""; count = 0;
                    break;
                /*case 10://нахождение квадратного корня
                    r = Func.Kv_koren(s1);
                    textBox1.Clear();
                    vvd.Text = r;
                    s1 = ""; s2 = ""; count = 0;
                    break;*/
            }
        }

        #region Кнопки меню
      

        private void button3_Click(object sender, EventArgs e)//выход
        {
            Close();
        }
        #endregion Кнопки меню

        #region Кнопки цифр, удаления и равно
        private void zero_Click(object sender, EventArgs e)//цифра ноль
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void one_Click(object sender, EventArgs e)//цифра один
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void two_Click(object sender, EventArgs e)//цифра два
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void three_Click(object sender, EventArgs e)//цифра три
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void four_Click(object sender, EventArgs e)//цифра четыре
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void five_Click(object sender, EventArgs e)//цифра пять
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void six_Click(object sender, EventArgs e)//цифра шесть
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void seven_Click(object sender, EventArgs e)//цифра семь
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void eight_Click(object sender, EventArgs e)//цифра восемь
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void nine_Click(object sender, EventArgs e)//цифра девять
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void reset_Click(object sender, EventArgs e)//очищение поля ввода
                {
                    textBox1.Clear();
                    listBox1.Items.Clear();
            s1 = ""; s2 = ""; count = 0;
            
  
                }

        private void ravno_Click(object sender, EventArgs e)/*вывод результата ИСПРАВИТЬ*/
        {
            if (textBox1.Text == "")
            {
                if (YT == true)
                {
                    calculate();
                }
            }
            else calculate();

         }
        
   
        private void zn_Click(object sender, EventArgs e)//изменения знака числа
                {
                    if (znak == true)
                    {
                        textBox1.Text = "-" + textBox1.Text;
                        znak = false;
                    }
                    else if (znak == false)
                    {
                        textBox1.Text = textBox1.Text.Replace("-", "");
                        znak = true;
                    }
                }

        private void clear_Click(object sender, EventArgs e)//удаляем последнию цифру
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }
        #endregion Кнопки цифр, удаления и равно

        #region Функции калькулятора
        private void plus_Click(object sender, EventArgs e)//функция плюса
        {
            if (textBox1.Text == "" || textBox1.Text == "-")
            {

            }
            else
            {
                s1 = textBox1.Text;
                count = 1;
                textBox1.Clear();
                listBox1.Items.Insert(cl, s1 + "+");
            }
            
        }

        private void minus_Click(object sender, EventArgs e)//функция минуса
        {
            if (textBox1.Text == "" || textBox1.Text == "-")
            {

            }
            else
            {
                s1 = textBox1.Text;
                count = 2;
                textBox1.Clear();
                listBox1.Items.Insert(cl, s1 + "-");
            }
            
        }

        private void umn_Click(object sender, EventArgs e)//функция умножения
        {
            if (textBox1.Text == "" || textBox1.Text == "-")
            {

            }
            else
            {
                s1 = textBox1.Text;
                count = 3;
                textBox1.Clear();
                listBox1.Items.Insert(cl, s1 + "*");
            }
            
        }

        private void delenie_Click(object sender, EventArgs e)//функция деления
        {
            if (textBox1.Text == "" || textBox1.Text == "-")
            {

            }
            else
            {
                s1 = textBox1.Text;
                count = 4;
                textBox1.Clear();
                listBox1.Items.Insert(cl, s1 + "/");
            }
            
        }

        private void kv_x_Click(object sender, EventArgs e)//фунция возведения в квадрат
        {

            if (textBox1.Text == "" || textBox1.Text == "-")
            {

            }
            else
            {
                YT = true;
                s1 = textBox1.Text;
                count = 6;
                textBox1.Clear();
                listBox1.Items.Insert(cl, s1 + "²");
            }
        }

        /*private void sqrtt_Click(object sender, EventArgs e)//функция квадратного корня
        {
            if (textBox1.Text == "" || textBox1.Text == "-")
            {

            }
            else
            {
                s1 = textBox1.Text;
                count = 10;
                textBox1.Clear();
                vvd.Text = "√" + s1;
            }
        }*/

        private void log_Click(object sender, EventArgs e)//функция логарифма
        {

            if (textBox1.Text == "" || textBox1.Text == "-")
            {

            }
            else
            {
                
                s1 = textBox1.Text;
                count = 8;
                textBox1.Clear();
                listBox1.Items.Insert(cl, "logₙ" + s1);
            }
        }

        private void ln_Click(object sender, EventArgs e)//функция натурального логарифма
        {
            if (textBox1.Text == "" || textBox1.Text == "-")
            {

            }
            else
            {
                YT = true;
                s1 = textBox1.Text;
                count = 9;
                textBox1.Clear();
                listBox1.Items.Insert(cl, "ln" + s1);
            }
        }

        private void n_x_Click(object sender, EventArgs e)//функция возведения в степень n
        {
            if (textBox1.Text == "" || textBox1.Text == "-")
            {

            }
            else
            {
                YT = true;
                s1 = textBox1.Text;
                count = 7;
                textBox1.Clear();
                listBox1.Items.Insert(cl, s1 + "ⁿ");
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void fact_Click(object sender, EventArgs e)
        {

            double proverka = double.Parse(textBox1.Text);
            if (textBox1.Text == "" || textBox1.Text == "-")
            {

            }
            else 
            {
                if (proverka <= 11984)
                {
                    YT = true;
                    s1 = textBox1.Text;
                    count = 5;
                    textBox1.Clear();
                    listBox1.Items.Insert(cl, s1 + "!");
                }
                else
                    listBox1.Text = "Ошибка! Введите число не превышающие 11984!";
            }
            
        }

        #endregion Функции калькулятора

        #region Настройки ввода в textbox
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//ДОРАБОТАТЬ
        {
            if (!Char.IsDigit(e.KeyChar) )
                e.Handled = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)//ввод с клавиатуры
        {
            if(e.KeyCode == Keys.Oemplus)//нажимается плюс с шифтом
            {
                plus.PerformClick();
            }

            if (e.KeyCode == Keys.OemMinus)//вычитание
            {
                minus.PerformClick();
            }
            if (e.KeyCode == Keys.Divide)//деление на нампаде
            {
                delenie.PerformClick();
            }
            if (e.KeyCode == Keys.Multiply)//умножение на нампаде
            {
                umn.PerformClick();
            }
            if (e.KeyCode == Keys.Subtract)//минус на нампаде
            {
                minus.PerformClick();
            }
            if (e.KeyCode == Keys.Add)//плюс на нампаде
            {
                plus.PerformClick();
            }
            if (e.KeyCode == Keys.Enter)//энтер
            {
                ravno.PerformClick();
            }
            if (e.KeyCode == Keys.Q)//очистка
            {
                reset.PerformClick();
            }
            if (e.KeyCode == Keys.Back)//бакспейс
            {
                clear.PerformClick();
            }
            if (e.KeyCode == Keys.H)//логарифм
            {
                log.PerformClick();
            }
            if (e.KeyCode == Keys.G)//натуральный логарифм
            {
                ln.PerformClick();
            }
            if (e.KeyCode == Keys.S)//возведение в квадрат
            {
                kv_x.PerformClick();
            }
            if (e.KeyCode == Keys.A)//возведение в n-ю степень
            {
                n_x.PerformClick();
            }
            if (e.KeyCode == Keys.F)//факториал
            {
                fact.PerformClick();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)//задаёт фокус текстбокса
        {
            textBox1.Focus();
        }

        #endregion Настройки ввода в textbox
    }
}
