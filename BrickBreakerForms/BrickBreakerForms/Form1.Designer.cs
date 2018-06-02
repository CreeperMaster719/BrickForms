namespace BrickBreakerForms
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
            this.components = new System.ComponentModel.Container();
            this.GameRun = new System.Windows.Forms.Timer(this.components);
            this.unusedLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.LivesLabel = new System.Windows.Forms.Label();
            this.uwin = new System.Windows.Forms.TextBox();
            this.speedBoostBar = new System.Windows.Forms.ProgressBar();
            this.startButton = new System.Windows.Forms.Button();
            this.diff1 = new System.Windows.Forms.Button();
            this.diff2 = new System.Windows.Forms.Button();
            this.diff3 = new System.Windows.Forms.Button();
            this.superPong = new System.Windows.Forms.Label();
            this.superPongBallGif = new System.Windows.Forms.PictureBox();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.backgroundMenu = new System.Windows.Forms.PictureBox();
            this.newBall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.superPongBallGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBall)).BeginInit();
            this.SuspendLayout();
            // 
            // GameRun
            // 
            this.GameRun.Interval = 1;
            this.GameRun.Tick += new System.EventHandler(this.GameRun_Tick);
            // 
            // unusedLabel
            // 
            this.unusedLabel.AutoSize = true;
            this.unusedLabel.BackColor = System.Drawing.Color.Black;
            this.unusedLabel.Font = new System.Drawing.Font("OCR A Extended", 69.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unusedLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.unusedLabel.Location = new System.Drawing.Point(-3246, 1066);
            this.unusedLabel.Name = "unusedLabel";
            this.unusedLabel.Size = new System.Drawing.Size(4853, 86);
            this.unusedLabel.TabIndex = 0;
            this.unusedLabel.Text = "////////////////////////////////////////////////////////////SPEED BOOSTLIVES:   S" +
    "CORE:\r\n";
            this.unusedLabel.Visible = false;
            this.unusedLabel.Click += new System.EventHandler(this.unusedLabel_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Black;
            this.scoreLabel.Font = new System.Drawing.Font("OCR A Extended", 65.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.scoreLabel.Location = new System.Drawing.Point(1564, 1075);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(352, 80);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "000000";
            this.scoreLabel.Visible = false;
            this.scoreLabel.Click += new System.EventHandler(this.scoreLabel_Click);
            // 
            // LivesLabel
            // 
            this.LivesLabel.AutoSize = true;
            this.LivesLabel.BackColor = System.Drawing.Color.Black;
            this.LivesLabel.Font = new System.Drawing.Font("OCR A Extended", 65.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LivesLabel.Location = new System.Drawing.Point(1071, 1069);
            this.LivesLabel.Name = "LivesLabel";
            this.LivesLabel.Size = new System.Drawing.Size(193, 80);
            this.LivesLabel.TabIndex = 2;
            this.LivesLabel.Text = "005";
            this.LivesLabel.Visible = false;
            this.LivesLabel.Click += new System.EventHandler(this.LivesLabel_Click);
            // 
            // uwin
            // 
            this.uwin.BackColor = System.Drawing.Color.Khaki;
            this.uwin.Font = new System.Drawing.Font("Tahoma", 120F, System.Drawing.FontStyle.Italic);
            this.uwin.ForeColor = System.Drawing.Color.Cyan;
            this.uwin.Location = new System.Drawing.Point(509, 298);
            this.uwin.Name = "uwin";
            this.uwin.ReadOnly = true;
            this.uwin.Size = new System.Drawing.Size(710, 201);
            this.uwin.TabIndex = 4;
            this.uwin.Text = "YOU WIN";
            this.uwin.Visible = false;
            // 
            // speedBoostBar
            // 
            this.speedBoostBar.ForeColor = System.Drawing.Color.Red;
            this.speedBoostBar.Location = new System.Drawing.Point(137, 1139);
            this.speedBoostBar.Maximum = 51000;
            this.speedBoostBar.Name = "speedBoostBar";
            this.speedBoostBar.Size = new System.Drawing.Size(607, 22);
            this.speedBoostBar.TabIndex = 5;
            this.speedBoostBar.Visible = false;
            this.speedBoostBar.Click += new System.EventHandler(this.speedBoostBar_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.Enabled = false;
            this.startButton.Font = new System.Drawing.Font("Quartz MS", 150F);
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startButton.Location = new System.Drawing.Point(180, 817);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(1395, 246);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // diff1
            // 
            this.diff1.BackColor = System.Drawing.Color.Black;
            this.diff1.Font = new System.Drawing.Font("Quartz MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diff1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.diff1.Location = new System.Drawing.Point(332, 747);
            this.diff1.Name = "diff1";
            this.diff1.Size = new System.Drawing.Size(350, 64);
            this.diff1.TabIndex = 7;
            this.diff1.Text = "Difficulty 1";
            this.diff1.UseVisualStyleBackColor = false;
            this.diff1.Click += new System.EventHandler(this.diff1_Click);
            // 
            // diff2
            // 
            this.diff2.BackColor = System.Drawing.Color.Black;
            this.diff2.Font = new System.Drawing.Font("Quartz MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diff2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.diff2.Location = new System.Drawing.Point(688, 747);
            this.diff2.Name = "diff2";
            this.diff2.Size = new System.Drawing.Size(350, 64);
            this.diff2.TabIndex = 8;
            this.diff2.Text = "Difficulty 2";
            this.diff2.UseVisualStyleBackColor = false;
            this.diff2.Click += new System.EventHandler(this.diff2_Click);
            // 
            // diff3
            // 
            this.diff3.BackColor = System.Drawing.Color.Black;
            this.diff3.Font = new System.Drawing.Font("Quartz MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diff3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.diff3.Location = new System.Drawing.Point(1044, 747);
            this.diff3.Name = "diff3";
            this.diff3.Size = new System.Drawing.Size(350, 64);
            this.diff3.TabIndex = 9;
            this.diff3.Text = "Difficulty 3";
            this.diff3.UseVisualStyleBackColor = false;
            this.diff3.Click += new System.EventHandler(this.diff3_Click);
            // 
            // superPong
            // 
            this.superPong.AutoSize = true;
            this.superPong.Font = new System.Drawing.Font("Quartz MS", 200.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superPong.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.superPong.Location = new System.Drawing.Point(64, 0);
            this.superPong.Name = "superPong";
            this.superPong.Size = new System.Drawing.Size(1770, 321);
            this.superPong.TabIndex = 11;
            this.superPong.Text = "Super Pong!";
            // 
            // superPongBallGif
            // 
            this.superPongBallGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.superPongBallGif.Image = global::BrickBreakerForms.Properties.Resources.superPong;
            this.superPongBallGif.Location = new System.Drawing.Point(566, 206);
            this.superPongBallGif.Name = "superPongBallGif";
            this.superPongBallGif.Size = new System.Drawing.Size(588, 493);
            this.superPongBallGif.TabIndex = 12;
            this.superPongBallGif.TabStop = false;
            this.superPongBallGif.Click += new System.EventHandler(this.superPongBallGif_Click);
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackColor = System.Drawing.Color.Black;
            this.mainPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPictureBox.Enabled = false;
            this.mainPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(1904, 1161);
            this.mainPictureBox.TabIndex = 3;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.Click += new System.EventHandler(this.mainPictureBox_Click);
            // 
            // backgroundMenu
            // 
            this.backgroundMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundMenu.Location = new System.Drawing.Point(0, 0);
            this.backgroundMenu.Name = "backgroundMenu";
            this.backgroundMenu.Size = new System.Drawing.Size(1904, 1161);
            this.backgroundMenu.TabIndex = 10;
            this.backgroundMenu.TabStop = false;
            this.backgroundMenu.Click += new System.EventHandler(this.backgroundMenu_Click);
            // 
            // newBall
            // 
            this.newBall.Image = global::BrickBreakerForms.Properties.Resources.superPong;
            this.newBall.Location = new System.Drawing.Point(1832, 1032);
            this.newBall.Name = "newBall";
            this.newBall.Size = new System.Drawing.Size(60, 40);
            this.newBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newBall.TabIndex = 13;
            this.newBall.TabStop = false;
            this.newBall.Click += new System.EventHandler(this.newBall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1904, 1161);
            this.Controls.Add(this.newBall);
            this.Controls.Add(this.superPong);
            this.Controls.Add(this.LivesLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.diff3);
            this.Controls.Add(this.diff2);
            this.Controls.Add(this.diff1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.speedBoostBar);
            this.Controls.Add(this.uwin);
            this.Controls.Add(this.unusedLabel);
            this.Controls.Add(this.superPongBallGif);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.backgroundMenu);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.superPongBallGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer GameRun;
        private System.Windows.Forms.Label unusedLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label LivesLabel;
        private System.Windows.Forms.TextBox uwin;
        private System.Windows.Forms.ProgressBar speedBoostBar;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button diff1;
        private System.Windows.Forms.Button diff2;
        private System.Windows.Forms.Button diff3;
        private System.Windows.Forms.PictureBox backgroundMenu;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Label superPong;
        private System.Windows.Forms.PictureBox superPongBallGif;
        private System.Windows.Forms.PictureBox newBall;
    }
}

