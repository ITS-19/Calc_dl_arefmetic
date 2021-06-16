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
        private Button currentButton;
        private Random random;
        private int tempIndex;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        int count = 0;
        bool znak = true;
        string s1, s2, r;

        #region Theme color
        private Color SelectThemeColor()//функция отвечающая за смену цвета кнопок в меню
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                }
            }
        }

        private void DisableButton()//функция отвечающая за смену цвета кнопок меню
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
#endregion Theme color

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
                    textBox2.Text = r;
                    s1 = ""; s2 = ""; count = 0;
                    break;
                case 2://вычитание
                    s2 = textBox1.Text;
                    r = Func.Vuch(s1, s2);
                    textBox1.Clear();
                    textBox2.Text = r;
                    s1 = ""; s2 = ""; count = 0;
                    break;
                case 3://умножение
                    s2 = textBox1.Text;
                    r = Func.Umn(s1, s2);
                    textBox1.Clear();
                    textBox2.Text = r;
                    s1 = ""; s2 = ""; count = 0;
                    break;
                case 4://деление
                    s2 = textBox1.Text;
                    r = Func.Delenie(s1, s2);
                    textBox1.Clear();
                    textBox2.Text = r;
                    s1 = ""; s2 = ""; count = 0;
                    break;
                case 5://факториал
                    r = Func.Fact(s1);
                    textBox1.Clear();
                    textBox2.Text = r;
                    s1 = ""; s2 = ""; count = 0;
                    break;
                case 6://возведение в квадрат
                    r = Func.Vozv_kv(s1);
                    textBox1.Clear();
                    textBox2.Text = r;
                    s1 = ""; s2 = ""; count = 0;
                    break;
                case 7://возведение в n-ю степень
                    s2 = textBox1.Text;
                    r = Func.Vozv_n_stp(s1, s2);
                    textBox1.Clear();
                    textBox2.Text = r;
                    s1 = ""; s2 = ""; count = 0;
                    break;
                case 8://нахождение логарифма
                    s2 = textBox1.Text;
                    r = Func.Logarifm(s1, s2);
                    textBox1.Clear();
                    textBox2.Text = r;
                    s1 = ""; s2 = ""; count = 0;
                    break;
                case 9://нахождение натурального логарифма
                    r = Func.NLogarifm(s1);
                    textBox1.Clear();
                    textBox2.Text = r;
                    s1 = ""; s2 = ""; count = 0;
                    break;
                case 10://нахождение квадратного корня
                    r = Func.Kv_koren(s1);
                    textBox1.Clear();
                    textBox2.Text = r;
                    s1 = ""; s2 = ""; count = 0;
                    break;
            }
        }

        #region Button menu
      

        private void button2_Click(object sender, EventArgs e)//настройки
        {
            ActivateButton(sender);
            openChildFormInPanel(new Setting());
        }

        private void button3_Click(object sender, EventArgs e)//выход
        {
            ActivateButton(sender);
            Close();
        }
        #endregion Button menu

        #region Button number and dr
        private void zero_Click(object sender, EventArgs e)//цифра ноль
        {
            ActivateButton(sender);
            textBox1.Text = textBox1.Text + 0;
        }

        private void one_Click(object sender, EventArgs e)//цифра один
        {
            ActivateButton(sender);
            textBox1.Text = textBox1.Text + 1;
        }

        private void two_Click(object sender, EventArgs e)//цифра два
        {
            ActivateButton(sender);
            textBox1.Text = textBox1.Text + 2;
        }

        private void three_Click(object sender, EventArgs e)//цифра три
        {
            ActivateButton(sender);
            textBox1.Text = textBox1.Text + 3;
        }

        private void four_Click(object sender, EventArgs e)//цифра четыре
        {
            ActivateButton(sender);
            textBox1.Text = textBox1.Text + 4;
        }

        private void five_Click(object sender, EventArgs e)//цифра пять
        {
            ActivateButton(sender);
            textBox1.Text = textBox1.Text + 5;
        }

        private void six_Click(object sender, EventArgs e)//цифра шесть
        {
            ActivateButton(sender);
            textBox1.Text = textBox1.Text + 6;
        }

        private void seven_Click(object sender, EventArgs e)//цифра семь
        {
            ActivateButton(sender);
            textBox1.Text = textBox1.Text + 7;
        }

        private void eight_Click(object sender, EventArgs e)//цифра восемь
        {
            ActivateButton(sender);
            textBox1.Text = textBox1.Text + 8;
        }

        private void nine_Click(object sender, EventArgs e)//цифра девять
        {
            ActivateButton(sender);
            textBox1.Text = textBox1.Text + 9;
        }

        private void zapyataya_Click(object sender, EventArgs e)//запятая
        {
            ActivateButton(sender);
            if (textBox1.Text.ToLower().Contains(','))
            {
                textBox1.Text = textBox1.Text + "";
            }
            else
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void reset_Click(object sender, EventArgs e)//очищение поля ввода
                {
                    ActivateButton(sender);
                    textBox1.Clear();
                    textBox2.Text = "";
            
  
                }

        private void ravno_Click(object sender, EventArgs e)//вывод результата ИСПРАВИТЬ
                     {
                           ActivateButton(sender);
                           calculate();
                            
            
                      }
   
        private void zn_Click(object sender, EventArgs e)//изменения знака числа
                {
                    ActivateButton(sender);
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
            ActivateButton(sender);
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }
        #endregion Button number

        #region Function calculate
        private void plus_Click(object sender, EventArgs e)//функция плюса
        {
            ActivateButton(sender);
            if (textBox1.Text == "" || textBox1.Text == "-")
            {

            }
            else
            {
                s1 = textBox1.Text;
                count = 1;
                textBox1.Clear();
                textBox2.Text = s1 + "+";
            }
            
        }

        private void minus_Click(object sender, EventArgs e)//функция минуса
        {
            ActivateButton(sender);
            if (textBox1.Text == "" || textBox1.Text == "-")
            {

            }
            else
            {
                s1 = textBox1.Text;
                count = 2;
                textBox1.Clear();
                textBox2.Text = s1 + "-";
            }
            
        }

        private void umn_Click(object sender, EventArgs e)//функция умножения
        {
            ActivateButton(sender);
            if (textBox1.Text == "" || textBox1.Text == "-")
            {

            }
            else
            {
                s1 = textBox1.Text;
                count = 3;
                textBox1.Clear();
                textBox2.Text = s1 + "*";
            }
            
        }

        private void delenie_Click(object sender, EventArgs e)//функция деления
        {
            ActivateButton(sender);
            if (textBox1.Text == "" || textBox1.Text == "-")
            {

            }
            else
            {
                s1 = textBox1.Text;
                count = 4;
                textBox1.Clear();
                textBox2.Text = s1 + "/";
            }
            
        }

        private void kv_x_Click(object sender, EventArgs e)//фунция возведения в квадрат
        {
            ActivateButton(sender);
            if (textBox1.Text == "" || textBox1.Text == "-")
            {

            }
            else
            {
                s1 = textBox1.Text;
                count = 6;
                textBox1.Clear();
                textBox2.Text = s1 + "²";
            }
        }

        private void sqrtt_Click(object sender, EventArgs e)//функция квадратного корня
        {
            ActivateButton(sender);
            if (textBox1.Text == "" || textBox1.Text == "-")
            {

            }
            else
            {
                s1 = textBox1.Text;
                count = 10;
                textBox1.Clear();
                textBox2.Text = "√" + s1;
            }
        }

        private void log_Click(object sender, EventArgs e)//функция логарифма
        {
            ActivateButton(sender);
            if (textBox1.Text == "" || textBox1.Text == "-")
            {

            }
            else
            {
                s1 = textBox1.Text;
                count = 8;
                textBox1.Clear();
                textBox2.Text = "logₙ" + s1;
            }
        }

        private void ln_Click(object sender, EventArgs e)//функция натурального логарифма
        {
            ActivateButton(sender);
            if (textBox1.Text == "" || textBox1.Text == "-")
            {

            }
            else
            {
                s1 = textBox1.Text;
                count = 9;
                textBox1.Clear();
                textBox2.Text = "ln" + s1;
            }
        }

        private void n_x_Click(object sender, EventArgs e)//функция возведения в степень n
        {
            ActivateButton(sender);
            if (textBox1.Text == "" || textBox1.Text == "-")
            {

            }
            else
            {
                s1 = textBox1.Text;
                count = 7;
                textBox1.Clear();
                textBox2.Text = s1 + "ⁿ";
            }
        }

        private void fact_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            s1 = textBox1.Text;
            count = 5;
            textBox1.Clear();
            textBox2.Text = s1 + "!";
        }
        #endregion Function calculate
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
                {
                    /*char ch = e.KeyChar;
                    if (!Char.IsDigit(ch))
                    {
                        e.Handled = true;
                    }*/
                }

        

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        }
    }
