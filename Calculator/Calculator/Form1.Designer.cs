namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Result = new System.Windows.Forms.TextBox();
            this.Display = new System.Windows.Forms.TextBox();
            this.Num0 = new System.Windows.Forms.PictureBox();
            this.divide = new System.Windows.Forms.PictureBox();
            this.calculate = new System.Windows.Forms.PictureBox();
            this.multiply = new System.Windows.Forms.PictureBox();
            this.minus = new System.Windows.Forms.PictureBox();
            this.add = new System.Windows.Forms.PictureBox();
            this.Num9 = new System.Windows.Forms.PictureBox();
            this.Num8 = new System.Windows.Forms.PictureBox();
            this.Num7 = new System.Windows.Forms.PictureBox();
            this.Num6 = new System.Windows.Forms.PictureBox();
            this.Num5 = new System.Windows.Forms.PictureBox();
            this.Num4 = new System.Windows.Forms.PictureBox();
            this.Num3 = new System.Windows.Forms.PictureBox();
            this.Num2 = new System.Windows.Forms.PictureBox();
            this.Num1 = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Num0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(26, 73);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(170, 20);
            this.Result.TabIndex = 19;
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(26, 47);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(226, 20);
            this.Display.TabIndex = 20;
            // 
            // Num0
            // 
            this.Num0.BackgroundImage = global::Calculator.Properties.Resources._0;
            this.Num0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Num0.Location = new System.Drawing.Point(83, 279);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(50, 50);
            this.Num0.TabIndex = 26;
            this.Num0.TabStop = false;
            this.Num0.Click += new System.EventHandler(this.Num0_Click);
            // 
            // divide
            // 
            this.divide.BackgroundImage = global::Calculator.Properties.Resources.divide;
            this.divide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.divide.Location = new System.Drawing.Point(269, 165);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(50, 50);
            this.divide.TabIndex = 25;
            this.divide.TabStop = false;
            // 
            // calculate
            // 
            this.calculate.BackgroundImage = global::Calculator.Properties.Resources.calculator_maths_tool;
            this.calculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calculate.Location = new System.Drawing.Point(269, 223);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(50, 50);
            this.calculate.TabIndex = 24;
            this.calculate.TabStop = false;
            this.calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // multiply
            // 
            this.multiply.BackgroundImage = global::Calculator.Properties.Resources.multiply_mathematical_sign;
            this.multiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.multiply.Location = new System.Drawing.Point(212, 166);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(50, 50);
            this.multiply.TabIndex = 23;
            this.multiply.TabStop = false;
            this.multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // minus
            // 
            this.minus.BackgroundImage = global::Calculator.Properties.Resources.minus_sign;
            this.minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minus.Location = new System.Drawing.Point(268, 109);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(50, 50);
            this.minus.TabIndex = 22;
            this.minus.TabStop = false;
            this.minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // add
            // 
            this.add.BackgroundImage = global::Calculator.Properties.Resources.plus_positive_add_mathematical_symbol;
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.Location = new System.Drawing.Point(212, 109);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(50, 50);
            this.add.TabIndex = 21;
            this.add.TabStop = false;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Num9
            // 
            this.Num9.BackgroundImage = global::Calculator.Properties.Resources.nine;
            this.Num9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Num9.Location = new System.Drawing.Point(138, 223);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(50, 50);
            this.Num9.TabIndex = 18;
            this.Num9.TabStop = false;
            this.Num9.Click += new System.EventHandler(this.Num9_Click);
            // 
            // Num8
            // 
            this.Num8.BackgroundImage = global::Calculator.Properties.Resources.eight;
            this.Num8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Num8.Location = new System.Drawing.Point(82, 223);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(50, 50);
            this.Num8.TabIndex = 17;
            this.Num8.TabStop = false;
            this.Num8.Click += new System.EventHandler(this.Num8_Click);
            // 
            // Num7
            // 
            this.Num7.BackgroundImage = global::Calculator.Properties.Resources.seven;
            this.Num7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Num7.Location = new System.Drawing.Point(27, 222);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(50, 50);
            this.Num7.TabIndex = 16;
            this.Num7.TabStop = false;
            this.Num7.Click += new System.EventHandler(this.Num7_Click);
            // 
            // Num6
            // 
            this.Num6.BackgroundImage = global::Calculator.Properties.Resources.six;
            this.Num6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Num6.Location = new System.Drawing.Point(138, 166);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(50, 50);
            this.Num6.TabIndex = 15;
            this.Num6.TabStop = false;
            this.Num6.Click += new System.EventHandler(this.Num6_Click);
            // 
            // Num5
            // 
            this.Num5.BackgroundImage = global::Calculator.Properties.Resources.five;
            this.Num5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Num5.Location = new System.Drawing.Point(83, 166);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(50, 50);
            this.Num5.TabIndex = 14;
            this.Num5.TabStop = false;
            this.Num5.Click += new System.EventHandler(this.Num5_Click);
            // 
            // Num4
            // 
            this.Num4.BackgroundImage = global::Calculator.Properties.Resources.four;
            this.Num4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Num4.Location = new System.Drawing.Point(26, 165);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(50, 50);
            this.Num4.TabIndex = 13;
            this.Num4.TabStop = false;
            this.Num4.Click += new System.EventHandler(this.Num4_Click);
            // 
            // Num3
            // 
            this.Num3.BackgroundImage = global::Calculator.Properties.Resources.three;
            this.Num3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Num3.Location = new System.Drawing.Point(138, 109);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(50, 50);
            this.Num3.TabIndex = 12;
            this.Num3.TabStop = false;
            this.Num3.Click += new System.EventHandler(this.Num3_Click);
            // 
            // Num2
            // 
            this.Num2.BackgroundImage = global::Calculator.Properties.Resources.two;
            this.Num2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Num2.Location = new System.Drawing.Point(82, 109);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(50, 50);
            this.Num2.TabIndex = 11;
            this.Num2.TabStop = false;
            this.Num2.Click += new System.EventHandler(this.Num2_Click);
            // 
            // Num1
            // 
            this.Num1.BackgroundImage = global::Calculator.Properties.Resources.one;
            this.Num1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Num1.Location = new System.Drawing.Point(26, 109);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(50, 50);
            this.Num1.TabIndex = 10;
            this.Num1.TabStop = false;
            this.Num1.Click += new System.EventHandler(this.Num1_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackgroundImage = global::Calculator.Properties.Resources.close;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseBtn.Location = new System.Drawing.Point(307, 2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(30, 30);
            this.CloseBtn.TabIndex = 9;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 351);
            this.Controls.Add(this.Num0);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Num9);
            this.Controls.Add(this.Num8);
            this.Controls.Add(this.Num7);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.CloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Num0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.PictureBox Num1;
        private System.Windows.Forms.PictureBox Num2;
        private System.Windows.Forms.PictureBox Num3;
        private System.Windows.Forms.PictureBox Num4;
        private System.Windows.Forms.PictureBox Num5;
        private System.Windows.Forms.PictureBox Num6;
        private System.Windows.Forms.PictureBox Num7;
        private System.Windows.Forms.PictureBox Num8;
        private System.Windows.Forms.PictureBox Num9;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.PictureBox add;
        private System.Windows.Forms.PictureBox minus;
        private System.Windows.Forms.PictureBox multiply;
        private System.Windows.Forms.PictureBox calculate;
        private System.Windows.Forms.PictureBox divide;
        private System.Windows.Forms.PictureBox Num0;
    }
}

