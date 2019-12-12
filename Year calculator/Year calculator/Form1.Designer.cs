namespace Year_calculator
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
            this.CalculateMonth = new System.Windows.Forms.Button();
            this.MonthGet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MonthResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Days = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GetYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LeapYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalculateMonth
            // 
            this.CalculateMonth.Location = new System.Drawing.Point(20, 142);
            this.CalculateMonth.Name = "CalculateMonth";
            this.CalculateMonth.Size = new System.Drawing.Size(75, 46);
            this.CalculateMonth.TabIndex = 0;
            this.CalculateMonth.Text = "Calculate Month";
            this.CalculateMonth.UseVisualStyleBackColor = true;
            this.CalculateMonth.Click += new System.EventHandler(this.CalculateMonth_Click);
            // 
            // MonthGet
            // 
            this.MonthGet.Location = new System.Drawing.Point(88, 14);
            this.MonthGet.Name = "MonthGet";
            this.MonthGet.Size = new System.Drawing.Size(93, 20);
            this.MonthGet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Month #:";
            // 
            // MonthResult
            // 
            this.MonthResult.Location = new System.Drawing.Point(88, 67);
            this.MonthResult.Name = "MonthResult";
            this.MonthResult.ReadOnly = true;
            this.MonthResult.Size = new System.Drawing.Size(93, 20);
            this.MonthResult.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your Month is:";
            // 
            // Days
            // 
            this.Days.Location = new System.Drawing.Point(88, 90);
            this.Days.Name = "Days";
            this.Days.ReadOnly = true;
            this.Days.Size = new System.Drawing.Size(93, 20);
            this.Days.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Months days:";
            // 
            // GetYear
            // 
            this.GetYear.Location = new System.Drawing.Point(88, 41);
            this.GetYear.Name = "GetYear";
            this.GetYear.Size = new System.Drawing.Size(93, 20);
            this.GetYear.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter Year:";
            // 
            // LeapYear
            // 
            this.LeapYear.Location = new System.Drawing.Point(88, 116);
            this.LeapYear.Name = "LeapYear";
            this.LeapYear.ReadOnly = true;
            this.LeapYear.Size = new System.Drawing.Size(93, 20);
            this.LeapYear.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Is it a leap year";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(101, 142);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 46);
            this.Clear.TabIndex = 12;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 200);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LeapYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GetYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MonthResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MonthGet);
            this.Controls.Add(this.CalculateMonth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Month";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateMonth;
        private System.Windows.Forms.TextBox MonthGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MonthResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Days;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GetYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LeapYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Clear;
    }
}

