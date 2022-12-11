namespace petClass
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
            this.classdisc_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.go_button = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // classdisc_txtbox
            // 
            this.classdisc_txtbox.Location = new System.Drawing.Point(12, 37);
            this.classdisc_txtbox.Name = "classdisc_txtbox";
            this.classdisc_txtbox.Size = new System.Drawing.Size(153, 23);
            this.classdisc_txtbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name, Type, Age";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // go_button
            // 
            this.go_button.Location = new System.Drawing.Point(171, 37);
            this.go_button.Name = "go_button";
            this.go_button.Size = new System.Drawing.Size(32, 23);
            this.go_button.TabIndex = 2;
            this.go_button.Text = "go";
            this.go_button.UseVisualStyleBackColor = true;
            this.go_button.Click += new System.EventHandler(this.go_button_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(15, 73);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(42, 15);
            this.name_label.TabIndex = 3;
            this.name_label.Text = "Name:";
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Location = new System.Drawing.Point(15, 97);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(34, 15);
            this.type_label.TabIndex = 3;
            this.type_label.Text = "Type:";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Location = new System.Drawing.Point(15, 122);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(31, 15);
            this.age_label.TabIndex = 3;
            this.age_label.Text = "Age:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 206);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.type_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.go_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classdisc_txtbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox classdisc_txtbox;
        private Label label1;
        private Button go_button;
        private Label name_label;
        private Label type_label;
        private Label age_label;
    }
}