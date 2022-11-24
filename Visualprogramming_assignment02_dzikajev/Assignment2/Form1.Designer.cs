namespace Assignment2
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
            this.button1 = new System.Windows.Forms.Button();
            this.ticketsSold = new System.Windows.Forms.GroupBox();
            this.amount_c = new System.Windows.Forms.TextBox();
            this.amount_b = new System.Windows.Forms.TextBox();
            this.amount_a = new System.Windows.Forms.TextBox();
            this.classC = new System.Windows.Forms.Label();
            this.classB = new System.Windows.Forms.Label();
            this.classA = new System.Windows.Forms.Label();
            this.info_text = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.result_c = new System.Windows.Forms.TextBox();
            this.result_b = new System.Windows.Forms.TextBox();
            this.result_a = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculate_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.ticketsSold.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ticketsSold
            // 
            this.ticketsSold.Controls.Add(this.amount_c);
            this.ticketsSold.Controls.Add(this.amount_b);
            this.ticketsSold.Controls.Add(this.amount_a);
            this.ticketsSold.Controls.Add(this.classC);
            this.ticketsSold.Controls.Add(this.classB);
            this.ticketsSold.Controls.Add(this.classA);
            this.ticketsSold.Controls.Add(this.info_text);
            this.ticketsSold.Location = new System.Drawing.Point(12, 12);
            this.ticketsSold.Name = "ticketsSold";
            this.ticketsSold.Size = new System.Drawing.Size(200, 261);
            this.ticketsSold.TabIndex = 1;
            this.ticketsSold.TabStop = false;
            this.ticketsSold.Text = "Tickets Sold";
            // 
            // amount_c
            // 
            this.amount_c.Location = new System.Drawing.Point(77, 153);
            this.amount_c.Name = "amount_c";
            this.amount_c.Size = new System.Drawing.Size(100, 23);
            this.amount_c.TabIndex = 6;
            // 
            // amount_b
            // 
            this.amount_b.Location = new System.Drawing.Point(77, 124);
            this.amount_b.Name = "amount_b";
            this.amount_b.Size = new System.Drawing.Size(100, 23);
            this.amount_b.TabIndex = 5;
            // 
            // amount_a
            // 
            this.amount_a.Location = new System.Drawing.Point(78, 97);
            this.amount_a.Name = "amount_a";
            this.amount_a.Size = new System.Drawing.Size(100, 23);
            this.amount_a.TabIndex = 4;
            // 
            // classC
            // 
            this.classC.AutoSize = true;
            this.classC.Location = new System.Drawing.Point(27, 156);
            this.classC.Name = "classC";
            this.classC.Size = new System.Drawing.Size(45, 15);
            this.classC.TabIndex = 3;
            this.classC.Text = "Class C";
            // 
            // classB
            // 
            this.classB.AutoSize = true;
            this.classB.Location = new System.Drawing.Point(27, 127);
            this.classB.Name = "classB";
            this.classB.Size = new System.Drawing.Size(44, 15);
            this.classB.TabIndex = 2;
            this.classB.Text = "Class B";
            // 
            // classA
            // 
            this.classA.AutoSize = true;
            this.classA.Location = new System.Drawing.Point(27, 100);
            this.classA.Name = "classA";
            this.classA.Size = new System.Drawing.Size(45, 15);
            this.classA.TabIndex = 1;
            this.classA.Text = "Class A";
            // 
            // info_text
            // 
            this.info_text.Location = new System.Drawing.Point(6, 19);
            this.info_text.Name = "info_text";
            this.info_text.Size = new System.Drawing.Size(180, 33);
            this.info_text.TabIndex = 0;
            this.info_text.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.total);
            this.groupBox1.Controls.Add(this.result_c);
            this.groupBox1.Controls.Add(this.result_b);
            this.groupBox1.Controls.Add(this.result_a);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(272, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 158);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Sold";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total:";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(85, 124);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(100, 23);
            this.total.TabIndex = 7;
            // 
            // result_c
            // 
            this.result_c.Location = new System.Drawing.Point(85, 90);
            this.result_c.Name = "result_c";
            this.result_c.ReadOnly = true;
            this.result_c.Size = new System.Drawing.Size(100, 23);
            this.result_c.TabIndex = 6;
            // 
            // result_b
            // 
            this.result_b.Location = new System.Drawing.Point(85, 61);
            this.result_b.Name = "result_b";
            this.result_b.ReadOnly = true;
            this.result_b.Size = new System.Drawing.Size(100, 23);
            this.result_b.TabIndex = 5;
            // 
            // result_a
            // 
            this.result_a.Location = new System.Drawing.Point(85, 34);
            this.result_a.Name = "result_a";
            this.result_a.ReadOnly = true;
            this.result_a.Size = new System.Drawing.Size(100, 23);
            this.result_a.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Class C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Class A";
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(218, 176);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(75, 47);
            this.calculate_button.TabIndex = 8;
            this.calculate_button.Text = "Calculate Revenue";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(316, 247);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 47);
            this.clear_button.TabIndex = 9;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(397, 247);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 47);
            this.exit_button.TabIndex = 10;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 306);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ticketsSold);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.ticketsSold.ResumeLayout(false);
            this.ticketsSold.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private GroupBox ticketsSold;
        private TextBox amount_c;
        private TextBox amount_b;
        private TextBox amount_a;
        private Label classC;
        private Label classB;
        private Label classA;
        private Label info_text;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox total;
        private TextBox result_c;
        private TextBox result_b;
        private TextBox result_a;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button calculate_button;
        private Button clear_button;
        private Button exit_button;
    }
}