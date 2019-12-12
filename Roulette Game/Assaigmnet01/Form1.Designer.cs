namespace Assaigmnet01
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.exitbtn = new System.Windows.Forms.Button();
            this.picwin = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.PictureBox();
            this.picfail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picwin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfail)).BeginInit();
            this.SuspendLayout();
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.exitbtn.BackgroundImage = global::Assaigmnet01.Properties.Resources._10_103647_minecraft_creeper_face_icons_png_minecraft_creeper_head;
            this.exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitbtn.Location = new System.Drawing.Point(578, 2);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(50, 50);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // picwin
            // 
            this.picwin.Image = ((System.Drawing.Image)(resources.GetObject("picwin.Image")));
            this.picwin.Location = new System.Drawing.Point(265, 213);
            this.picwin.Name = "picwin";
            this.picwin.Size = new System.Drawing.Size(160, 90);
            this.picwin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picwin.TabIndex = 2;
            this.picwin.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(391, 25);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(160, 160);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(133, 25);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(160, 160);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.BackgroundImage = global::Assaigmnet01.Properties.Resources.minecraft_diamond_pickaxe_template_2;
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Start.Location = new System.Drawing.Point(548, 268);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(80, 80);
            this.Start.TabIndex = 4;
            this.Start.TabStop = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // picfail
            // 
            this.picfail.Image = ((System.Drawing.Image)(resources.GetObject("picfail.Image")));
            this.picfail.Location = new System.Drawing.Point(216, 191);
            this.picfail.Name = "picfail";
            this.picfail.Size = new System.Drawing.Size(251, 135);
            this.picfail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picfail.TabIndex = 5;
            this.picfail.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assaigmnet01.Properties.Resources._41725_minecraft_background_pictures;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.picfail);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.picwin);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Game_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Game_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picwin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox picwin;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.PictureBox Start;
        private System.Windows.Forms.PictureBox picfail;
    }
}

