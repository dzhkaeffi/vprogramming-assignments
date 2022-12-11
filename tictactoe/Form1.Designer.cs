namespace tictactoe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.new_game = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.playerOScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playerXScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(766, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 345);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.exitBtn);
            this.panel5.Controls.Add(this.resetBtn);
            this.panel5.Controls.Add(this.new_game);
            this.panel5.Location = new System.Drawing.Point(386, 182);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(375, 148);
            this.panel5.TabIndex = 2;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.Location = new System.Drawing.Point(195, 79);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(173, 62);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetBtn.Location = new System.Drawing.Point(3, 79);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(176, 62);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // new_game
            // 
            this.new_game.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.new_game.Location = new System.Drawing.Point(3, 2);
            this.new_game.Name = "new_game";
            this.new_game.Size = new System.Drawing.Size(365, 71);
            this.new_game.TabIndex = 0;
            this.new_game.Text = "New Game";
            this.new_game.UseVisualStyleBackColor = true;
            this.new_game.Click += new System.EventHandler(this.new_game_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.playerOScore);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.playerXScore);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(386, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 168);
            this.panel4.TabIndex = 1;
            // 
            // playerOScore
            // 
            this.playerOScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerOScore.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerOScore.Location = new System.Drawing.Point(185, 92);
            this.playerOScore.Name = "playerOScore";
            this.playerOScore.Size = new System.Drawing.Size(169, 47);
            this.playerOScore.TabIndex = 0;
            this.playerOScore.Text = "0";
            this.playerOScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 47);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player O:";
            // 
            // playerXScore
            // 
            this.playerXScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerXScore.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerXScore.Location = new System.Drawing.Point(185, 23);
            this.playerXScore.Name = "playerXScore";
            this.playerXScore.Size = new System.Drawing.Size(165, 47);
            this.playerXScore.TabIndex = 0;
            this.playerXScore.Text = "0";
            this.playerXScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 47);
            this.label2.TabIndex = 0;
            this.label2.Text = "Player X:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btn9);
            this.panel3.Controls.Add(this.btn6);
            this.panel3.Controls.Add(this.btn3);
            this.panel3.Controls.Add(this.btn8);
            this.panel3.Controls.Add(this.btn7);
            this.panel3.Controls.Add(this.btn5);
            this.panel3.Controls.Add(this.btn4);
            this.panel3.Controls.Add(this.btn2);
            this.panel3.Controls.Add(this.btn1);
            this.panel3.Location = new System.Drawing.Point(12, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 322);
            this.panel3.TabIndex = 0;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Ivory;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(242, 212);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(108, 98);
            this.btn9.TabIndex = 0;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Ivory;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(242, 111);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(108, 96);
            this.btn6.TabIndex = 0;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Ivory;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(242, 7);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(108, 98);
            this.btn3.TabIndex = 0;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Ivory;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(123, 212);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(108, 98);
            this.btn8.TabIndex = 0;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Ivory;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(4, 212);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(108, 98);
            this.btn7.TabIndex = 0;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Ivory;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(123, 111);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(108, 96);
            this.btn5.TabIndex = 0;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Ivory;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(4, 111);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(108, 96);
            this.btn4.TabIndex = 0;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Ivory;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(123, 7);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(108, 98);
            this.btn2.TabIndex = 0;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Ivory;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(4, 7);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(108, 98);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel5;
        private Button exitBtn;
        private Button resetBtn;
        private Button new_game;
        private Panel panel4;
        private Label playerOScore;
        private Label label3;
        private Label playerXScore;
        private Label label2;
        private Panel panel3;
        private Button btn9;
        private Button btn6;
        private Button btn3;
        private Button btn8;
        private Button btn7;
        private Button btn5;
        private Button btn4;
        private Button btn2;
        private Button btn1;
    }
}