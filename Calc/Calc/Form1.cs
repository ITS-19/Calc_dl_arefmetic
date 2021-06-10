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

        double a, b;
        int count = 0;
        bool znak = true;

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

        private void calculute()
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = textBox1 + "";
            }
            else
            {
                switch (count)
                {
                    case 0:
                        resultat.Text = "";
                        textBox1.Text = "";
                        break;
                    case 1:
                        b = a + double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        resultat.Text = "";
                        break;
                    case 2:
                        b = a - double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        resultat.Text = "";
                        break;
                    case 3:
                        b = a * double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        resultat.Text = "";
                        break;
                    case 4:
                        if (double.Parse(textBox1.Text) == 0)
                        {
                            resultat.Text = "Error";
                            textBox1.Text = "";
                        }
                        else
                        {
                            b = a / double.Parse(textBox1.Text);
                            textBox1.Text = b.ToString();
                            resultat.Text = "";
                        }
                        break;


                    default:
                        break;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)//главное меню
        {
            ActivateButton(sender);
        }

        private void button2_Click(object sender, EventArgs e)//настройки
        {
            ActivateButton(sender);
        }

        private void button3_Click(object sender, EventArgs e)//выход
        {
            ActivateButton(sender);
            Close();
        }
 


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

        private void plus_Click(object sender, EventArgs e)//функция плюса
        {
            ActivateButton(sender);
            if (textBox1.Text == "" || textBox1.Text == "-")
            {
                textBox1.Text = "";
            }
            else
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 1;
                resultat.Text = a.ToString() + "+";
                znak = true;
            }
        }

        private void minus_Click(object sender, EventArgs e)//функция минуса
        {
            ActivateButton(sender);
            if (textBox1.Text == "" || textBox1.Text == "-")
            {
                textBox1.Text = "";
            }
            else
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 2;
                resultat.Text = a.ToString() + "-";
                znak = true;
            }
        }

        private void umn_Click(object sender, EventArgs e)//функция умножения
        {
            ActivateButton(sender);
            if (textBox1.Text == "" || textBox1.Text == "-")
            {
                textBox1.Text = "";
            }
            else
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 3;
                resultat.Text = a.ToString() + "*";
                znak = true;
            }
        }

        private void delenie_Click(object sender, EventArgs e)//функция деления
        {
            ActivateButton(sender);
            if (textBox1.Text == "" || textBox1.Text == "-")
            {
                textBox1.Text = "";
            }
            else
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 4;
                resultat.Text = a.ToString() + "/";
                znak = true;
            }
        }

        private void ravno_Click(object sender, EventArgs e)//вывод результата
        {
            ActivateButton(sender);
            calculute();
            
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

        private void kv_x_Click(object sender, EventArgs e)//фунция возведения в квадрат
        {
            ActivateButton(sender);
            if (textBox1.Text == "" || textBox1.Text == "-")
            {
                textBox1.Text = "";
            }
            else
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                znak = true;
                b = a * a;
                resultat.Text = "";
                textBox1.Text = b.ToString();
            }
        }

        private void sqrtt_Click(object sender, EventArgs e)//функция квадратного корня
        {
            ActivateButton(sender);
            if (textBox1.Text == "" || textBox1.Text == "-")
            {
                textBox1.Text = "";
            }
            else
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 5;
                resultat.Text = "√(" + a.ToString() + ")";
                if (znak == false)
                {
                    resultat.Text = "Error";
                    textBox1.Text = "";
                    znak = true;
                }
                else
                {
                    b = Math.Sqrt(a);
                    resultat.Text = "";
                    textBox1.Text = b.ToString();
                    znak = true;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void log_Click(object sender, EventArgs e)//функция логарифма
        {
            ActivateButton(sender);
        }

        private void ln_Click(object sender, EventArgs e)//функция натурального логарифма
        {
            ActivateButton(sender);
        }

        private void n_x_Click(object sender, EventArgs e)//функция возведения в степень n
        {
            ActivateButton(sender);
        }

        private void n_sqrt_Click(object sender, EventArgs e)//функция извлечения корня n-ой степени
        {
            ActivateButton(sender);
        }

        private void reset_Click(object sender, EventArgs e)//очищение поля ввода
        {
            ActivateButton(sender);
            textBox1.Clear();
            resultat.Text = "";
            
  
        }
    }
}
