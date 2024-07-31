namespace Expenses_Management_System
{
    partial class Loading
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Loading_pbar = new ProgressBar();
            label2 = new Label();
            LoadValue_lbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.DeepSkyBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(74, 380);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(77, 9);
            label1.Name = "label1";
            label1.Size = new Size(492, 37);
            label1.TabIndex = 0;
            label1.Text = "Expenses Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(149, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Loading_pbar
            // 
            Loading_pbar.Location = new Point(80, 345);
            Loading_pbar.Name = "Loading_pbar";
            Loading_pbar.Size = new Size(481, 23);
            Loading_pbar.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(80, 313);
            label2.Name = "label2";
            label2.Size = new Size(221, 29);
            label2.TabIndex = 3;
            label2.Text = "Loading Modules:";
            // 
            // LoadValue_lbl
            // 
            LoadValue_lbl.AutoSize = true;
            LoadValue_lbl.Font = new Font("Arial", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LoadValue_lbl.ForeColor = Color.DeepSkyBlue;
            LoadValue_lbl.Location = new Point(307, 314);
            LoadValue_lbl.Name = "LoadValue_lbl";
            LoadValue_lbl.Size = new Size(46, 28);
            LoadValue_lbl.TabIndex = 4;
            LoadValue_lbl.Text = "0%";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(573, 380);
            Controls.Add(LoadValue_lbl);
            Controls.Add(label2);
            Controls.Add(Loading_pbar);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Loading";
            Text = "Form1";
            Load += Loading_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private ProgressBar Loading_pbar;
        private Label label2;
        private Label LoadValue_lbl;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}
