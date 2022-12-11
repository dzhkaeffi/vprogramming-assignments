namespace tictactoe
{
    public partial class Form1 : Form
    {
        bool checker;
        int plusone;

        public void Enable_false()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }
        public void Score()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                btn1.BackColor = Color.PowderBlue;
                btn2.BackColor = Color.PowderBlue;
                btn3.BackColor = Color.PowderBlue
                ; MessageBox.Show("The Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerXScore.Text)+ 1;
                playerXScore.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                btn4.BackColor = Color.PowderBlue;
                btn5.BackColor = Color.PowderBlue;
                btn6.BackColor = Color.PowderBlue
                ; MessageBox.Show("The Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerXScore.Text)+ 1;
                playerXScore.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                btn7.BackColor = Color.PowderBlue;
                btn8.BackColor = Color.PowderBlue;
                btn9.BackColor = Color.PowderBlue
                ; MessageBox.Show("The Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerXScore.Text)+ 1;
                playerXScore.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                btn1.BackColor = Color.PowderBlue;
                btn4.BackColor = Color.PowderBlue;
                btn7.BackColor = Color.PowderBlue
                ; MessageBox.Show("The Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerXScore.Text)+ 1;
                playerXScore.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                btn2.BackColor = Color.PowderBlue;
                btn5.BackColor = Color.PowderBlue;
                btn8.BackColor = Color.PowderBlue
                ; MessageBox.Show("The Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerXScore.Text)+ 1;
                playerXScore.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                btn3.BackColor = Color.PowderBlue;
                btn6.BackColor = Color.PowderBlue;
                btn9.BackColor = Color.PowderBlue
                ; MessageBox.Show("The Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerXScore.Text)+ 1;
                playerXScore.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                btn1.BackColor = Color.PowderBlue;
                btn5.BackColor = Color.PowderBlue;
                btn9.BackColor = Color.PowderBlue
                ; MessageBox.Show("The Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerXScore.Text)+ 1;
                playerXScore.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                btn3.BackColor = Color.PowderBlue;
                btn5.BackColor = Color.PowderBlue;
                btn7.BackColor = Color.PowderBlue
                ; MessageBox.Show("The Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerXScore.Text) + 1;
                playerXScore.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                btn1.BackColor = Color.PowderBlue;
                btn2.BackColor = Color.PowderBlue;
                btn3.BackColor = Color.PowderBlue
                ; MessageBox.Show("The Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerOScore.Text)+ 1;
                playerOScore.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                btn4.BackColor = Color.PowderBlue;
                btn5.BackColor = Color.PowderBlue;
                btn6.BackColor = Color.PowderBlue
                ; MessageBox.Show("The Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerOScore.Text)+ 1;
                playerXScore.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                btn7.BackColor = Color.PowderBlue;
                btn8.BackColor = Color.PowderBlue;
                btn9.BackColor = Color.PowderBlue
                ; MessageBox.Show("The Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerOScore.Text)+ 1;
                playerOScore.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                btn1.BackColor = Color.PowderBlue;
                btn4.BackColor = Color.PowderBlue;
                btn7.BackColor = Color.PowderBlue
                ; MessageBox.Show("The Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerOScore.Text)+ 1;
                playerOScore.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                btn2.BackColor = Color.PowderBlue;
                btn5.BackColor = Color.PowderBlue;
                btn8.BackColor = Color.PowderBlue
                ; MessageBox.Show("The Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerOScore.Text)+ 1;
                playerOScore.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                btn3.BackColor = Color.PowderBlue;
                btn6.BackColor = Color.PowderBlue;
                btn9.BackColor = Color.PowderBlue
                ; MessageBox.Show("The Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerOScore.Text)+ 1;
                playerOScore.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                btn1.BackColor = Color.PowderBlue;
                btn5.BackColor = Color.PowderBlue;
                btn9.BackColor = Color.PowderBlue
                ; MessageBox.Show("The Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerOScore.Text)+ 1;
                playerOScore.Text = Convert.ToString(plusone);
                Enable_false();
            }
            if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                btn3.BackColor = Color.PowderBlue;
                btn5.BackColor = Color.PowderBlue;
                btn7.BackColor = Color.PowderBlue
                ; MessageBox.Show("The Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerOScore.Text) + 1;
                playerOScore.Text = Convert.ToString(plusone);
                Enable_false();
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!checker)
            {
                btn1.Text = "X";
                checker = true;
            } else
            {
                btn1.Text = "O";
                checker = false;
            }
            Score();
            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!checker)
            {
                btn2.Text = "X";
                checker = true;
            }
            else
            {
                btn2.Text = "O";
                checker = false;
            }
            Score();
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (!checker)
            {
                btn3.Text = "X";
                checker = true;
            }
            else
            {
                btn3.Text = "O";
                checker = false;
            }
            Score();
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (!checker)
            {
                btn4.Text = "X";
                checker = true;
            }
            else
            {
                btn4.Text = "O";
                checker = false;
            }
            Score();
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (!checker)
            {
                btn5.Text = "X";
                checker = true;
            }
            else
            {
                btn5.Text = "O";
                checker = false;
            }
            Score();
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (!checker)
            {
                btn6.Text = "X";
                checker = true;
            }
            else
            {
                btn6.Text = "O";
                checker = false;
            }
            Score();
            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (!checker)
            {
                btn7.Text = "X";
                checker = true;
            }
            else
            {
                btn7.Text = "O";
                checker = false;
            }
            Score();
            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (!checker)
            {
                btn8.Text = "X";
                checker = true;
            }
            else
            {
                btn8.Text = "O";
                checker = false;
            }
            Score();
            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (!checker)
            {
                btn9.Text = "X";
                checker = true;
            }
            else
            {
                btn9.Text = "O";
                checker = false;
            }
            Score();
            btn9.Enabled = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void reset()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            btn1.BackColor = Color.Ivory;
            btn2.BackColor = Color.Ivory;
            btn3.BackColor = Color.Ivory;
            btn4.BackColor = Color.Ivory;
            btn5.BackColor = Color.Ivory;
            btn6.BackColor = Color.Ivory;
            btn7.BackColor = Color.Ivory;
            btn8.BackColor = Color.Ivory;
            btn9.BackColor = Color.Ivory;
        }
        private void new_game_Click(object sender, EventArgs e)
        {
            reset();
            playerXScore.Text = "0";
            playerOScore.Text = "0";
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}