namespace Expenses_Management_System
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            panel2 = new Panel();
            label2 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            AddName_tb = new TextBox();
            DobDate_dtp = new DateTimePicker();
            label6 = new Label();
            label3 = new Label();
            PhoneNumber_tb = new TextBox();
            label4 = new Label();
            Password_tb = new TextBox();
            label5 = new Label();
            Address_tb = new TextBox();
            VwExpLink_lbl = new Label();
            AddUser_btn = new Button();
            Users_dgv = new DataGridView();
            Back_lbl = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Users_dgv).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(590, 50);
            panel2.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(49, 12);
            label2.Name = "label2";
            label2.Size = new Size(119, 24);
            label2.TabIndex = 14;
            label2.Text = "View Users";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(40, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(545, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(50, 89);
            label1.Name = "label1";
            label1.Size = new Size(62, 22);
            label1.TabIndex = 23;
            label1.Text = "Name";
            // 
            // AddName_tb
            // 
            AddName_tb.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddName_tb.Location = new Point(50, 114);
            AddName_tb.Name = "AddName_tb";
            AddName_tb.Size = new Size(190, 32);
            AddName_tb.TabIndex = 22;
            // 
            // DobDate_dtp
            // 
            DobDate_dtp.CalendarFont = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DobDate_dtp.Format = DateTimePickerFormat.Short;
            DobDate_dtp.Location = new Point(255, 116);
            DobDate_dtp.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            DobDate_dtp.Name = "DobDate_dtp";
            DobDate_dtp.Size = new Size(147, 25);
            DobDate_dtp.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DeepSkyBlue;
            label6.Location = new Point(255, 91);
            label6.Name = "label6";
            label6.Size = new Size(111, 22);
            label6.TabIndex = 24;
            label6.Text = "User D.O.B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(50, 162);
            label3.Name = "label3";
            label3.Size = new Size(134, 22);
            label3.TabIndex = 27;
            label3.Text = "User Phone #";
            // 
            // PhoneNumber_tb
            // 
            PhoneNumber_tb.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneNumber_tb.Location = new Point(50, 187);
            PhoneNumber_tb.Name = "PhoneNumber_tb";
            PhoneNumber_tb.Size = new Size(190, 32);
            PhoneNumber_tb.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(255, 162);
            label4.Name = "label4";
            label4.Size = new Size(103, 22);
            label4.TabIndex = 29;
            label4.Text = "Password";
            // 
            // Password_tb
            // 
            Password_tb.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password_tb.Location = new Point(255, 187);
            Password_tb.Name = "Password_tb";
            Password_tb.Size = new Size(190, 32);
            Password_tb.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DeepSkyBlue;
            label5.Location = new Point(135, 242);
            label5.Name = "label5";
            label5.Size = new Size(88, 22);
            label5.TabIndex = 31;
            label5.Text = "Address";
            // 
            // Address_tb
            // 
            Address_tb.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Address_tb.Location = new Point(135, 267);
            Address_tb.Multiline = true;
            Address_tb.Name = "Address_tb";
            Address_tb.Size = new Size(250, 83);
            Address_tb.TabIndex = 30;
            // 
            // VwExpLink_lbl
            // 
            VwExpLink_lbl.AutoSize = true;
            VwExpLink_lbl.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            VwExpLink_lbl.ForeColor = Color.Gold;
            VwExpLink_lbl.Location = new Point(425, 55);
            VwExpLink_lbl.Name = "VwExpLink_lbl";
            VwExpLink_lbl.Size = new Size(151, 22);
            VwExpLink_lbl.TabIndex = 32;
            VwExpLink_lbl.Text = "View Expenses";
            VwExpLink_lbl.Click += VwExpLink_lbl_Click;
            // 
            // AddUser_btn
            // 
            AddUser_btn.BackColor = Color.SteelBlue;
            AddUser_btn.ForeColor = Color.White;
            AddUser_btn.Location = new Point(203, 729);
            AddUser_btn.Name = "AddUser_btn";
            AddUser_btn.Size = new Size(163, 39);
            AddUser_btn.TabIndex = 33;
            AddUser_btn.Text = "Add User";
            AddUser_btn.UseVisualStyleBackColor = false;
            AddUser_btn.Click += AddUser_btn_Click;
            // 
            // Users_dgv
            // 
            Users_dgv.BackgroundColor = Color.White;
            Users_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Users_dgv.Location = new Point(12, 370);
            Users_dgv.Name = "Users_dgv";
            Users_dgv.Size = new Size(566, 340);
            Users_dgv.TabIndex = 34;
            // 
            // Back_lbl
            // 
            Back_lbl.AutoSize = true;
            Back_lbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back_lbl.ForeColor = Color.DeepSkyBlue;
            Back_lbl.Location = new Point(528, 331);
            Back_lbl.Name = "Back_lbl";
            Back_lbl.Size = new Size(48, 19);
            Back_lbl.TabIndex = 35;
            Back_lbl.Text = "Back";
            Back_lbl.Click += Back_lbl_Click;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(590, 800);
            Controls.Add(Back_lbl);
            Controls.Add(Users_dgv);
            Controls.Add(AddUser_btn);
            Controls.Add(VwExpLink_lbl);
            Controls.Add(label5);
            Controls.Add(Address_tb);
            Controls.Add(label4);
            Controls.Add(Password_tb);
            Controls.Add(label3);
            Controls.Add(PhoneNumber_tb);
            Controls.Add(DobDate_dtp);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(AddName_tb);
            Controls.Add(panel2);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            Text = "Users";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Users_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox AddName_tb;
        private DateTimePicker DobDate_dtp;
        private Label label6;
        private Label label3;
        private TextBox PhoneNumber_tb;
        private Label label4;
        private TextBox Password_tb;
        private Label label5;
        private TextBox Address_tb;
        private Label VwExpLink_lbl;
        private Button AddUser_btn;
        private DataGridView Users_dgv;
        private Label Back_lbl;
    }
}