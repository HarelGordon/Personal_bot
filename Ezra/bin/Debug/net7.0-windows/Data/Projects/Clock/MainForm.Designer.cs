namespace AlarmClock
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
            label1 = new Label();
            timerClock = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            lblClockHours = new Label();
            lblClockMinutes = new Label();
            lblClockSeconds = new Label();
            txtHours = new TextBox();
            txtMinutes = new TextBox();
            label3 = new Label();
            btOn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 120F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(312, 35);
            label1.Name = "label1";
            label1.Size = new Size(114, 317);
            label1.TabIndex = 2;
            label1.Text = ":";
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 120F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(731, 35);
            label2.Name = "label2";
            label2.Size = new Size(127, 317);
            label2.TabIndex = 7;
            label2.Text = ":";
            // 
            // lblClockHours
            // 
            lblClockHours.AutoSize = true;
            lblClockHours.BackColor = Color.Transparent;
            lblClockHours.Font = new Font("Segoe UI", 130F, FontStyle.Bold);
            lblClockHours.ForeColor = Color.CornflowerBlue;
            lblClockHours.Location = new Point(11, 35);
            lblClockHours.Name = "lblClockHours";
            lblClockHours.Size = new Size(370, 287);
            lblClockHours.TabIndex = 9;
            lblClockHours.Text = "00";
            // 
            // lblClockMinutes
            // 
            lblClockMinutes.AutoSize = true;
            lblClockMinutes.BackColor = Color.Transparent;
            lblClockMinutes.Font = new Font("Segoe UI", 130F, FontStyle.Bold);
            lblClockMinutes.ForeColor = Color.CornflowerBlue;
            lblClockMinutes.Location = new Point(413, 47);
            lblClockMinutes.Name = "lblClockMinutes";
            lblClockMinutes.Size = new Size(370, 287);
            lblClockMinutes.TabIndex = 10;
            lblClockMinutes.Text = "00";
            // 
            // lblClockSeconds
            // 
            lblClockSeconds.AutoSize = true;
            lblClockSeconds.BackColor = Color.Transparent;
            lblClockSeconds.Font = new Font("Segoe UI", 130F, FontStyle.Bold);
            lblClockSeconds.ForeColor = Color.CornflowerBlue;
            lblClockSeconds.Location = new Point(827, 47);
            lblClockSeconds.Name = "lblClockSeconds";
            lblClockSeconds.Size = new Size(370, 287);
            lblClockSeconds.TabIndex = 11;
            lblClockSeconds.Text = "00";
            // 
            // txtHours
            // 
            txtHours.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHours.ForeColor = SystemColors.WindowText;
            txtHours.Location = new Point(544, 381);
            txtHours.Margin = new Padding(3, 4, 3, 4);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(57, 43);
            txtHours.TabIndex = 12;
            txtHours.Text = "00";
            txtHours.TextAlign = HorizontalAlignment.Center;
            txtHours.TextChanged += txtHours_TextChanged;
            // 
            // txtMinutes
            // 
            txtMinutes.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMinutes.ForeColor = SystemColors.WindowText;
            txtMinutes.Location = new Point(624, 381);
            txtMinutes.Margin = new Padding(3, 4, 3, 4);
            txtMinutes.Name = "txtMinutes";
            txtMinutes.Size = new Size(57, 43);
            txtMinutes.TabIndex = 13;
            txtMinutes.Text = "00";
            txtMinutes.TextAlign = HorizontalAlignment.Center;
            txtMinutes.TextChanged += txtMinutes_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(605, 387);
            label3.Name = "label3";
            label3.Size = new Size(19, 32);
            label3.TabIndex = 14;
            label3.Text = ":";
            // 
            // btOn
            // 
            btOn.BackColor = Color.Red;
            btOn.Font = new Font("Segoe UI", 20F);
            btOn.Location = new Point(1008, 23);
            btOn.Margin = new Padding(3, 4, 3, 4);
            btOn.Name = "btOn";
            btOn.Size = new Size(167, 57);
            btOn.TabIndex = 15;
            btOn.Text = "off";
            btOn.UseVisualStyleBackColor = false;
            btOn.Click += btOn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1197, 500);
            Controls.Add(btOn);
            Controls.Add(label3);
            Controls.Add(txtMinutes);
            Controls.Add(txtHours);
            Controls.Add(lblClockSeconds);
            Controls.Add(lblClockMinutes);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblClockHours);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Alarm Clock";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private System.Windows.Forms.Timer timerClock;
        private Label label2;
        private Label lblClockHours;
        private Label lblClockMinutes;
        private Label lblClockSeconds;
        private Label lblClock;
        private Label lblSeconds;
        private TextBox txtHours;
        private TextBox txtMinutes;
        private Label label3;
        private Button btOn;
    }
}