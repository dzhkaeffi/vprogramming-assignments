namespace namesearch
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
        private void InitializeComponent()
        {
            this.textbox = new System.Windows.Forms.TextBox();
            this.undertxt_label = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.popular_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(12, 27);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(121, 23);
            this.textbox.TabIndex = 0;
            // 
            // undertxt_label
            // 
            this.undertxt_label.AutoSize = true;
            this.undertxt_label.Location = new System.Drawing.Point(12, 9);
            this.undertxt_label.Name = "undertxt_label";
            this.undertxt_label.Size = new System.Drawing.Size(121, 15);
            this.undertxt_label.TabIndex = 1;
            this.undertxt_label.Text = "Search the name here";
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(12, 56);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(121, 23);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // popular_label
            // 
            this.popular_label.Location = new System.Drawing.Point(141, 9);
            this.popular_label.Name = "popular_label";
            this.popular_label.Size = new System.Drawing.Size(100, 70);
            this.popular_label.TabIndex = 3;
            this.popular_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 90);
            this.Controls.Add(this.popular_label);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.undertxt_label);
            this.Controls.Add(this.textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textbox;
        private Label undertxt_label;
        private Button search_button;
        private Label popular_label;
    }
}