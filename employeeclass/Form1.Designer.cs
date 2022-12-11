namespace employeeclass
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
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.emp_id_txtbox = new System.Windows.Forms.TextBox();
            this.shift_txtbox = new System.Windows.Forms.TextBox();
            this.payrate_txtbox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.emp_id_label = new System.Windows.Forms.Label();
            this.shift_label = new System.Windows.Forms.Label();
            this.payrate_label = new System.Windows.Forms.Label();
            this.go_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(12, 12);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(100, 23);
            this.name_txtbox.TabIndex = 0;
            // 
            // emp_id_txtbox
            // 
            this.emp_id_txtbox.Location = new System.Drawing.Point(12, 41);
            this.emp_id_txtbox.Name = "emp_id_txtbox";
            this.emp_id_txtbox.Size = new System.Drawing.Size(100, 23);
            this.emp_id_txtbox.TabIndex = 0;
            // 
            // shift_txtbox
            // 
            this.shift_txtbox.Location = new System.Drawing.Point(12, 70);
            this.shift_txtbox.Name = "shift_txtbox";
            this.shift_txtbox.Size = new System.Drawing.Size(100, 23);
            this.shift_txtbox.TabIndex = 0;
            // 
            // payrate_txtbox
            // 
            this.payrate_txtbox.Location = new System.Drawing.Point(12, 99);
            this.payrate_txtbox.Name = "payrate_txtbox";
            this.payrate_txtbox.Size = new System.Drawing.Size(100, 23);
            this.payrate_txtbox.TabIndex = 0;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(118, 15);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(37, 15);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "name";
            // 
            // emp_id_label
            // 
            this.emp_id_label.AutoSize = true;
            this.emp_id_label.Location = new System.Drawing.Point(118, 44);
            this.emp_id_label.Name = "emp_id_label";
            this.emp_id_label.Size = new System.Drawing.Size(46, 15);
            this.emp_id_label.TabIndex = 1;
            this.emp_id_label.Text = "emp_id";
            // 
            // shift_label
            // 
            this.shift_label.AutoSize = true;
            this.shift_label.Location = new System.Drawing.Point(118, 73);
            this.shift_label.Name = "shift_label";
            this.shift_label.Size = new System.Drawing.Size(30, 15);
            this.shift_label.TabIndex = 1;
            this.shift_label.Text = "shift";
            // 
            // payrate_label
            // 
            this.payrate_label.AutoSize = true;
            this.payrate_label.Location = new System.Drawing.Point(118, 102);
            this.payrate_label.Name = "payrate_label";
            this.payrate_label.Size = new System.Drawing.Size(46, 15);
            this.payrate_label.TabIndex = 1;
            this.payrate_label.Text = "payrate";
            // 
            // go_button
            // 
            this.go_button.Location = new System.Drawing.Point(12, 128);
            this.go_button.Name = "go_button";
            this.go_button.Size = new System.Drawing.Size(217, 23);
            this.go_button.TabIndex = 2;
            this.go_button.Text = "GO";
            this.go_button.UseVisualStyleBackColor = true;
            this.go_button.Click += new System.EventHandler(this.go_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 156);
            this.Controls.Add(this.go_button);
            this.Controls.Add(this.payrate_label);
            this.Controls.Add(this.shift_label);
            this.Controls.Add(this.emp_id_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.payrate_txtbox);
            this.Controls.Add(this.shift_txtbox);
            this.Controls.Add(this.emp_id_txtbox);
            this.Controls.Add(this.name_txtbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox name_txtbox;
        private TextBox emp_id_txtbox;
        private TextBox shift_txtbox;
        private TextBox payrate_txtbox;
        private Label name_label;
        private Label emp_id_label;
        private Label shift_label;
        private Label payrate_label;
        private Button go_button;
    }
}