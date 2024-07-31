using System.Data;
using System.Data.SqlClient;

namespace Expenses_Management_System
{
    public partial class AdminExpenses : Form
    {
        SqlConnection Ucon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Administrator\Documents\Expenses_db.mdf;Integrated Security = True; Connect Timeout = 30");

        public AdminExpenses()
        {
            InitializeComponent();
            ShowAdmin();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowAdmin()
        {
            Ucon.Open();
            string query = "select * from ExpensesTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Ucon);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AdminExpenses_dgv.DataSource = ds.Tables[0];
            Ucon.Close();
        }
        private void ShowExpenses()
        {
            Ucon.Open();
            string Query = "select * from ExpensesTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Ucon);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AdminExpenses_dgv.DataSource = ds.Tables[0];
            Ucon.Close();
        }

        private void FilterByCat()
        {
            Ucon.Open();
            string Query = "select * from ExpensesTable where ExpCat = '" + ExpCat_cmb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Ucon);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AdminExpenses_dgv.DataSource = ds.Tables[0];
            Ucon.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void VwCatExpenses_btn_Click(object sender, EventArgs e)
        {
            ShowExpenses();
        }

        private void ExpCat_cmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCat();
        }
    }
}
