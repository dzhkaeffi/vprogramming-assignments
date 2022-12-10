using System.Reflection.Emit;
using System.Windows.Forms;

namespace DriversLicense
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] realanswers = { "b", "d", "a", "a", "c", "a", "b", "a", "c", "d", "b", "c", "d", "a", "d", "c", "c", "b", "d", "a" };
        
        private void select_file_Click(object sender, EventArgs e)
        {
            int correctans = 0;
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                var filepath = openfile.FileName;
                string[] answers = File.ReadAllLines(filepath);
                for (int i = 0; i < realanswers.Length; i++)
                {
                    if (answers[i] == realanswers[i])
                    {
                        correctans += 1;
                    }
                    if (answers[i] != realanswers[i])
                    {
                        incorrect_text.Text += i + 1 + " ";
                    }
                }
                if (correctans >= 15)
                {
                    yourresult.Text = "PASSSSSSSSSSSSSSSSSSS";
                }
                else
                {
                    yourresult.Text = "GO LEARN SOME MORE";
                }
                int incorrectans = 20 - correctans;
                result.Text = correctans.ToString() + ":" + incorrectans.ToString();
            }

        }
    }
}