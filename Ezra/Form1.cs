using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;

namespace Ezra
{
    public partial class Form1 : Form
    {
        string state = "None";
        public Form1()
        {
            InitializeComponent();
            AddChat("��� �� ��� ��������", Color.Black);
        }


        private void AddChat(string text, Color chat_color)
        {
            Label lblChat = new Label();
            lblChat.Text = text;
            lblChat.AutoSize = true;
            Font ChantFont = new Font("Segoe UI", 10, FontStyle.Bold);
            lblChat.Font = ChantFont;
            lblChat.ForeColor = chat_color;
            flpChat.Controls.Add(lblChat);
            flpChat.ScrollControlIntoView(lblChat);
        }
        private void playGame(string text)
        {
            tbText.Text = "";
            AddChat(text, Color.DarkGreen);
            if (text == "1")
            {
                string path = @"Data\Projects\new_Project\new_Project\bin\Debug\net7.0-windows\new_Project.exe";
                Process.Start(path);
            }
            else if (text == "2")
            {
                string path = @"Data\Projects\Experience_success\Experience_success\bin\Debug\net7.0-windows\Experience_success.exe";
                Process.Start(path);
            }
            else
            {
                AddChat("�� �����, ���� ����", Color.Black);
            }
        }
        private void playMusic(string text)
        {
            btSend.Text = "";
            AddChat(text, Color.DarkGreen);
            if (text == "1")
            {
                Launcher.DisplayUrl("www.youtube.com/watch?v=pVaeEK1WC2M");
            }
            else if (text == "2")
            {
                Launcher.DisplayUrl("www.youtube.com/watch?v=7QVy2zLIjjI");
            }
            else if (text == "3")
            {
                Launcher.DisplayUrl("www.youtube.com/watch?v=9wisDecF8vU");
            }
            else
            {
                AddChat("�� ����. ����� �� ���� ���� �����", Color.Black);
            }
        }
        private void playRemind(string text)
        {
            string[] remind_array = text.Split(' ');
            string date = remind_array[0];
            string time = remind_array[1];
            string remindText = remind_array[2];
            for (int i = 3; i<remind_array.Length; i++)
            {
                remindText = remindText + " " + remind_array[i];
            }
            
            AddChat("����� �� ������ " + date + " ���� " + time + " �� ������: " + remindText, Color.Black);
        }
        
        
        private void btWake_Click(object sender, EventArgs e)
        {
            state = "Wake";
            AddChat(btWake.Text.ToString(), Color.DarkGreen);
            string path = @"Data\Projects\Clock\bin\Debug\net7.0-windows\AlarmClock.exe";
            Process.Start(path);
        }
        private void btGame_Click(object sender, EventArgs e)
        {
            state = "Game";
            AddChat(btGame.Text.ToString(), Color.DarkGreen);
            AddChat("��� ���� ����?\n1 - ����� ���\n2 - ���� �� �����", Color.Black);
        }
        private void btMusic_Click(object sender, EventArgs e)
        {
            state = "Music";
            AddChat(btMusic.Text.ToString(), Color.DarkGreen);
            AddChat("�� ���� �����?\n1 - ��� ���\n2 - ������\n3 - ����� �� ����� ����", Color.Black);

        }
        private void btRemind_Click(object sender, EventArgs e)
        {
            state = "Remind";
            AddChat("������ ������ ������ ���:\n15/09/2023 19:00 ����� ��", Color.Black);
        }


        private void btSend_Click(object sender, EventArgs e)
        {
            if (state == "Game")
            {
                playGame(tbText.Text.ToString());
            }
            if (state == "Music")
            {
                playMusic(tbText.Text.ToString());
            }
            if (state == "Remind")
            {
                playRemind(tbText.Text.ToString());
            }
        }
    }
}