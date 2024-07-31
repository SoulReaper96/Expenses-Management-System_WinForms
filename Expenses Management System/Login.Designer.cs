namespace Expenses_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            Username_tb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Password_tb = new TextBox();
            Admin_lbl = new Label();
            Login_btn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(140, 9);
            label1.Name = "label1";
            label1.Size = new Size(369, 29);
            label1.TabIndex = 1;
            label1.Text = "Expenses Management System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.DeepSkyBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(104, 358);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(304, 59);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(115, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Username_tb
            // 
            Username_tb.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username_tb.Location = new Point(230, 193);
            Username_tb.Name = "Username_tb";
            Username_tb.Size = new Size(250, 32);
            Username_tb.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(230, 168);
            label2.Name = "label2";
            label2.Size = new Size(104, 22);
            label2.TabIndex = 7;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(230, 228);
            label3.Name = "label3";
            label3.Size = new Size(103, 22);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // Password_tb
            // 
            Password_tb.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password_tb.Location = new Point(230, 253);
            Password_tb.Name = "Password_tb";
            Password_tb.Size = new Size(250, 32);
            Password_tb.TabIndex = 8;
            // 
            // Admin_lbl
            // 
            Admin_lbl.AutoSize = true;
            Admin_lbl.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            Admin_lbl.ForeColor = Color.DeepSkyBlue;
            Admin_lbl.Location = new Point(331, 333);
            Admin_lbl.Name = "Admin_lbl";
            Admin_lbl.Size = new Size(58, 19);
            Admin_lbl.TabIndex = 10;
            Admin_lbl.Text = "Admin";
            Admin_lbl.Click += Admin_lbl_Click;
            // 
            // Login_btn
            // 
            Login_btn.BackColor = Color.SteelBlue;
            Login_btn.ForeColor = Color.White;
            Login_btn.Location = new Point(304, 291);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(115, 39);
            Login_btn.TabIndex = 11;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = false;
            Login_btn.Click += Login_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(521, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 358);
            Controls.Add(pictureBox1);
            Controls.Add(Login_btn);
            Controls.Add(Admin_lbl);
            Controls.Add(label3);
            Controls.Add(Password_tb);
            Controls.Add(label2);
            Controls.Add(Username_tb);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private TextBox Username_tb;
        private Label label2;
        private Label label3;
        private TextBox Password_tb;
        private Label Admin_lbl;
        private Button Login_btn;
        private PictureBox pictureBox1;
    }
}