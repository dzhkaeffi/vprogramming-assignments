using System.Globalization;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            if (this.amount_a.Text.Length == 0){
                this.amount_a.Text = 0.ToString();
            }
            if (this.amount_b.Text.Length == 0)
            {
                this.amount_b.Text = 0.ToString();
            }
            if (this.amount_c.Text.Length == 0)
            {
                this.amount_c.Text = 0.ToString();
            }
            if (this.amount_a.Text.Length > 0)
            {
                result_a.Text = (Int64.Parse(amount_a.Text) * 15).ToString("C");
            }
            else
            {
                result_a.Text = "0.00€";
            }
            if (this.amount_b.Text.Length > 0)
            {
                result_b.Text = (Int64.Parse(amount_b.Text) * 12).ToString("C");
            }
            else
            {
                result_b.Text = "0.00€";
            }
            if (this.amount_c.Text.Length > 0)
            {
                result_c.Text = (Int64.Parse(amount_c.Text) * 9).ToString("C");
            }
            else
            {
                result_c.Text = "0.00€";
            }
            try
            {
                long a_rev = long.Parse(amount_a.Text) * 15;
                long b_rev = long.Parse(amount_b.Text) * 12;
                long c_rev = long.Parse(amount_c.Text) * 9;
                total.Text = (a_rev+b_rev+c_rev).ToString("C");
            } catch
            {
                total.Text = 0.ToString("C");
            }
        }


        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            amount_a.Text = null;
            result_a.Text = null;
            amount_b.Text = null;
            result_b.Text = null;
            amount_c.Text = null;
            result_c.Text = null;
            total.Text = null;
        }
    }
}