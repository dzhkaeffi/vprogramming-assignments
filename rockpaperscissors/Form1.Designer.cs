namespace rockpaperscissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rockimg = new System.Windows.Forms.PictureBox();
            this.paperimg = new System.Windows.Forms.PictureBox();
            this.sciimg = new System.Windows.Forms.PictureBox();
            this.aichoice = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.victor_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rockimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sciimg)).BeginInit();
            this.SuspendLayout();
            // 
            // rockimg
            // 
            this.rockimg.BackgroundImage = global::rockpaperscissors.Properties.Resources.rock;
            this.rockimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rockimg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rockimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rockimg.Location = new System.Drawing.Point(11, 119);
            this.rockimg.Name = "rockimg";
            this.rockimg.Size = new System.Drawing.Size(87, 85);
            this.rockimg.TabIndex = 0;
            this.rockimg.TabStop = false;
            this.rockimg.Click += new System.EventHandler(this.rockimg_Click);
            // 
            // paperimg
            // 
            this.paperimg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paperimg.BackgroundImage")));
            this.paperimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paperimg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paperimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paperimg.Location = new System.Drawing.Point(104, 119);
            this.paperimg.Name = "paperimg";
            this.paperimg.Size = new System.Drawing.Size(87, 85);
            this.paperimg.TabIndex = 1;
            this.paperimg.TabStop = false;
            this.paperimg.Click += new System.EventHandler(this.paperimg_Click);
            // 
            // sciimg
            // 
            this.sciimg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sciimg.BackgroundImage")));
            this.sciimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sciimg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sciimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sciimg.Location = new System.Drawing.Point(197, 119);
            this.sciimg.Name = "sciimg";
            this.sciimg.Size = new System.Drawing.Size(87, 85);
            this.sciimg.TabIndex = 2;
            this.sciimg.TabStop = false;
            this.sciimg.Click += new System.EventHandler(this.sciimg_Click);
            // 
            // aichoice
            // 
            this.aichoice.AutoSize = true;
            this.aichoice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aichoice.Location = new System.Drawing.Point(11, 9);
            this.aichoice.Name = "aichoice";
            this.aichoice.Size = new System.Drawing.Size(213, 32);
            this.aichoice.TabIndex = 3;
            this.aichoice.Text = "Computer chose: x";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(11, 91);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(211, 25);
            this.result.TabIndex = 4;
            this.result.Text = "Click any image to play!";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // victor_label
            // 
            this.victor_label.AutoSize = true;
            this.victor_label.Location = new System.Drawing.Point(73, 64);
            this.victor_label.Name = "victor_label";
            this.victor_label.Size = new System.Drawing.Size(118, 15);
            this.victor_label.TabIndex = 5;
            this.victor_label.Text = "YOU ARE THE REAL x";
            this.victor_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.victor_label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 217);
            this.Controls.Add(this.victor_label);
            this.Controls.Add(this.result);
            this.Controls.Add(this.aichoice);
            this.Controls.Add(this.sciimg);
            this.Controls.Add(this.paperimg);
            this.Controls.Add(this.rockimg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rockimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sciimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox rockimg;
        private PictureBox paperimg;
        private PictureBox sciimg;
        private Label aichoice;
        private Label result;
        private Label victor_label;
    }
}