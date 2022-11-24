namespace bmicalculator
{
    public partial class Form1 : Form
    {
        float BMIValue;
        public Form1()
        {
            InitializeComponent();
        }
        private void setBMIStatus()
        {
            string[] statuses =
            {
                "underweight", "normal", "overweight"
            };
            if (BMIValue < 18.5f)
            {
                status_label.Text = $"Status: {statuses[0]}";
            }
            else if (BMIValue >= 18.5f && BMIValue <= 25f)
            {
                status_label.Text = $"Status: {statuses[1]}";
            }
            else
            {
                status_label.Text = $"Status: {statuses[2]}";
            }
        }
        private void calculate_button_Click(object sender, EventArgs e)
        {
            BMIValue = float.Parse(weight_textbox.Text) / MathF.Pow(float.Parse(height_textbox.Text) / 100, 2f);
            BMIValue = MathF.Round(BMIValue, 1);
            bmi_label.Text = $"BMI: {BMIValue}";
            setBMIStatus();
        }

        private void weight_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculate_button_Click(sender, e);
            }
        }

        private void height_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculate_button_Click(sender, e);
            }
        }
    }
}