namespace numberguessinggame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Random rand = new Random();
        int rndInt = rand.Next(1,101);
        bool cheatmode = false;

        private void cheatmode_btn_Click(object sender, EventArgs e)
        {
            if (!cheatmode)
            {
                cheatmode = true;
                cheatmode_label.Text = rndInt.ToString();
            } else
            {
                cheatmode = false;
                cheatmode_label.Text = "Toggle Cheat Mode";
            }
        }

        private void makeguess_btn_Click(object sender, EventArgs e)
        {
            int user_guess = int.Parse(input_textbox.Text);
            if (user_guess == rndInt)
            {
                toplabel.Text = "Congratulations! Now again!";
                rndInt = rand.Next(1, 101);
            }
            else if (user_guess > rndInt) { toplabel.Text = "That's too high!"; }
            else if (user_guess < rndInt) { toplabel.Text = "That's too low!"; }
            if (cheatmode)
            {
                cheatmode_label.Text = rndInt.ToString();
            }
        }

        private void input_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                makeguess_btn_Click(sender, e);
            }
        }
    }
}