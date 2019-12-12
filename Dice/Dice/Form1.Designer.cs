namespace Dice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Roll = new System.Windows.Forms.Button();
            this.Roll2 = new System.Windows.Forms.Button();
            this.Coin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Roll
            // 
            resources.ApplyResources(this.Roll, "Roll");
            this.Roll.Name = "Roll";
            this.Roll.UseVisualStyleBackColor = true;
            this.Roll.Click += new System.EventHandler(this.Roll_Click);
            // 
            // Roll2
            // 
            resources.ApplyResources(this.Roll2, "Roll2");
            this.Roll2.Name = "Roll2";
            this.Roll2.UseVisualStyleBackColor = true;
            // 
            // Coin
            // 
            resources.ApplyResources(this.Coin, "Coin");
            this.Coin.Name = "Coin";
            this.Coin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Coin);
            this.Controls.Add(this.Roll2);
            this.Controls.Add(this.Roll);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Roll;
        private System.Windows.Forms.Button Roll2;
        private System.Windows.Forms.Button Coin;
    }
}

