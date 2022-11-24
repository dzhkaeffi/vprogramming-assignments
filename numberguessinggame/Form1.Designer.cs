namespace numberguessinggame
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
            this.input_textbox = new System.Windows.Forms.TextBox();
            this.makeguess_btn = new System.Windows.Forms.Button();
            this.toplabel = new System.Windows.Forms.Label();
            this.cheatmode_btn = new System.Windows.Forms.Button();
            this.cheatmode_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input_textbox
            // 
            this.input_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input_textbox.Location = new System.Drawing.Point(270, 102);
            this.input_textbox.MaxLength = 3;
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.PlaceholderText = "Guess";
            this.input_textbox.Size = new System.Drawing.Size(100, 27);
            this.input_textbox.TabIndex = 0;
            this.input_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_textbox_KeyDown);
            // 
            // makeguess_btn
            // 
            this.makeguess_btn.Location = new System.Drawing.Point(270, 135);
            this.makeguess_btn.Name = "makeguess_btn";
            this.makeguess_btn.Size = new System.Drawing.Size(100, 50);
            this.makeguess_btn.TabIndex = 1;
            this.makeguess_btn.Text = "make a guess";
            this.makeguess_btn.UseVisualStyleBackColor = true;
            this.makeguess_btn.Click += new System.EventHandler(this.makeguess_btn_Click);
            // 
            // toplabel
            // 
            this.toplabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toplabel.Location = new System.Drawing.Point(0, 0);
            this.toplabel.Name = "toplabel";
            this.toplabel.Size = new System.Drawing.Size(382, 20);
            this.toplabel.TabIndex = 2;
            this.toplabel.Text = "Try to guess the random number between 1-100";
            this.toplabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cheatmode_btn
            // 
            this.cheatmode_btn.Location = new System.Drawing.Point(12, 161);
            this.cheatmode_btn.Name = "cheatmode_btn";
            this.cheatmode_btn.Size = new System.Drawing.Size(29, 29);
            this.cheatmode_btn.TabIndex = 3;
            this.cheatmode_btn.Text = "C";
            this.cheatmode_btn.UseVisualStyleBackColor = true;
            this.cheatmode_btn.Click += new System.EventHandler(this.cheatmode_btn_Click);
            // 
            // cheatmode_label
            // 
            this.cheatmode_label.AutoSize = true;
            this.cheatmode_label.Location = new System.Drawing.Point(47, 165);
            this.cheatmode_label.Name = "cheatmode_label";
            this.cheatmode_label.Size = new System.Drawing.Size(140, 20);
            this.cheatmode_label.TabIndex = 4;
            this.cheatmode_label.Text = "Toggle Cheat Mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 202);
            this.Controls.Add(this.cheatmode_label);
            this.Controls.Add(this.cheatmode_btn);
            this.Controls.Add(this.toplabel);
            this.Controls.Add(this.makeguess_btn);
            this.Controls.Add(this.input_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox input_textbox;
        private Button makeguess_btn;
        private Label toplabel;
        private Button cheatmode_btn;
        private Label cheatmode_label;
    }
}