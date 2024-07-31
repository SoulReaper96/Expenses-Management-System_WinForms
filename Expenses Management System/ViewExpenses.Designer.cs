namespace Expenses_Management_System
{
    partial class ViewExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewExpenses));
            panel2 = new Panel();
            label2 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox2 = new PictureBox();
            VwExp_btn = new Button();
            VwExpenses_dgv = new DataGridView();
            User_lbl = new Label();
            ExpCat_cmb = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            Back_lbl = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VwExpenses_dgv).BeginInit();
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
            panel2.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(49, 12);
            label2.Name = "label2";
            label2.Size = new Size(161, 24);
            label2.TabIndex = 14;
            label2.Text = "View Expenses";
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
            // VwExp_btn
            // 
            VwExp_btn.BackColor = Color.SteelBlue;
            VwExp_btn.ForeColor = Color.White;
            VwExp_btn.Location = new Point(199, 583);
            VwExp_btn.Name = "VwExp_btn";
            VwExp_btn.Size = new Size(163, 39);
            VwExp_btn.TabIndex = 30;
            VwExp_btn.Text = "View Expense";
            VwExp_btn.UseVisualStyleBackColor = false;
            // 
            // VwExpenses_dgv
            // 
            VwExpenses_dgv.BackgroundColor = Color.White;
            VwExpenses_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VwExpenses_dgv.Location = new Point(12, 91);
            VwExpenses_dgv.Name = "VwExpenses_dgv";
            VwExpenses_dgv.Size = new Size(566, 486);
            VwExpenses_dgv.TabIndex = 31;
            // 
            // User_lbl
            // 
            User_lbl.AutoSize = true;
            User_lbl.Font = new Font("Arial", 11F, FontStyle.Bold);
            User_lbl.ForeColor = Color.DeepSkyBlue;
            User_lbl.Location = new Point(485, 59);
            User_lbl.Name = "User_lbl";
            User_lbl.Size = new Size(42, 18);
            User_lbl.TabIndex = 32;
            User_lbl.Text = "User";
            // 
            // ExpCat_cmb
            // 
            ExpCat_cmb.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExpCat_cmb.FormattingEnabled = true;
            ExpCat_cmb.Items.AddRange(new object[] { "Food", "Shopping", "Medical", "Household", "Travel", "Vehicle", "Others" });
            ExpCat_cmb.Location = new Point(199, 53);
            ExpCat_cmb.Name = "ExpCat_cmb";
            ExpCat_cmb.Size = new Size(179, 32);
            ExpCat_cmb.TabIndex = 34;
            ExpCat_cmb.SelectionChangeCommitted += ExpCat_cmb_SelectionChangeCommitted;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DeepSkyBlue;
            label5.Location = new Point(12, 57);
            label5.Name = "label5";
            label5.Size = new Size(181, 22);
            label5.TabIndex = 33;
            label5.Text = "Expense Category";
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(384, 52);
            button1.Name = "button1";
            button1.Size = new Size(63, 30);
            button1.TabIndex = 35;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Back_lbl
            // 
            Back_lbl.AutoSize = true;
            Back_lbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back_lbl.ForeColor = Color.DeepSkyBlue;
            Back_lbl.Location = new Point(261, 625);
            Back_lbl.Name = "Back_lbl";
            Back_lbl.Size = new Size(48, 19);
            Back_lbl.TabIndex = 36;
            Back_lbl.Text = "Back";
            Back_lbl.Click += Back_lbl_Click;
            // 
            // ViewExpenses
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(590, 657);
            Controls.Add(Back_lbl);
            Controls.Add(button1);
            Controls.Add(ExpCat_cmb);
            Controls.Add(label5);
            Controls.Add(User_lbl);
            Controls.Add(VwExpenses_dgv);
            Controls.Add(panel2);
            Controls.Add(VwExp_btn);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewExpenses";
            Text = "ViewExpenses";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)VwExpenses_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox2;
        private Button VwExp_btn;
        private DataGridView VwExpenses_dgv;
        private Label User_lbl;
        private ComboBox ExpCat_cmb;
        private Label label5;
        private Button button1;
        private Label Back_lbl;
    }
}