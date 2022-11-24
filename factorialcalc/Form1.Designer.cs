namespace factorialcalc
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
            this.calculate_button = new System.Windows.Forms.Button();
            this.result_label = new System.Windows.Forms.Label();
            this.input_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(212, 63);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(94, 25);
            this.calculate_button.TabIndex = 0;
            this.calculate_button.Text = "calculate";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(12, 65);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(58, 20);
            this.result_label.TabIndex = 1;
            this.result_label.Text = "X! = ---";
            // 
            // input_textbox
            // 
            this.input_textbox.Location = new System.Drawing.Point(94, 10);
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.PlaceholderText = "input a number";
            this.input_textbox.Size = new System.Drawing.Size(125, 27);
            this.input_textbox.TabIndex = 2;
            this.input_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 95);
            this.Controls.Add(this.input_textbox);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.calculate_button);
            this.Name = "Form1";
            this.Text = "Factorial Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button calculate_button;
        private Label result_label;
        private TextBox input_textbox;
    }
}