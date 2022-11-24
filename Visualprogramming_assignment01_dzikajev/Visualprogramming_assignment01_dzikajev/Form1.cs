using System.Windows.Forms;

namespace Visualprogramming_assignment01_dzikajev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void exit_button_MouseHover(object sender, EventArgs e)
        {
            exit_button.Text = "You sure?";
        }

        private void exit_button_MouseLeave(object sender, EventArgs e)
        {
            exit_button.Text = "Exit";
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye, Bye!");
            this.Close();
        }

        private void ace_of_spades_Click(object sender, EventArgs e)
        {
            card_info_label.Text = "Ace Of Spades";
            ace_of_spades.BorderStyle = BorderStyle.Fixed3D;
            ace_of_clubs.BorderStyle = BorderStyle.None;
            ace_of_diamonds.BorderStyle = BorderStyle.None;
            ace_of_hearts.BorderStyle = BorderStyle.None;
        }

        private void ace_of_hearts_Click(object sender, EventArgs e)
        {
            card_info_label.Text = "Ace Of Hearts";
            ace_of_spades.BorderStyle = BorderStyle.None;
            ace_of_clubs.BorderStyle = BorderStyle.None;
            ace_of_diamonds.BorderStyle = BorderStyle.None;
            ace_of_hearts.BorderStyle = BorderStyle.Fixed3D;
        }

        private void ace_of_diamonds_Click(object sender, EventArgs e)
        {
            card_info_label.Text = "Ace Of Diamonds";
            ace_of_spades.BorderStyle = BorderStyle.None;
            ace_of_clubs.BorderStyle = BorderStyle.None;
            ace_of_diamonds.BorderStyle = BorderStyle.Fixed3D;
            ace_of_hearts.BorderStyle = BorderStyle.None;
        }

        private void ace_of_clubs_Click(object sender, EventArgs e)
        {
            card_info_label.Text = "Ace Of Clubs";
            ace_of_spades.BorderStyle = BorderStyle.None;
            ace_of_clubs.BorderStyle = BorderStyle.Fixed3D;
            ace_of_diamonds.BorderStyle = BorderStyle.None;
            ace_of_hearts.BorderStyle = BorderStyle.None;
        }
    }   
}