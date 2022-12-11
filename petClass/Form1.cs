namespace petClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void go_button_Click(object sender, EventArgs e)
        {
            string[] disc = classdisc_txtbox.Text.Split(",");
            Pet pet = new Pet(disc[0], disc[1], int.Parse(disc[2]));
            name_label.Text = "Name: " + pet.name;
            type_label.Text = "Type: " + pet.type;
            age_label.Text = "Age: " + pet.age.ToString();
        }
    }
    class Pet
    {
        public string name;
        public string type;
        public int age;

        public Pet(string name, string type, int age)
        {
            this.name = name;
            this.type = type;
            this.age = age;
        }
    }
}