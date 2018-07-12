namespace Strygevalecalculator2000
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.substraction = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.arccos = new System.Windows.Forms.Button();
            this.arcctg = new System.Windows.Forms.Button();
            this.ctg = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.average = new System.Windows.Forms.Button();
            this.remain = new System.Windows.Forms.Button();
            this.xinreversey = new System.Windows.Forms.Button();
            this.arcsin = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.xiny = new System.Windows.Forms.Button();
            this.arctan = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(402, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(483, 152);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 23);
            this.multiply.TabIndex = 3;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.ClickTwo);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(483, 180);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 23);
            this.divide.TabIndex = 4;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.ClickTwo);
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(483, 94);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(75, 23);
            this.addition.TabIndex = 5;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.ClickTwo);
            // 
            // substraction
            // 
            this.substraction.Location = new System.Drawing.Point(483, 123);
            this.substraction.Name = "substraction";
            this.substraction.Size = new System.Drawing.Size(75, 23);
            this.substraction.TabIndex = 6;
            this.substraction.Text = "-";
            this.substraction.UseVisualStyleBackColor = true;
            this.substraction.Click += new System.EventHandler(this.ClickTwo);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(174, 234);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(222, 20);
            this.textBox3.TabIndex = 7;
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(12, 94);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 8;
            this.sin.Text = "Sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.ClickOne);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(12, 123);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 9;
            this.cos.Text = "Cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.ClickOne);
            // 
            // arccos
            // 
            this.arccos.Location = new System.Drawing.Point(93, 123);
            this.arccos.Name = "arccos";
            this.arccos.Size = new System.Drawing.Size(75, 23);
            this.arccos.TabIndex = 10;
            this.arccos.Text = "Arccos";
            this.arccos.UseVisualStyleBackColor = true;
            this.arccos.Click += new System.EventHandler(this.ClickOne);
            // 
            // arcctg
            // 
            this.arcctg.Location = new System.Drawing.Point(93, 179);
            this.arcctg.Name = "arcctg";
            this.arcctg.Size = new System.Drawing.Size(75, 23);
            this.arcctg.TabIndex = 11;
            this.arcctg.Text = "Arcctg";
            this.arcctg.UseVisualStyleBackColor = true;
            this.arcctg.Click += new System.EventHandler(this.ClickOne);
            // 
            // ctg
            // 
            this.ctg.Location = new System.Drawing.Point(12, 179);
            this.ctg.Name = "ctg";
            this.ctg.Size = new System.Drawing.Size(75, 23);
            this.ctg.TabIndex = 12;
            this.ctg.Text = "Ctg";
            this.ctg.UseVisualStyleBackColor = true;
            this.ctg.Click += new System.EventHandler(this.ClickOne);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(174, 151);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(75, 23);
            this.ln.TabIndex = 13;
            this.ln.Text = "Logarithm";
            this.ln.UseVisualStyleBackColor = true;
            this.ln.Click += new System.EventHandler(this.ClickOne);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(174, 94);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(75, 23);
            this.x2.TabIndex = 14;
            this.x2.Text = "Xin2";
            this.x2.UseVisualStyleBackColor = true;
            this.x2.Click += new System.EventHandler(this.ClickOne);
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(402, 152);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(75, 23);
            this.average.TabIndex = 15;
            this.average.Text = "Average";
            this.average.UseVisualStyleBackColor = true;
            this.average.Click += new System.EventHandler(this.ClickTwo);
            // 
            // remain
            // 
            this.remain.Location = new System.Drawing.Point(321, 152);
            this.remain.Name = "remain";
            this.remain.Size = new System.Drawing.Size(75, 23);
            this.remain.TabIndex = 16;
            this.remain.Text = "Remain";
            this.remain.UseVisualStyleBackColor = true;
            this.remain.Click += new System.EventHandler(this.ClickTwo);
            // 
            // xinreversey
            // 
            this.xinreversey.Location = new System.Drawing.Point(321, 122);
            this.xinreversey.Name = "xinreversey";
            this.xinreversey.Size = new System.Drawing.Size(75, 23);
            this.xinreversey.TabIndex = 17;
            this.xinreversey.Text = "XinReverseY";
            this.xinreversey.UseVisualStyleBackColor = true;
            this.xinreversey.Click += new System.EventHandler(this.ClickTwo);
            // 
            // arcsin
            // 
            this.arcsin.Location = new System.Drawing.Point(93, 94);
            this.arcsin.Name = "arcsin";
            this.arcsin.Size = new System.Drawing.Size(75, 23);
            this.arcsin.TabIndex = 18;
            this.arcsin.Text = "Arcsin";
            this.arcsin.UseVisualStyleBackColor = true;
            this.arcsin.Click += new System.EventHandler(this.ClickOne);
            // 
            // root
            // 
            this.root.Location = new System.Drawing.Point(174, 122);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(75, 23);
            this.root.TabIndex = 19;
            this.root.Text = "Sqrtroot";
            this.root.UseVisualStyleBackColor = true;
            this.root.Click += new System.EventHandler(this.ClickOne);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(402, 122);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(75, 23);
            this.max.TabIndex = 20;
            this.max.Text = "Max";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.ClickTwo);
            // 
            // xiny
            // 
            this.xiny.Location = new System.Drawing.Point(321, 94);
            this.xiny.Name = "xiny";
            this.xiny.Size = new System.Drawing.Size(75, 23);
            this.xiny.TabIndex = 21;
            this.xiny.Text = "XinY";
            this.xiny.UseVisualStyleBackColor = true;
            this.xiny.Click += new System.EventHandler(this.ClickTwo);
            // 
            // arctan
            // 
            this.arctan.Location = new System.Drawing.Point(93, 151);
            this.arctan.Name = "arctan";
            this.arctan.Size = new System.Drawing.Size(75, 23);
            this.arctan.TabIndex = 22;
            this.arctan.Text = "Arctan";
            this.arctan.UseVisualStyleBackColor = true;
            this.arctan.Click += new System.EventHandler(this.ClickOne);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(12, 151);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 23);
            this.tan.TabIndex = 23;
            this.tan.Text = "Tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.ClickOne);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(402, 94);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(75, 23);
            this.min.TabIndex = 24;
            this.min.Text = "Min";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.ClickTwo);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 284);
            this.Controls.Add(this.min);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.arctan);
            this.Controls.Add(this.xiny);
            this.Controls.Add(this.max);
            this.Controls.Add(this.root);
            this.Controls.Add(this.arcsin);
            this.Controls.Add(this.xinreversey);
            this.Controls.Add(this.remain);
            this.Controls.Add(this.average);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.ctg);
            this.Controls.Add(this.arcctg);
            this.Controls.Add(this.arccos);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.substraction);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button substraction;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button arccos;
        private System.Windows.Forms.Button arcctg;
        private System.Windows.Forms.Button ctg;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button average;
        private System.Windows.Forms.Button remain;
        private System.Windows.Forms.Button xinreversey;
        private System.Windows.Forms.Button arcsin;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button xiny;
        private System.Windows.Forms.Button arctan;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button min;
    }
}

