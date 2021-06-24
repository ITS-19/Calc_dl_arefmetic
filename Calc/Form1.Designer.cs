namespace Calc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.one = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.ravno = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.kv_x = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.n_x = new System.Windows.Forms.Button();
            this.umn = new System.Windows.Forms.Button();
            this.delenie = new System.Windows.Forms.Button();
            this.zn = new System.Windows.Forms.Button();
            this.fact = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(166, 482);
            this.panelMenu.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(74)))), ((int)(((byte)(76)))));
            this.panelLogo.BackgroundImage = global::Calc.Properties.Resources.Screenshot_1;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(166, 85);
            this.panelLogo.TabIndex = 0;
            // 
            // one
            // 
            this.one.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.one.BackColor = System.Drawing.Color.WhiteSmoke;
            this.one.Cursor = System.Windows.Forms.Cursors.Hand;
            this.one.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.one.Location = new System.Drawing.Point(179, 361);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(60, 60);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // three
            // 
            this.three.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.three.BackColor = System.Drawing.Color.WhiteSmoke;
            this.three.Cursor = System.Windows.Forms.Cursors.Hand;
            this.three.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.three.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.three.Location = new System.Drawing.Point(299, 361);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(60, 60);
            this.three.TabIndex = 2;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.two.BackColor = System.Drawing.Color.WhiteSmoke;
            this.two.Cursor = System.Windows.Forms.Cursors.Hand;
            this.two.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.two.Location = new System.Drawing.Point(239, 361);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(60, 60);
            this.two.TabIndex = 3;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // zero
            // 
            this.zero.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.zero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.zero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zero.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.zero.Location = new System.Drawing.Point(179, 421);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(180, 60);
            this.zero.TabIndex = 4;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // four
            // 
            this.four.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.four.BackColor = System.Drawing.Color.WhiteSmoke;
            this.four.Cursor = System.Windows.Forms.Cursors.Hand;
            this.four.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.four.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.four.Location = new System.Drawing.Point(179, 301);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(60, 60);
            this.four.TabIndex = 5;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.five.BackColor = System.Drawing.Color.WhiteSmoke;
            this.five.Cursor = System.Windows.Forms.Cursors.Hand;
            this.five.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.five.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.five.Location = new System.Drawing.Point(239, 301);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(60, 60);
            this.five.TabIndex = 6;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.six.BackColor = System.Drawing.Color.WhiteSmoke;
            this.six.Cursor = System.Windows.Forms.Cursors.Hand;
            this.six.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.six.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.six.Location = new System.Drawing.Point(299, 301);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(60, 60);
            this.six.TabIndex = 7;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.seven.BackColor = System.Drawing.Color.WhiteSmoke;
            this.seven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seven.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seven.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.seven.Location = new System.Drawing.Point(179, 241);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(60, 60);
            this.seven.TabIndex = 8;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.eight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eight.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.eight.Location = new System.Drawing.Point(239, 241);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(60, 60);
            this.eight.TabIndex = 9;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nine.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.nine.Location = new System.Drawing.Point(299, 241);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(60, 60);
            this.nine.TabIndex = 10;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // ravno
            // 
            this.ravno.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ravno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ravno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ravno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ravno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ravno.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ravno.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ravno.Location = new System.Drawing.Point(359, 361);
            this.ravno.Name = "ravno";
            this.ravno.Size = new System.Drawing.Size(60, 120);
            this.ravno.TabIndex = 11;
            this.ravno.Text = "=";
            this.ravno.UseVisualStyleBackColor = false;
            this.ravno.Click += new System.EventHandler(this.ravno_Click);
            // 
            // minus
            // 
            this.minus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.minus.Location = new System.Drawing.Point(359, 241);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(60, 60);
            this.minus.TabIndex = 12;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.plus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.plus.Location = new System.Drawing.Point(359, 301);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(60, 60);
            this.plus.TabIndex = 14;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Cornsilk;
            this.textBox1.Location = new System.Drawing.Point(-1, 137);
            this.textBox1.MaxLength = 100000;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(420, 104);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // clear
            // 
            this.clear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.clear.Location = new System.Drawing.Point(59, 241);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(60, 60);
            this.clear.TabIndex = 18;
            this.clear.Text = "<-";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // reset
            // 
            this.reset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.reset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reset.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.reset.Location = new System.Drawing.Point(119, 241);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(60, 60);
            this.reset.TabIndex = 19;
            this.reset.Text = "C";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // log
            // 
            this.log.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.log.BackColor = System.Drawing.Color.WhiteSmoke;
            this.log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.log.Location = new System.Drawing.Point(-1, 301);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(60, 120);
            this.log.TabIndex = 21;
            this.log.Text = "log";
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // kv_x
            // 
            this.kv_x.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kv_x.BackColor = System.Drawing.Color.WhiteSmoke;
            this.kv_x.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kv_x.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.kv_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kv_x.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kv_x.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.kv_x.Location = new System.Drawing.Point(59, 301);
            this.kv_x.Name = "kv_x";
            this.kv_x.Size = new System.Drawing.Size(60, 60);
            this.kv_x.TabIndex = 22;
            this.kv_x.Text = "x²";
            this.kv_x.UseVisualStyleBackColor = false;
            this.kv_x.Click += new System.EventHandler(this.kv_x_Click);
            // 
            // ln
            // 
            this.ln.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ln.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ln.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ln.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ln.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ln.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ln.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ln.Location = new System.Drawing.Point(119, 421);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(60, 60);
            this.ln.TabIndex = 24;
            this.ln.Text = "ln";
            this.ln.UseVisualStyleBackColor = false;
            this.ln.Click += new System.EventHandler(this.ln_Click);
            // 
            // n_x
            // 
            this.n_x.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.n_x.BackColor = System.Drawing.Color.WhiteSmoke;
            this.n_x.Cursor = System.Windows.Forms.Cursors.Hand;
            this.n_x.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.n_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n_x.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n_x.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.n_x.Location = new System.Drawing.Point(-1, 421);
            this.n_x.Name = "n_x";
            this.n_x.Size = new System.Drawing.Size(120, 60);
            this.n_x.TabIndex = 25;
            this.n_x.Text = "xⁿ";
            this.n_x.UseVisualStyleBackColor = false;
            this.n_x.Click += new System.EventHandler(this.n_x_Click);
            // 
            // umn
            // 
            this.umn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.umn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.umn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.umn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.umn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.umn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.umn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.umn.Location = new System.Drawing.Point(119, 301);
            this.umn.Name = "umn";
            this.umn.Size = new System.Drawing.Size(60, 60);
            this.umn.TabIndex = 27;
            this.umn.Text = "*";
            this.umn.UseVisualStyleBackColor = false;
            this.umn.Click += new System.EventHandler(this.umn_Click);
            // 
            // delenie
            // 
            this.delenie.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.delenie.BackColor = System.Drawing.Color.WhiteSmoke;
            this.delenie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delenie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delenie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delenie.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delenie.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.delenie.Location = new System.Drawing.Point(119, 361);
            this.delenie.Name = "delenie";
            this.delenie.Size = new System.Drawing.Size(60, 60);
            this.delenie.TabIndex = 28;
            this.delenie.Text = "/";
            this.delenie.UseVisualStyleBackColor = false;
            this.delenie.Click += new System.EventHandler(this.delenie_Click);
            // 
            // zn
            // 
            this.zn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.zn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.zn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.zn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.zn.Location = new System.Drawing.Point(-1, 241);
            this.zn.Name = "zn";
            this.zn.Size = new System.Drawing.Size(60, 60);
            this.zn.TabIndex = 29;
            this.zn.Text = "+/-";
            this.zn.UseVisualStyleBackColor = false;
            this.zn.Click += new System.EventHandler(this.zn_Click);
            // 
            // fact
            // 
            this.fact.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fact.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fact.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.fact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fact.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fact.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.fact.Location = new System.Drawing.Point(59, 361);
            this.fact.Name = "fact";
            this.fact.Size = new System.Drawing.Size(60, 60);
            this.fact.TabIndex = 30;
            this.fact.Text = "x!";
            this.fact.UseVisualStyleBackColor = false;
            this.fact.Click += new System.EventHandler(this.fact_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.listBox1);
            this.panelChildForm.Controls.Add(this.textBox1);
            this.panelChildForm.Controls.Add(this.fact);
            this.panelChildForm.Controls.Add(this.one);
            this.panelChildForm.Controls.Add(this.three);
            this.panelChildForm.Controls.Add(this.zn);
            this.panelChildForm.Controls.Add(this.two);
            this.panelChildForm.Controls.Add(this.delenie);
            this.panelChildForm.Controls.Add(this.zero);
            this.panelChildForm.Controls.Add(this.umn);
            this.panelChildForm.Controls.Add(this.four);
            this.panelChildForm.Controls.Add(this.n_x);
            this.panelChildForm.Controls.Add(this.five);
            this.panelChildForm.Controls.Add(this.ln);
            this.panelChildForm.Controls.Add(this.six);
            this.panelChildForm.Controls.Add(this.kv_x);
            this.panelChildForm.Controls.Add(this.seven);
            this.panelChildForm.Controls.Add(this.log);
            this.panelChildForm.Controls.Add(this.eight);
            this.panelChildForm.Controls.Add(this.nine);
            this.panelChildForm.Controls.Add(this.reset);
            this.panelChildForm.Controls.Add(this.ravno);
            this.panelChildForm.Controls.Add(this.clear);
            this.panelChildForm.Controls.Add(this.minus);
            this.panelChildForm.Controls.Add(this.plus);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(166, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(418, 482);
            this.panelChildForm.TabIndex = 31;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(55)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(418, 138);
            this.listBox1.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(584, 482);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panelMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button ravno;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button kv_x;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button n_x;
        private System.Windows.Forms.Button umn;
        private System.Windows.Forms.Button delenie;
        private System.Windows.Forms.Button zn;
        private System.Windows.Forms.Button fact;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.ListBox listBox1;
    }
}

