namespace bmicalculator
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
            this.weight_label = new System.Windows.Forms.Label();
            this.height_label = new System.Windows.Forms.Label();
            this.weight_textbox = new System.Windows.Forms.TextBox();
            this.height_textbox = new System.Windows.Forms.TextBox();
            this.calculate_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.status_label = new System.Windows.Forms.Label();
            this.bmi_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // weight_label
            // 
            this.weight_label.AutoSize = true;
            this.weight_label.Location = new System.Drawing.Point(12, 23);
            this.weight_label.Name = "weight_label";
            this.weight_label.Size = new System.Drawing.Size(59, 20);
            this.weight_label.TabIndex = 0;
            this.weight_label.Text = "Weight:";
            // 
            // height_label
            // 
            this.height_label.AutoSize = true;
            this.height_label.Location = new System.Drawing.Point(12, 60);
            this.height_label.Name = "height_label";
            this.height_label.Size = new System.Drawing.Size(57, 20);
            this.height_label.TabIndex = 1;
            this.height_label.Text = "Height:";
            // 
            // weight_textbox
            // 
            this.weight_textbox.Location = new System.Drawing.Point(77, 20);
            this.weight_textbox.Name = "weight_textbox";
            this.weight_textbox.PlaceholderText = "kg";
            this.weight_textbox.Size = new System.Drawing.Size(125, 27);
            this.weight_textbox.TabIndex = 2;
            this.weight_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.weight_textbox_KeyDown);
            // 
            // height_textbox
            // 
            this.height_textbox.Location = new System.Drawing.Point(77, 57);
            this.height_textbox.Name = "height_textbox";
            this.height_textbox.PlaceholderText = "cm";
            this.height_textbox.Size = new System.Drawing.Size(125, 27);
            this.height_textbox.TabIndex = 3;
            this.height_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.height_textbox_KeyDown);
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(208, 18);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(94, 66);
            this.calculate_button.TabIndex = 4;
            this.calculate_button.Text = "Calculate";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.status_label);
            this.panel1.Controls.Add(this.bmi_label);
            this.panel1.Location = new System.Drawing.Point(12, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 104);
            this.panel1.TabIndex = 5;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(11, 65);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(62, 20);
            this.status_label.TabIndex = 7;
            this.status_label.Text = "Status: -";
            // 
            // bmi_label
            // 
            this.bmi_label.AutoSize = true;
            this.bmi_label.Location = new System.Drawing.Point(9, 13);
            this.bmi_label.Name = "bmi_label";
            this.bmi_label.Size = new System.Drawing.Size(48, 20);
            this.bmi_label.TabIndex = 6;
            this.bmi_label.Text = "BMI: -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 217);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.height_textbox);
            this.Controls.Add(this.weight_textbox);
            this.Controls.Add(this.height_label);
            this.Controls.Add(this.weight_label);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label weight_label;
        private Label height_label;
        private TextBox weight_textbox;
        private TextBox height_textbox;
        private Button calculate_button;
        private Panel panel1;
        private Label status_label;
        private Label bmi_label;
    }
}