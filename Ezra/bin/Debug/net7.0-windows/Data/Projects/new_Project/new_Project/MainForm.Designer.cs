namespace Ghost
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            pbGhost = new PictureBox();
            lblGameScore = new Label();
            lblTimerCount = new Label();
            tGame = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbGhost).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(399, 513);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(114, 67);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // pbGhost
            // 
            pbGhost.Image = Properties.Resources.start;
            pbGhost.Location = new Point(738, 442);
            pbGhost.Margin = new Padding(3, 4, 3, 4);
            pbGhost.Name = "pbGhost";
            pbGhost.Size = new Size(137, 160);
            pbGhost.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGhost.TabIndex = 1;
            pbGhost.TabStop = false;
            pbGhost.Visible = false;
            pbGhost.Click += pbGhost_Click;
            // 
            // lblGameScore
            // 
            lblGameScore.AutoSize = true;
            lblGameScore.Font = new Font("Segoe UI", 16F);
            lblGameScore.ForeColor = Color.Yellow;
            lblGameScore.Location = new Point(29, 44);
            lblGameScore.Name = "lblGameScore";
            lblGameScore.Size = new Size(79, 37);
            lblGameScore.TabIndex = 2;
            lblGameScore.Text = "score";
            lblGameScore.Visible = false;
            // 
            // lblTimerCount
            // 
            lblTimerCount.AutoSize = true;
            lblTimerCount.Font = new Font("Segoe UI", 16F);
            lblTimerCount.ForeColor = Color.Yellow;
            lblTimerCount.Location = new Point(153, 44);
            lblTimerCount.Name = "lblTimerCount";
            lblTimerCount.Size = new Size(153, 37);
            lblTimerCount.TabIndex = 3;
            lblTimerCount.Text = "timer count";
            lblTimerCount.Visible = false;
            // 
            // tGame
            // 
            tGame.Interval = 1000;
            tGame.Tick += tGame_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(896, 615);
            Controls.Add(lblTimerCount);
            Controls.Add(lblGameScore);
            Controls.Add(pbGhost);
            Controls.Add(btnStart);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "תפוס אותו";
            ((System.ComponentModel.ISupportInitialize)pbGhost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private PictureBox pbGhost;
        private Label lblGameScore;
        private Label lblTimerCount;
        private System.Windows.Forms.Timer tGame;
    }
}