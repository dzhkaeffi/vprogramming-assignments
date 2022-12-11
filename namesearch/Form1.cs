namespace namesearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] array1 = File.ReadAllLines("X:\\CODING\\VSProjects\\namesearch\\file1.txt");
        string[] array2 = File.ReadAllLines("X:\\CODING\\VSProjects\\namesearch\\file2.txt");
        private void search_button_Click(object sender, EventArgs e)
        {
            bool existsinfirst = Array.Exists(array1, element => element == textbox.Text);
            bool existsinsecond = Array.Exists(array2, element => element == textbox.Text);
            if (existsinfirst)
            {
                popular_label.Text = "The thing was popular amongst file1 things.";
            }
            if (existsinsecond)
            {
                popular_label.Text = "The thing was popular amongst file2 things.";
            }
            if (!existsinfirst && !existsinsecond)
            {
                popular_label.Text = "This was not popular amongst things in file1 and file2";
            }
        }
    }
}