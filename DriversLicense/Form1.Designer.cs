namespace DriversLicense
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
            this.select_file = new System.Windows.Forms.Button();
            this.openfile = new System.Windows.Forms.OpenFileDialog();
            this.yourresult = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.incorrect_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // select_file
            // 
            this.select_file.Location = new System.Drawing.Point(262, 88);
            this.select_file.Name = "select_file";
            this.select_file.Size = new System.Drawing.Size(75, 23);
            this.select_file.TabIndex = 0;
            this.select_file.Text = "Select file";
            this.select_file.Click += new System.EventHandler(this.select_file_Click);
            // 
            // openfile
            // 
            this.openfile.FileName = "answers";
            this.openfile.Filter = "Text files (*.txt)|*.txt";
            this.openfile.Title = "Select a text file";
            // 
            // yourresult
            // 
            this.yourresult.AutoSize = true;
            this.yourresult.Location = new System.Drawing.Point(12, 9);
            this.yourresult.Name = "yourresult";
            this.yourresult.Size = new System.Drawing.Size(0, 15);
            this.yourresult.TabIndex = 1;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(12, 92);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(22, 15);
            this.result.TabIndex = 2;
            this.result.Text = "0:0";
            // 
            // incorrect_text
            // 
            this.incorrect_text.AutoSize = true;
            this.incorrect_text.Location = new System.Drawing.Point(19, 53);
            this.incorrect_text.Name = "incorrect_text";
            this.incorrect_text.Size = new System.Drawing.Size(0, 15);
            this.incorrect_text.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 123);
            this.Controls.Add(this.incorrect_text);
            this.Controls.Add(this.result);
            this.Controls.Add(this.yourresult);
            this.Controls.Add(this.select_file);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button select_file;
        private OpenFileDialog openfile;
        private Label yourresult;
        private Label result;
        private Label incorrect_text;
    }
}