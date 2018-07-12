namespace Calculator
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
            this.textBoxFirstIn = new System.Windows.Forms.TextBox();
            this.textBoxSecondIn = new System.Windows.Forms.TextBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.arcsin = new System.Windows.Forms.Button();
            this.arccos = new System.Windows.Forms.Button();
            this.arctan = new System.Windows.Forms.Button();
            this.arcctg = new System.Windows.Forms.Button();
            this.ctg = new System.Windows.Forms.Button();
            this.xiny = new System.Windows.Forms.Button();
            this.xinreversey = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.average = new System.Windows.Forms.Button();
            this.remain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFirstIn
            // 
            this.textBoxFirstIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstIn.Location = new System.Drawing.Point(90, 21);
            this.textBoxFirstIn.Name = "textBoxFirstIn";
            this.textBoxFirstIn.Size = new System.Drawing.Size(190, 20);
            this.textBoxFirstIn.TabIndex = 0;
            // 
            // textBoxSecondIn
            // 
            this.textBoxSecondIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSecondIn.Location = new System.Drawing.Point(90, 59);
            this.textBoxSecondIn.Name = "textBoxSecondIn";
            this.textBoxSecondIn.Size = new System.Drawing.Size(190, 20);
            this.textBoxSecondIn.TabIndex = 1;
            // 
            // textBoxOut
            // 
            this.textBoxOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOut.Location = new System.Drawing.Point(90, 99);
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.Size = new System.Drawing.Size(190, 20);
            this.textBoxOut.TabIndex = 2;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(1, 143);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(48, 47);
            this.sum.TabIndex = 3;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(55, 143);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(47, 47);
            this.minus.TabIndex = 4;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(109, 143);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(48, 47);
            this.multiply.TabIndex = 5;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(163, 143);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(47, 47);
            this.division.TabIndex = 6;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // root
            // 
            this.root.Location = new System.Drawing.Point(110, 249);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(47, 47);
            this.root.TabIndex = 7;
            this.root.Text = "Sqrt";
            this.root.UseVisualStyleBackColor = true;
            this.root.Click += new System.EventHandler(this.ln_Click);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(164, 249);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(47, 47);
            this.ln.TabIndex = 8;
            this.ln.Text = "ln";
            this.ln.UseVisualStyleBackColor = true;
            this.ln.Click += new System.EventHandler(this.ln_Click);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(217, 249);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(47, 47);
            this.sin.TabIndex = 9;
            this.sin.Text = "Sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.ln_Click);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(217, 196);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(47, 47);
            this.cos.TabIndex = 10;
            this.cos.Text = "Cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.ln_Click);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(323, 249);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(47, 47);
            this.tan.TabIndex = 11;
            this.tan.Text = "Tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.ln_Click);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(270, 249);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(47, 47);
            this.x2.TabIndex = 12;
            this.x2.Text = "x^2";
            this.x2.UseVisualStyleBackColor = true;
            this.x2.Click += new System.EventHandler(this.ln_Click);
            // 
            // arcsin
            // 
            this.arcsin.Location = new System.Drawing.Point(323, 143);
            this.arcsin.Name = "arcsin";
            this.arcsin.Size = new System.Drawing.Size(47, 47);
            this.arcsin.TabIndex = 13;
            this.arcsin.Text = "Arcsin";
            this.arcsin.UseVisualStyleBackColor = true;
            this.arcsin.Click += new System.EventHandler(this.ln_Click);
            // 
            // arccos
            // 
            this.arccos.Location = new System.Drawing.Point(322, 196);
            this.arccos.Name = "arccos";
            this.arccos.Size = new System.Drawing.Size(48, 47);
            this.arccos.TabIndex = 14;
            this.arccos.Text = "Arccos";
            this.arccos.UseVisualStyleBackColor = true;
            this.arccos.Click += new System.EventHandler(this.ln_Click);
            // 
            // arctan
            // 
            this.arctan.Location = new System.Drawing.Point(56, 249);
            this.arctan.Name = "arctan";
            this.arctan.Size = new System.Drawing.Size(47, 47);
            this.arctan.TabIndex = 15;
            this.arctan.Text = "Arctan";
            this.arctan.UseVisualStyleBackColor = true;
            this.arctan.Click += new System.EventHandler(this.ln_Click);
            // 
            // arcctg
            // 
            this.arcctg.Location = new System.Drawing.Point(271, 196);
            this.arcctg.Name = "arcctg";
            this.arcctg.Size = new System.Drawing.Size(47, 47);
            this.arcctg.TabIndex = 16;
            this.arcctg.Text = "Arcctg";
            this.arcctg.UseVisualStyleBackColor = true;
            this.arcctg.Click += new System.EventHandler(this.ln_Click);
            // 
            // ctg
            // 
            this.ctg.Location = new System.Drawing.Point(2, 249);
            this.ctg.Name = "ctg";
            this.ctg.Size = new System.Drawing.Size(47, 47);
            this.ctg.TabIndex = 17;
            this.ctg.Text = "Ctg";
            this.ctg.UseVisualStyleBackColor = true;
            this.ctg.Click += new System.EventHandler(this.ln_Click);
            // 
            // xiny
            // 
            this.xiny.Location = new System.Drawing.Point(216, 143);
            this.xiny.Name = "xiny";
            this.xiny.Size = new System.Drawing.Size(48, 47);
            this.xiny.TabIndex = 18;
            this.xiny.Text = "x^y";
            this.xiny.UseVisualStyleBackColor = true;
            this.xiny.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // xinreversey
            // 
            this.xinreversey.Location = new System.Drawing.Point(270, 143);
            this.xinreversey.Name = "xinreversey";
            this.xinreversey.Size = new System.Drawing.Size(48, 47);
            this.xinreversey.TabIndex = 19;
            this.xinreversey.Text = "x^(1/y)";
            this.xinreversey.UseVisualStyleBackColor = true;
            this.xinreversey.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(1, 196);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(48, 47);
            this.max.TabIndex = 21;
            this.max.Text = "Max";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(55, 196);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(48, 47);
            this.min.TabIndex = 22;
            this.min.Text = "Min";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(163, 196);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(48, 47);
            this.average.TabIndex = 23;
            this.average.Text = "Avr";
            this.average.UseVisualStyleBackColor = true;
            this.average.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // remain
            // 
            this.remain.Location = new System.Drawing.Point(109, 196);
            this.remain.Name = "remain";
            this.remain.Size = new System.Drawing.Size(48, 47);
            this.remain.TabIndex = 24;
            this.remain.Text = "%";
            this.remain.UseVisualStyleBackColor = true;
            this.remain.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 301);
            this.Controls.Add(this.remain);
            this.Controls.Add(this.average);
            this.Controls.Add(this.min);
            this.Controls.Add(this.max);
            this.Controls.Add(this.xinreversey);
            this.Controls.Add(this.xiny);
            this.Controls.Add(this.ctg);
            this.Controls.Add(this.arcctg);
            this.Controls.Add(this.arctan);
            this.Controls.Add(this.arccos);
            this.Controls.Add(this.arcsin);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.root);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.textBoxSecondIn);
            this.Controls.Add(this.textBoxFirstIn);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstIn;
        private System.Windows.Forms.TextBox textBoxSecondIn;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button arcsin;
        private System.Windows.Forms.Button arccos;
        private System.Windows.Forms.Button arctan;
        private System.Windows.Forms.Button arcctg;
        private System.Windows.Forms.Button ctg;
        private System.Windows.Forms.Button xiny;
        private System.Windows.Forms.Button xinreversey;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button average;
        private System.Windows.Forms.Button remain;
    }
}

