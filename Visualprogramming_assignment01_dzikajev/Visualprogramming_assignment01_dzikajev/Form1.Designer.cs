namespace Visualprogramming_assignment01_dzikajev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exit_button = new System.Windows.Forms.Button();
            this.top_left_label = new System.Windows.Forms.Label();
            this.card_info_label = new System.Windows.Forms.Label();
            this.ace_of_spades = new System.Windows.Forms.PictureBox();
            this.ace_of_hearts = new System.Windows.Forms.PictureBox();
            this.ace_of_diamonds = new System.Windows.Forms.PictureBox();
            this.ace_of_clubs = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ace_of_spades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ace_of_hearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ace_of_diamonds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ace_of_clubs)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.ForeColor = System.Drawing.Color.Crimson;
            this.exit_button.Location = new System.Drawing.Point(195, 148);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 0;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            this.exit_button.MouseLeave += new System.EventHandler(this.exit_button_MouseLeave);
            this.exit_button.MouseHover += new System.EventHandler(this.exit_button_MouseHover);
            // 
            // top_left_label
            // 
            this.top_left_label.AutoSize = true;
            this.top_left_label.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.top_left_label.Location = new System.Drawing.Point(89, 9);
            this.top_left_label.Name = "top_left_label";
            this.top_left_label.Size = new System.Drawing.Size(100, 15);
            this.top_left_label.TabIndex = 1;
            this.top_left_label.Text = "CLICK ANY CARD";
            // 
            // card_info_label
            // 
            this.card_info_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.card_info_label.ForeColor = System.Drawing.Color.DarkGreen;
            this.card_info_label.Location = new System.Drawing.Point(10, 148);
            this.card_info_label.Name = "card_info_label";
            this.card_info_label.Size = new System.Drawing.Size(179, 23);
            this.card_info_label.TabIndex = 2;
            this.card_info_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ace_of_spades
            // 
            this.ace_of_spades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ace_of_spades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ace_of_spades.Image = ((System.Drawing.Image)(resources.GetObject("ace_of_spades.Image")));
            this.ace_of_spades.Location = new System.Drawing.Point(10, 38);
            this.ace_of_spades.Name = "ace_of_spades";
            this.ace_of_spades.Size = new System.Drawing.Size(60, 85);
            this.ace_of_spades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ace_of_spades.TabIndex = 3;
            this.ace_of_spades.TabStop = false;
            this.ace_of_spades.Click += new System.EventHandler(this.ace_of_spades_Click);
            // 
            // ace_of_hearts
            // 
            this.ace_of_hearts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ace_of_hearts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ace_of_hearts.Image = ((System.Drawing.Image)(resources.GetObject("ace_of_hearts.Image")));
            this.ace_of_hearts.Location = new System.Drawing.Point(76, 38);
            this.ace_of_hearts.Name = "ace_of_hearts";
            this.ace_of_hearts.Size = new System.Drawing.Size(60, 85);
            this.ace_of_hearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ace_of_hearts.TabIndex = 4;
            this.ace_of_hearts.TabStop = false;
            this.ace_of_hearts.Click += new System.EventHandler(this.ace_of_hearts_Click);
            // 
            // ace_of_diamonds
            // 
            this.ace_of_diamonds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ace_of_diamonds.BackColor = System.Drawing.Color.White;
            this.ace_of_diamonds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ace_of_diamonds.Image = ((System.Drawing.Image)(resources.GetObject("ace_of_diamonds.Image")));
            this.ace_of_diamonds.Location = new System.Drawing.Point(142, 38);
            this.ace_of_diamonds.Name = "ace_of_diamonds";
            this.ace_of_diamonds.Size = new System.Drawing.Size(60, 85);
            this.ace_of_diamonds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ace_of_diamonds.TabIndex = 5;
            this.ace_of_diamonds.TabStop = false;
            this.ace_of_diamonds.Click += new System.EventHandler(this.ace_of_diamonds_Click);
            // 
            // ace_of_clubs
            // 
            this.ace_of_clubs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ace_of_clubs.BackColor = System.Drawing.Color.White;
            this.ace_of_clubs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ace_of_clubs.Image = ((System.Drawing.Image)(resources.GetObject("ace_of_clubs.Image")));
            this.ace_of_clubs.Location = new System.Drawing.Point(210, 38);
            this.ace_of_clubs.Name = "ace_of_clubs";
            this.ace_of_clubs.Size = new System.Drawing.Size(60, 85);
            this.ace_of_clubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ace_of_clubs.TabIndex = 6;
            this.ace_of_clubs.TabStop = false;
            this.ace_of_clubs.Click += new System.EventHandler(this.ace_of_clubs_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 179);
            this.Controls.Add(this.ace_of_clubs);
            this.Controls.Add(this.ace_of_diamonds);
            this.Controls.Add(this.ace_of_hearts);
            this.Controls.Add(this.ace_of_spades);
            this.Controls.Add(this.card_info_label);
            this.Controls.Add(this.top_left_label);
            this.Controls.Add(this.exit_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ACES\' NAMES";
            ((System.ComponentModel.ISupportInitialize)(this.ace_of_spades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ace_of_hearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ace_of_diamonds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ace_of_clubs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

}

        #endregion

        private Button exit_button;
        private Label top_left_label;
        private Label card_info_label;
        private PictureBox ace_of_spades;
        private PictureBox ace_of_hearts;
        private PictureBox ace_of_diamonds;
        private PictureBox ace_of_clubs;
    }
}