using System.CodeDom;
using System.Data;
using static System.Net.WebRequestMethods;

namespace Experience_success
{
    public partial class MainForm : Form
    {
        CsvDataset csv = new CsvDataset();
        DataTable dt = null;
        string character;
        int guessedNumber;
        int rowChar;
        public MainForm()
        {
            InitializeComponent();
            guessedNumber = 0;
            lblHowMuchGuess.Text = "נותרו " + (10 - guessedNumber) + " שאלות מתוך 10";
            dt = csv.Read(@"Data\game_dataset.csv");
            // insert characters to character list from csv
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listUnguessedChar.Items.Add(dt.Rows[i]["דמות"].ToString());
            }
            // insert quastions to quastions list from csv
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                listQuestions.Items.Add(dt.Columns[i].ColumnName);
            }
            Random MyNumber = new Random();
            rowChar = MyNumber.Next(0, listUnguessedChar.Items.Count);
            //choose random character
            character = listUnguessedChar.Items[rowChar].ToString();
        }
        private void listQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listQuestions.SelectedItem != null)
            {
                //you lose
                if (guessedNumber == 10)
                {
                    MessageBox.Show("די. נגמרו הניחושים חבר. הפסדת");
                    Application.Restart();
                }
                guessedNumber++;
                lblHowMuchGuess.Text = "נותרו " + (10 - guessedNumber) + " שאלות מתוך 10";
                //update guested quastions with color and shit
                Label lblQustion = new Label();
                lblQustion.Text = listQuestions.SelectedItem.ToString();
                lblQustion.RightToLeft = RightToLeft.Yes;
                lblQustion.AutoSize = true;
                flpQustions.Controls.Add(lblQustion);
                Label lblAnswer = new Label();
                string answer;
                answer = dt.Rows[rowChar][listQuestions.SelectedItem.ToString()].ToString();
                if (answer == "V")
                {
                    lblAnswer.Text = "כן";
                    lblAnswer.ForeColor = Color.Green;
                }
                else
                {
                    lblAnswer.Text = "לא";
                    lblAnswer.ForeColor = Color.Red;
                }
                flpQustions.Controls.Add(lblAnswer);
                flpQustions.ScrollControlIntoView(lblAnswer);
            }
        }
        private void listUnguessedChar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update guested characters
            if (listUnguessedChar.SelectedItem != null)
            {
                listGuessedChar.Items.Add(listUnguessedChar.SelectedItem);
                listUnguessedChar.Items.Remove(listUnguessedChar.SelectedItem);
            }
        }
        private void listGuessedChar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update unguested characters
            if (listGuessedChar.SelectedItem != null)
            {
                listUnguessedChar.Items.Add(listGuessedChar.SelectedItem);
                listGuessedChar.Items.Remove(listGuessedChar.SelectedItem);
            }
        }
        private void btCheck_Click(object sender, EventArgs e)
        {
            if (tbGuess.Text == character)
            {
                MessageBox.Show("הידד ! הצלחת!");
            }
            else
            {
                MessageBox.Show("ניחוש לא מוצלח. לא נורא חבוב, פעם הבא");
                MessageBox.Show("הדמות הייתה " + character);
                Application.Restart();
            }
            //Application.Exit();
        }

        private void btNewGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}