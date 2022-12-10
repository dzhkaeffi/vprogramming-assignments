namespace rockpaperscissors
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        int computerChoice = rnd.Next(1, 4);
        int userScore = 0;
        int computerScore = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void checkWin(int user)
        {
            switch (user)
            {
                case 1:
                    if (computerChoice == 1)
                    {
                        aichoice.Text = "Computer chose: Rock!";
                        result.Text = "DRAW";
                    }
                    else if (computerChoice == 2)
                    {
                        aichoice.Text = "Computer chose: Paper!";
                        result.Text = "YOU ARE THE LOSER";
                        computerScore += 1;
                    }
                    else if (computerChoice == 3)
                    {
                        aichoice.Text = "Computer chose: Scissors!";
                        result.Text = "YOU ARE THE VICTOR";
                        userScore += 1;
                    }
                    break;
                case 2:
                    if (computerChoice == 1)
                    {
                        aichoice.Text = "Computer chose: Rock!";
                        result.Text = "YOU ARE THE VICTOR";
                        userScore += 1;
                    }
                    else if (computerChoice == 2)
                    {
                        aichoice.Text = "Computer chose: Paper!";
                        result.Text = "DRAW";
                    }
                    else if (computerChoice == 3)
                    {
                        aichoice.Text = "Computer chose: Scissors!";
                        result.Text = "YOU ARE THE LOSER";
                        computerScore += 1;
                    }
                    break;
                case 3:
                    if (computerChoice == 1)
                    {
                        aichoice.Text = "Computer chose: Rock!";
                        result.Text = "YOU ARE THE LOSER";
                        computerScore += 1;
                    }
                    else if (computerChoice == 2)
                    {
                        aichoice.Text = "Computer chose: Paper!";
                        result.Text = "YOU ARE THE VICTOR";
                        userScore += 1;
                    }
                    else if (computerChoice == 3)
                    {
                        aichoice.Text = "Computer chose: Scissors!";
                        result.Text = "DRAW";
                    }
                    break;
            }
            if (userScore == 3)
            {
                victor_label.Text = "YOU ARE THE REAL VICTOR";
                victor_label.Visible = true;
                rockimg.Visible = false;
                paperimg.Visible = false;
                sciimg.Visible = false;
                aichoice.Visible = false;
                result.Visible = false;
                wait(1000);
                this.Close();
            }
            else if (computerScore == 3)
            {
                victor_label.Text = "YOU ARE THE REAL LOSER";
                victor_label.Visible = true;
                rockimg.Visible = false;
                paperimg.Visible = false;
                sciimg.Visible = false;
                aichoice.Visible = false;
                result.Visible = false;
                wait(1000);
                this.Close();
            }
        }

        private void rockimg_Click(object sender, EventArgs e)
        {
            checkWin(1);
            computerChoice = rnd.Next(1, 4);
        }

        private void paperimg_Click(object sender, EventArgs e)
        {
            checkWin(2);
            computerChoice = rnd.Next(1, 4);
        }

        private void sciimg_Click(object sender, EventArgs e)
        {
            checkWin(3);
            computerChoice = rnd.Next(1, 4);
        }
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}