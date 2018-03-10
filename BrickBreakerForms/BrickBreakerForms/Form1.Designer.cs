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
            this.SuspendLayout();
            // 
            // GameRun
            // 
            this.GameRun.Enabled = true;
            this.GameRun.Interval = 10;
            this.GameRun.Tick += new System.EventHandler(this.GameRun_Tick);
            // 
            // unusedLabel
            // 
            this.unusedLabel.AutoSize = true;
            this.unusedLabel.Font = new System.Drawing.Font("Quartz MS", 69.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unusedLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.unusedLabel.Location = new System.Drawing.Point(-2687, 639);
            this.unusedLabel.Name = "unusedLabel";
            this.unusedLabel.Size = new System.Drawing.Size(3560, 112);
            this.unusedLabel.TabIndex = 0;
            this.unusedLabel.Text = "////////////////////////////////////////////////////////////////////////////LIVES" +
    ":        SCORE:\r\n";
            this.unusedLabel.Click += new System.EventHandler(this.unusedLabel_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Quartz MS", 65.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.scoreLabel.Location = new System.Drawing.Point(839, 645);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(369, 105);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "000000";
            this.scoreLabel.Click += new System.EventHandler(this.scoreLabel_Click);
            // 
            // LivesLabel
            // 
            this.LivesLabel.AutoSize = true;
            this.LivesLabel.Font = new System.Drawing.Font("Quartz MS", 65.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LivesLabel.Location = new System.Drawing.Point(332, 646);
            this.LivesLabel.Name = "LivesLabel";
            this.LivesLabel.Size = new System.Drawing.Size(207, 105);
            this.LivesLabel.TabIndex = 2;
            this.LivesLabel.Text = "005";
            this.LivesLabel.Click += new System.EventHandler(this.LivesLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1194, 751);
            this.Controls.Add(this.LivesLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.unusedLabel);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer GameRun;
        private System.Windows.Forms.Label unusedLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label LivesLabel;
    }
}

