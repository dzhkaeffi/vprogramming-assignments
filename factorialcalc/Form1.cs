namespace factorialcalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float factorial = 1f;
        private void calculate_button_Click(object sender, EventArgs e)
        {
            factorial = 1f;
            float original_number = float.Parse(input_textbox.Text);
            for (float i = 1f; i <= original_number; i++)
            {
                factorial *= i;
            }
            result_label.Text = $"{original_number}! = {factorial}";
        }

        private void enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculate_button_Click(sender, e);
            }
        }
    }
}