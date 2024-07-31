using System.Data;
using System.Data.SqlClient;

namespace Expenses_Management_System
{
    public partial class Expenses : Form
    {
        SqlConnection Ucon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Administrator\Documents\Expenses_db.mdf;Integrated Security = True; Connect Timeout = 30");

        public Expenses()
        {
            InitializeComponent();
            User_lbl.Text = Login.User;
        }

        private void Clear()
        {
            ExpName_tb.Text = string.Empty;
            ExpAmnt_tb.Text = string.Empty;
            ExpDesc_tb.Text = string.Empty;
            ExpCat_cmb.SelectedIndex = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddExp_btn_Click(object sender, EventArgs e)
        {
            if (ExpName_tb.Text == "" || ExpAmnt_tb.Text == "" || ExpDesc_tb.Text == "" || ExpCat_cmb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Ucon.Open();
                string query = "insert into ExpensesTable (ExpName, ExpAmnt, ExpCat, ExpDate, ExpDesc, ExpUser) values(@EN, @EA, @EC, @ED, @EDS, @EU)";
                SqlCommand cmd = new SqlCommand(query, Ucon);
                cmd.Parameters.AddWithValue("@EN", ExpName_tb.Text);
                cmd.Parameters.AddWithValue("@EA", ExpAmnt_tb.Text);
                cmd.Parameters.AddWithValue("@EC", ExpCat_cmb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ED", ExpDate_dtp.Value.Date);
                cmd.Parameters.AddWithValue("@EDS", ExpDesc_tb.Text);
                cmd.Parameters.AddWithValue("@EU", Login.User);
                cmd.ExecuteNonQuery();
                Ucon.Close();
                MessageBox.Show("Expense Added Successfully");
                //ShowUser();
                Clear();
            }
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
