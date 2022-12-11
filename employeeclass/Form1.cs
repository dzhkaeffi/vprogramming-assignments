namespace employeeclass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Employee
        {
            public string? name { get; set; }
            public int emp_id { get; set; }
        }
        class Worker : Employee
        {
            public float payRate { get; set; }
            public Shift Shift { get; set; }
        }
        public enum Shift
        {
            Day = 1,
            Night = 2
        }
        private void go_button_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            worker.name = name_txtbox.Text;
            worker.emp_id = int.Parse(emp_id_txtbox.Text);
            worker.Shift = (Shift)Enum.Parse(typeof(Shift), shift_txtbox.Text);
            worker.payRate = float.Parse(payrate_txtbox.Text);
            name_label.Text = worker.name;
            emp_id_label.Text = worker.emp_id.ToString();
            shift_label.Text = worker.Shift.ToString();
            payrate_label.Text = worker.payRate.ToString();
        }
    }
}