namespace Ezra
{
    partial class Form1
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
            pnlEzra = new Panel();
            pbEzra = new PictureBox();
            flpChat = new FlowLayoutPanel();
            flpButtoms = new FlowLayoutPanel();
            btGame = new Button();
            btWake = new Button();
            btRemind = new Button();
            btMusic = new Button();
            btFact = new Button();
            btRun = new Button();
            flpSend = new FlowLayoutPanel();
            tbText = new TextBox();
            btSend = new Button();
            pnlEzra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEzra).BeginInit();
            flpButtoms.SuspendLayout();
            flpSend.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEzra
            // 
            pnlEzra.BackColor = SystemColors.GradientActiveCaption;
            pnlEzra.Controls.Add(pbEzra);
            pnlEzra.Location = new Point(0, 0);
            pnlEzra.Name = "pnlEzra";
            pnlEzra.RightToLeft = RightToLeft.Yes;
            pnlEzra.Size = new Size(418, 43);
            pnlEzra.TabIndex = 0;
            // 
            // pbEzra
            // 
            pbEzra.Image = Properties.Resources.Ezra;
            pbEzra.Location = new Point(3, 3);
            pbEzra.Name = "pbEzra";
            pbEzra.Size = new Size(56, 40);
            pbEzra.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEzra.TabIndex = 0;
            pbEzra.TabStop = false;
            // 
            // flpChat
            // 
            flpChat.AutoScroll = true;
            flpChat.FlowDirection = FlowDirection.TopDown;
            flpChat.Location = new Point(3, 49);
            flpChat.Name = "flpChat";
            flpChat.RightToLeft = RightToLeft.Yes;
            flpChat.Size = new Size(415, 348);
            flpChat.TabIndex = 0;
            flpChat.WrapContents = false;
            // 
            // flpButtoms
            // 
            flpButtoms.Controls.Add(btGame);
            flpButtoms.Controls.Add(btWake);
            flpButtoms.Controls.Add(btRemind);
            flpButtoms.Controls.Add(btMusic);
            flpButtoms.Controls.Add(btFact);
            flpButtoms.Controls.Add(btRun);
            flpButtoms.Location = new Point(3, 403);
            flpButtoms.Name = "flpButtoms";
            flpButtoms.RightToLeft = RightToLeft.Yes;
            flpButtoms.Size = new Size(415, 93);
            flpButtoms.TabIndex = 0;
            // 
            // btGame
            // 
            btGame.BackColor = SystemColors.GradientActiveCaption;
            btGame.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btGame.Location = new Point(281, 3);
            btGame.Name = "btGame";
            btGame.Size = new Size(131, 41);
            btGame.TabIndex = 0;
            btGame.Text = "בוא נשחק!";
            btGame.UseVisualStyleBackColor = false;
            btGame.Click += btGame_Click;
            // 
            // btWake
            // 
            btWake.BackColor = SystemColors.GradientActiveCaption;
            btWake.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btWake.Location = new Point(144, 3);
            btWake.Name = "btWake";
            btWake.Size = new Size(131, 41);
            btWake.TabIndex = 1;
            btWake.Text = "תעיר אותי!";
            btWake.UseVisualStyleBackColor = false;
            btWake.Click += btWake_Click;
            // 
            // btRemind
            // 
            btRemind.BackColor = SystemColors.GradientActiveCaption;
            btRemind.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btRemind.Location = new Point(7, 3);
            btRemind.Name = "btRemind";
            btRemind.Size = new Size(131, 41);
            btRemind.TabIndex = 2;
            btRemind.Text = "תזכורת חדשה";
            btRemind.UseVisualStyleBackColor = false;
            btRemind.Click += btRemind_Click;
            // 
            // btMusic
            // 
            btMusic.BackColor = SystemColors.GradientActiveCaption;
            btMusic.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btMusic.Location = new Point(281, 50);
            btMusic.Name = "btMusic";
            btMusic.Size = new Size(131, 41);
            btMusic.TabIndex = 3;
            btMusic.Text = "נגן לי!";
            btMusic.UseVisualStyleBackColor = false;
            btMusic.Click += btMusic_Click;
            // 
            // btFact
            // 
            btFact.BackColor = SystemColors.GradientActiveCaption;
            btFact.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btFact.Location = new Point(144, 50);
            btFact.Name = "btFact";
            btFact.Size = new Size(131, 41);
            btFact.TabIndex = 4;
            btFact.Text = "הידעת?";
            btFact.UseVisualStyleBackColor = false;
            // 
            // btRun
            // 
            btRun.BackColor = SystemColors.GradientActiveCaption;
            btRun.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btRun.Location = new Point(7, 50);
            btRun.Name = "btRun";
            btRun.Size = new Size(131, 41);
            btRun.TabIndex = 5;
            btRun.Text = "הרץ!";
            btRun.UseVisualStyleBackColor = false;
            // 
            // flpSend
            // 
            flpSend.BackColor = SystemColors.Control;
            flpSend.Controls.Add(tbText);
            flpSend.Controls.Add(btSend);
            flpSend.Location = new Point(3, 499);
            flpSend.Name = "flpSend";
            flpSend.RightToLeft = RightToLeft.Yes;
            flpSend.Size = new Size(415, 31);
            flpSend.TabIndex = 0;
            // 
            // tbText
            // 
            tbText.Location = new Point(52, 3);
            tbText.Name = "tbText";
            tbText.Size = new Size(360, 27);
            tbText.TabIndex = 1;
            // 
            // btSend
            // 
            btSend.Image = Properties.Resources.send_btn;
            btSend.Location = new Point(6, 3);
            btSend.Name = "btSend";
            btSend.Size = new Size(40, 30);
            btSend.TabIndex = 2;
            btSend.UseVisualStyleBackColor = true;
            btSend.Click += btSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 533);
            Controls.Add(flpChat);
            Controls.Add(flpButtoms);
            Controls.Add(flpSend);
            Controls.Add(pnlEzra);
            Name = "Form1";
            Text = "My Ezra";
            pnlEzra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbEzra).EndInit();
            flpButtoms.ResumeLayout(false);
            flpSend.ResumeLayout(false);
            flpSend.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEzra;
        private FlowLayoutPanel flpChat;
        private FlowLayoutPanel flpButtoms;
        private FlowLayoutPanel flpSend;
        private PictureBox pbEzra;
        private Button btGame;
        private Button btWake;
        private Button btRemind;
        private Button btMusic;
        private Button btFact;
        private Button btRun;
        private TextBox tbText;
        private Button btSend;
    }
}