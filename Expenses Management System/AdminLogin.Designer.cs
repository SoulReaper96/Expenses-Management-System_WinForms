namespace Expenses_Management_System
{
    partial class AdminLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            pictureBox1 = new PictureBox();
            Login_btn = new Button();
            label3 = new Label();
            Password_tb = new TextBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            Back_lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(527, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login_btn
            // 
            Login_btn.BackColor = Color.SteelBlue;
            Login_btn.ForeColor = Color.White;
            Login_btn.Location = new Point(273, 231);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(115, 39);
            Login_btn.TabIndex = 21;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = false;
            Login_btn.Click += Login_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(275, 168);
            label3.Name = "label3";
            label3.Size = new Size(103, 22);
            label3.TabIndex = 19;
            label3.Text = "Password";
            // 
            // Password_tb
            // 
            Password_tb.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password_tb.Location = new Point(199, 193);
            Password_tb.Name = "Password_tb";
            Password_tb.Size = new Size(250, 32);
            Password_tb.TabIndex = 18;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(273, 59);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(115, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.DeepSkyBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(104, 302);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(146, 9);
            label1.Name = "label1";
            label1.Size = new Size(369, 29);
            label1.TabIndex = 13;
            label1.Text = "Expenses Management System";
            // 
            // Back_lbl
            // 
            Back_lbl.AutoSize = true;
            Back_lbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back_lbl.ForeColor = Color.DeepSkyBlue;
            Back_lbl.Location = new Point(300, 273);
            Back_lbl.Name = "Back_lbl";
            Back_lbl.Size = new Size(48, 19);
            Back_lbl.TabIndex = 20;
            Back_lbl.Text = "Back";
            Back_lbl.Click += Back_lbl_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 302);
            Controls.Add(pictureBox1);
            Controls.Add(Login_btn);
            Controls.Add(Back_lbl);
            Controls.Add(label3);
            Controls.Add(Password_tb);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLogin";
            Text = "AdminLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Login_btn;
        private Label label3;
        private TextBox Password_tb;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
        private Label Back_lbl;
    }
}