namespace Expenses_Management_System
{
    partial class Expenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenses));
            panel2 = new Panel();
            label2 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ExpName_tb = new TextBox();
            label3 = new Label();
            ExpAmnt_tb = new TextBox();
            label4 = new Label();
            ExpDesc_tb = new TextBox();
            label5 = new Label();
            ExpCat_cmb = new ComboBox();
            label6 = new Label();
            ExpDate_dtp = new DateTimePicker();
            AddExp_btn = new Button();
            User_lbl = new Label();
            Back_lbl = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel2.Size = new Size(386, 50);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(49, 12);
            label2.Name = "label2";
            label2.Size = new Size(157, 24);
            label2.TabIndex = 14;
            label2.Text = "Add Expenses";
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
            pictureBox2.Location = new Point(341, 3);
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
            label1.Location = new Point(71, 94);
            label1.Name = "label1";
            label1.Size = new Size(148, 22);
            label1.TabIndex = 9;
            label1.Text = "Expense Name";
            // 
            // ExpName_tb
            // 
            ExpName_tb.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExpName_tb.Location = new Point(71, 119);
            ExpName_tb.Name = "ExpName_tb";
            ExpName_tb.Size = new Size(250, 32);
            ExpName_tb.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(71, 173);
            label3.Name = "label3";
            label3.Size = new Size(167, 22);
            label3.TabIndex = 11;
            label3.Text = "Expense Amount";
            // 
            // ExpAmnt_tb
            // 
            ExpAmnt_tb.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExpAmnt_tb.Location = new Point(71, 198);
            ExpAmnt_tb.Name = "ExpAmnt_tb";
            ExpAmnt_tb.Size = new Size(250, 32);
            ExpAmnt_tb.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(71, 427);
            label4.Name = "label4";
            label4.Size = new Size(203, 22);
            label4.TabIndex = 13;
            label4.Text = "Expense Description";
            // 
            // ExpDesc_tb
            // 
            ExpDesc_tb.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExpDesc_tb.Location = new Point(71, 452);
            ExpDesc_tb.Multiline = true;
            ExpDesc_tb.Name = "ExpDesc_tb";
            ExpDesc_tb.Size = new Size(250, 117);
            ExpDesc_tb.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DeepSkyBlue;
            label5.Location = new Point(71, 258);
            label5.Name = "label5";
            label5.Size = new Size(181, 22);
            label5.TabIndex = 14;
            label5.Text = "Expense Category";
            // 
            // ExpCat_cmb
            // 
            ExpCat_cmb.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExpCat_cmb.FormattingEnabled = true;
            ExpCat_cmb.Items.AddRange(new object[] { "Food", "Shopping", "Medical", "Household", "Travel", "Vehicle", "Others" });
            ExpCat_cmb.Location = new Point(71, 283);
            ExpCat_cmb.Name = "ExpCat_cmb";
            ExpCat_cmb.Size = new Size(250, 32);
            ExpCat_cmb.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DeepSkyBlue;
            label6.Location = new Point(71, 340);
            label6.Name = "label6";
            label6.Size = new Size(138, 22);
            label6.TabIndex = 16;
            label6.Text = "Expense Date";
            // 
            // ExpDate_dtp
            // 
            ExpDate_dtp.CalendarFont = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExpDate_dtp.Format = DateTimePickerFormat.Short;
            ExpDate_dtp.Location = new Point(71, 365);
            ExpDate_dtp.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            ExpDate_dtp.Name = "ExpDate_dtp";
            ExpDate_dtp.Size = new Size(250, 25);
            ExpDate_dtp.TabIndex = 17;
            // 
            // AddExp_btn
            // 
            AddExp_btn.BackColor = Color.SteelBlue;
            AddExp_btn.ForeColor = Color.White;
            AddExp_btn.Location = new Point(109, 578);
            AddExp_btn.Name = "AddExp_btn";
            AddExp_btn.Size = new Size(163, 39);
            AddExp_btn.TabIndex = 18;
            AddExp_btn.Text = "Add Expense";
            AddExp_btn.UseVisualStyleBackColor = false;
            AddExp_btn.Click += AddExp_btn_Click;
            // 
            // User_lbl
            // 
            User_lbl.AutoSize = true;
            User_lbl.Font = new Font("Arial", 11F, FontStyle.Bold);
            User_lbl.ForeColor = Color.DeepSkyBlue;
            User_lbl.Location = new Point(311, 67);
            User_lbl.Name = "User_lbl";
            User_lbl.Size = new Size(42, 18);
            User_lbl.TabIndex = 19;
            User_lbl.Text = "User";
            // 
            // Back_lbl
            // 
            Back_lbl.AutoSize = true;
            Back_lbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back_lbl.ForeColor = Color.DeepSkyBlue;
            Back_lbl.Location = new Point(171, 620);
            Back_lbl.Name = "Back_lbl";
            Back_lbl.Size = new Size(48, 19);
            Back_lbl.TabIndex = 21;
            Back_lbl.Text = "Back";
            Back_lbl.Click += Back_lbl_Click;
            // 
            // Expenses
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(386, 643);
            Controls.Add(Back_lbl);
            Controls.Add(User_lbl);
            Controls.Add(AddExp_btn);
            Controls.Add(ExpDate_dtp);
            Controls.Add(label6);
            Controls.Add(ExpCat_cmb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ExpDesc_tb);
            Controls.Add(label3);
            Controls.Add(ExpAmnt_tb);
            Controls.Add(label1);
            Controls.Add(ExpName_tb);
            Controls.Add(panel2);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Expenses";
            Text = "Expenses";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private TextBox ExpName_tb;
        private Label label3;
        private TextBox ExpAmnt_tb;
        private Label label4;
        private TextBox ExpDesc_tb;
        private Label label5;
        private ComboBox ExpCat_cmb;
        private Label label6;
        private DateTimePicker ExpDate_dtp;
        private Button AddExp_btn;
        private Label User_lbl;
        private Label Back_lbl;
    }
}