namespace mostfreqchar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                mostfqchar.Text = textBox1.Text.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key.ToString();
            } else
            {
                mostfqchar.Text = "";
            }
        }
    }
}