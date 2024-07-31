using System.Data;
using System.Data.SqlClient;

namespace Expenses_Management_System
{
    public partial class ViewExpenses : Form
    {
        SqlConnection Ucon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Administrator\Documents\Expenses_db.mdf;Integrated Security = True; Connect Timeout = 30");

        public ViewExpenses()
        {
            InitializeComponent();
            ShowExpenses();
            User_lbl.Text = Login.User;
        }

        private void ShowExpenses()
        {
            Ucon.Open();
            string Query = "select * from ExpensesTable where ExpUser = '" + Login.User + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Ucon);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            VwExpenses_dgv.DataSource = ds.Tables[0];
            Ucon.Close();
        }

        private void FilterByCat()
        {
            Ucon.Open();
            string Query = "select * from ExpensesTable where ExpUser = '" + Login.User + "' and ExpCat = '" + ExpCat_cmb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Ucon);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            VwExpenses_dgv.DataSource = ds.Tables[0];
            Ucon.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowExpenses();
        }

        private void ExpCat_cmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCat();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
