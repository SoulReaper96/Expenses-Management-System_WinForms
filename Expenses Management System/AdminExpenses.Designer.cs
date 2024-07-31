namespace Expenses_Management_System
{
    partial class AdminExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminExpenses));
            panel2 = new Panel();
            label2 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox2 = new PictureBox();
            AdminExpenses_dgv = new DataGridView();
            VwExp_btn = new Button();
            pictureBox4 = new PictureBox();
            VwCatExpenses_btn = new Button();
            ExpCat_cmb = new ComboBox();
            label5 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdminExpenses_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            panel2.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(49, 12);
            label2.Name = "label2";
            label2.Size = new Size(181, 24);
            label2.TabIndex = 14;
            label2.Text = "Admin Expenses";
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
            // AdminExpenses_dgv
            // 
            AdminExpenses_dgv.BackgroundColor = Color.White;
            AdminExpenses_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminExpenses_dgv.Location = new Point(12, 95);
            AdminExpenses_dgv.Name = "AdminExpenses_dgv";
            AdminExpenses_dgv.Size = new Size(566, 620);
            AdminExpenses_dgv.TabIndex = 34;
            // 
            // VwExp_btn
            // 
            VwExp_btn.BackColor = Color.SteelBlue;
            VwExp_btn.ForeColor = Color.White;
            VwExp_btn.Location = new Point(199, 736);
            VwExp_btn.Name = "VwExp_btn";
            VwExp_btn.Size = new Size(163, 39);
            VwExp_btn.TabIndex = 33;
            VwExp_btn.Text = "View Expense";
            VwExp_btn.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(546, 56);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 35;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // VwCatExpenses_btn
            // 
            VwCatExpenses_btn.BackColor = Color.SteelBlue;
            VwCatExpenses_btn.ForeColor = Color.White;
            VwCatExpenses_btn.Location = new Point(384, 57);
            VwCatExpenses_btn.Name = "VwCatExpenses_btn";
            VwCatExpenses_btn.Size = new Size(63, 30);
            VwCatExpenses_btn.TabIndex = 38;
            VwCatExpenses_btn.Text = "View";
            VwCatExpenses_btn.UseVisualStyleBackColor = false;
            VwCatExpenses_btn.Click += VwCatExpenses_btn_Click;
            // 
            // ExpCat_cmb
            // 
            ExpCat_cmb.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExpCat_cmb.FormattingEnabled = true;
            ExpCat_cmb.Items.AddRange(new object[] { "Food", "Shopping", "Medical", "Household", "Travel", "Vehicle", "Others" });
            ExpCat_cmb.Location = new Point(199, 58);
            ExpCat_cmb.Name = "ExpCat_cmb";
            ExpCat_cmb.Size = new Size(179, 32);
            ExpCat_cmb.TabIndex = 37;
            ExpCat_cmb.SelectionChangeCommitted += ExpCat_cmb_SelectionChangeCommitted;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DeepSkyBlue;
            label5.Location = new Point(12, 62);
            label5.Name = "label5";
            label5.Size = new Size(181, 22);
            label5.TabIndex = 36;
            label5.Text = "Expense Category";
            // 
            // AdminExpenses
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(590, 800);
            Controls.Add(VwCatExpenses_btn);
            Controls.Add(ExpCat_cmb);
            Controls.Add(label5);
            Controls.Add(pictureBox4);
            Controls.Add(panel2);
            Controls.Add(AdminExpenses_dgv);
            Controls.Add(VwExp_btn);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminExpenses";
            Text = "AdminExpenses";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdminExpenses_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox2;
        private DataGridView AdminExpenses_dgv;
        private Button VwExp_btn;
        private PictureBox pictureBox4;
        private Button VwCatExpenses_btn;
        private ComboBox ExpCat_cmb;
        private Label label5;
    }
}