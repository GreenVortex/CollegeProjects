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
            this.BGMusicTgl = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picwin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGMusicTgl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.exitbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitbtn.BackgroundImage")));
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
            this.picwin.BackgroundImage = global::Assaigmnet01.Properties.Resources.download;
            this.picwin.Image = global::Assaigmnet01.Properties.Resources.bad1;
            this.picwin.Location = new System.Drawing.Point(262, 184);
            this.picwin.Name = "picwin";
            this.picwin.Size = new System.Drawing.Size(150, 150);
            this.picwin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picwin.TabIndex = 2;
            this.picwin.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(340, 47);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(120, 120);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(209, 47);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(120, 120);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Start.BackgroundImage")));
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
            this.picfail.BackgroundImage = global::Assaigmnet01.Properties.Resources.download;
            this.picfail.Image = global::Assaigmnet01.Properties.Resources.good1;
            this.picfail.Location = new System.Drawing.Point(262, 184);
            this.picfail.Name = "picfail";
            this.picfail.Size = new System.Drawing.Size(150, 150);
            this.picfail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picfail.TabIndex = 5;
            this.picfail.TabStop = false;
            // 
            // BGMusicTgl
            // 
            this.BGMusicTgl.BackColor = System.Drawing.Color.Transparent;
            this.BGMusicTgl.Image = global::Assaigmnet01.Properties.Resources.juke;
            this.BGMusicTgl.Location = new System.Drawing.Point(12, 288);
            this.BGMusicTgl.Name = "BGMusicTgl";
            this.BGMusicTgl.Size = new System.Drawing.Size(60, 60);
            this.BGMusicTgl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BGMusicTgl.TabIndex = 6;
            this.BGMusicTgl.TabStop = false;
            this.BGMusicTgl.Click += new System.EventHandler(this.BGMusicTgl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Assaigmnet01.Properties.Resources.tnt;
            this.pictureBox1.Location = new System.Drawing.Point(78, 288);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Minecraft", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.SystemColors.Control;
            this.Score.Image = global::Assaigmnet01.Properties.Resources.download;
            this.Score.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Score.Location = new System.Drawing.Point(-2, -8);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(111, 40);
            this.Score.TabIndex = 8;
            this.Score.Text = "Score";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BGMusicTgl);
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
            ((System.ComponentModel.ISupportInitialize)(this.BGMusicTgl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox picwin;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.PictureBox Start;
        private System.Windows.Forms.PictureBox picfail;
        private System.Windows.Forms.PictureBox BGMusicTgl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Score;
    }
}

