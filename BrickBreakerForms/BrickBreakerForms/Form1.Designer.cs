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
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.uwin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GameRun
            // 
            this.GameRun.Enabled = true;
            this.GameRun.Interval = 1;
            this.GameRun.Tick += new System.EventHandler(this.GameRun_Tick);
            // 
            // unusedLabel
            // 
            this.unusedLabel.AutoSize = true;
            this.unusedLabel.BackColor = System.Drawing.Color.Black;
            this.unusedLabel.Font = new System.Drawing.Font("OCR A Extended", 69.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unusedLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.unusedLabel.Location = new System.Drawing.Point(-3581, 1075);
            this.unusedLabel.Name = "unusedLabel";
            this.unusedLabel.Size = new System.Drawing.Size(5133, 86);
            this.unusedLabel.TabIndex = 0;
            this.unusedLabel.Text = "////////////////////////////////////////////////////////////////////////////LIVES" +
    ":   SCORE:\r\n";
            this.unusedLabel.Click += new System.EventHandler(this.unusedLabel_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Black;
            this.scoreLabel.Font = new System.Drawing.Font("OCR A Extended", 65.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.scoreLabel.Location = new System.Drawing.Point(1540, 1075);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(352, 80);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "000000";
            this.scoreLabel.Click += new System.EventHandler(this.scoreLabel_Click);
            // 
            // LivesLabel
            // 
            this.LivesLabel.AutoSize = true;
            this.LivesLabel.BackColor = System.Drawing.Color.Black;
            this.LivesLabel.Font = new System.Drawing.Font("OCR A Extended", 65.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LivesLabel.Location = new System.Drawing.Point(1004, 1075);
            this.LivesLabel.Name = "LivesLabel";
            this.LivesLabel.Size = new System.Drawing.Size(193, 80);
            this.LivesLabel.TabIndex = 2;
            this.LivesLabel.Text = "005";
            this.LivesLabel.Click += new System.EventHandler(this.LivesLabel_Click);
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackColor = System.Drawing.Color.Black;
            this.mainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(1904, 1161);
            this.mainPictureBox.TabIndex = 3;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.Click += new System.EventHandler(this.mainPictureBox_Click);
            // 
            // uwin
            // 
            this.uwin.BackColor = System.Drawing.Color.Khaki;
            this.uwin.Font = new System.Drawing.Font("Tahoma", 120F, System.Drawing.FontStyle.Italic);
            this.uwin.ForeColor = System.Drawing.Color.Cyan;
            this.uwin.Location = new System.Drawing.Point(387, 298);
            this.uwin.Name = "uwin";
            this.uwin.ReadOnly = true;
            this.uwin.Size = new System.Drawing.Size(710, 201);
            this.uwin.TabIndex = 4;
            this.uwin.Text = "YOU WIN";
            this.uwin.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1904, 1161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uwin);
            this.Controls.Add(this.LivesLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.unusedLabel);
            this.Controls.Add(this.mainPictureBox);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer GameRun;
        private System.Windows.Forms.Label unusedLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label LivesLabel;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.TextBox uwin;
        private System.Windows.Forms.Label label1;
    }
}

