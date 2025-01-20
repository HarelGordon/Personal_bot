namespace Experience_success
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
            lblTitle = new Label();
            label1 = new Label();
            lblHowMuchGuess = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            tbGuess = new TextBox();
            btCheck = new Button();
            btNewGame = new Button();
            listQuestions = new ListBox();
            listUnguessedChar = new ListBox();
            label5 = new Label();
            listGuessedChar = new ListBox();
            flpQustions = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(1037, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(211, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "נחשו את הדמות";
            lblTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(745, 19);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(140, 21);
            label1.TabIndex = 1;
            label1.Text = "1. לחצו על השאלה";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHowMuchGuess
            // 
            lblHowMuchGuess.AutoSize = true;
            lblHowMuchGuess.Font = new Font("Segoe UI", 12F);
            lblHowMuchGuess.Location = new Point(432, 19);
            lblHowMuchGuess.Name = "lblHowMuchGuess";
            lblHowMuchGuess.RightToLeft = RightToLeft.Yes;
            lblHowMuchGuess.Size = new Size(172, 21);
            lblHowMuchGuess.TabIndex = 2;
            lblHowMuchGuess.Text = "נותרו 5 שאלות מתוך 10";
            lblHowMuchGuess.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 19);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(276, 21);
            label3.TabIndex = 3;
            label3.Text = "2. מחקו דמויות שלא מתאימות לתשובה";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1074, 76);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 128);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(1074, 231);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(127, 21);
            label4.TabIndex = 5;
            label4.Text = "יודעים מי הדמות?";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbGuess
            // 
            tbGuess.Location = new Point(1074, 265);
            tbGuess.Margin = new Padding(3, 2, 3, 2);
            tbGuess.Name = "tbGuess";
            tbGuess.RightToLeft = RightToLeft.Yes;
            tbGuess.Size = new Size(131, 23);
            tbGuess.TabIndex = 6;
            // 
            // btCheck
            // 
            btCheck.BackColor = Color.CornflowerBlue;
            btCheck.Font = new Font("Segoe UI", 14F);
            btCheck.ForeColor = Color.Transparent;
            btCheck.Location = new Point(1100, 298);
            btCheck.Margin = new Padding(3, 2, 3, 2);
            btCheck.Name = "btCheck";
            btCheck.Size = new Size(82, 32);
            btCheck.TabIndex = 7;
            btCheck.Text = "בדיקה";
            btCheck.UseVisualStyleBackColor = false;
            btCheck.Click += btCheck_Click;
            // 
            // btNewGame
            // 
            btNewGame.BackColor = Color.Gainsboro;
            btNewGame.Font = new Font("Segoe UI", 13F);
            btNewGame.ForeColor = Color.CornflowerBlue;
            btNewGame.Location = new Point(1083, 346);
            btNewGame.Margin = new Padding(3, 2, 3, 2);
            btNewGame.Name = "btNewGame";
            btNewGame.Size = new Size(118, 49);
            btNewGame.TabIndex = 8;
            btNewGame.Text = "משחק חדש";
            btNewGame.UseVisualStyleBackColor = false;
            btNewGame.Click += btNewGame_Click;
            // 
            // listQuestions
            // 
            listQuestions.FormattingEnabled = true;
            listQuestions.ItemHeight = 15;
            listQuestions.Location = new Point(647, 49);
            listQuestions.Margin = new Padding(3, 2, 3, 2);
            listQuestions.Name = "listQuestions";
            listQuestions.RightToLeft = RightToLeft.Yes;
            listQuestions.Size = new Size(256, 439);
            listQuestions.TabIndex = 9;
            listQuestions.SelectedIndexChanged += listQuestions_SelectedIndexChanged;
            // 
            // listUnguessedChar
            // 
            listUnguessedChar.FormattingEnabled = true;
            listUnguessedChar.ItemHeight = 15;
            listUnguessedChar.Location = new Point(26, 49);
            listUnguessedChar.Margin = new Padding(3, 2, 3, 2);
            listUnguessedChar.Name = "listUnguessedChar";
            listUnguessedChar.RightToLeft = RightToLeft.Yes;
            listUnguessedChar.Size = new Size(273, 199);
            listUnguessedChar.TabIndex = 10;
            listUnguessedChar.SelectedIndexChanged += listUnguessedChar_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(157, 263);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(119, 21);
            label5.TabIndex = 11;
            label5.Text = "דמויות שמחקתי";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // listGuessedChar
            // 
            listGuessedChar.FormattingEnabled = true;
            listGuessedChar.ItemHeight = 15;
            listGuessedChar.Location = new Point(22, 298);
            listGuessedChar.Margin = new Padding(3, 2, 3, 2);
            listGuessedChar.Name = "listGuessedChar";
            listGuessedChar.RightToLeft = RightToLeft.Yes;
            listGuessedChar.Size = new Size(273, 184);
            listGuessedChar.TabIndex = 12;
            listGuessedChar.SelectedIndexChanged += listGuessedChar_SelectedIndexChanged;
            // 
            // flpQustions
            // 
            flpQustions.AutoScroll = true;
            flpQustions.FlowDirection = FlowDirection.TopDown;
            flpQustions.Location = new Point(353, 49);
            flpQustions.Margin = new Padding(3, 2, 3, 2);
            flpQustions.Name = "flpQustions";
            flpQustions.RightToLeft = RightToLeft.Yes;
            flpQustions.Size = new Size(256, 433);
            flpQustions.TabIndex = 13;
            flpQustions.WrapContents = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 511);
            Controls.Add(flpQustions);
            Controls.Add(listGuessedChar);
            Controls.Add(label5);
            Controls.Add(listUnguessedChar);
            Controls.Add(listQuestions);
            Controls.Add(btNewGame);
            Controls.Add(btCheck);
            Controls.Add(tbGuess);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(lblHowMuchGuess);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "נחשו את הדמות";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private Label lblHowMuchGuess;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox tbGuess;
        private Button btCheck;
        private Button btNewGame;
        private ListBox listQuestions;
        private ListBox listUnguessedChar;
        private Label label5;
        private ListBox listGuessedChar;
        private FlowLayoutPanel flpQustions;
    }
}