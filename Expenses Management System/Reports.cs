using System.Data;
using System.Data.SqlClient;

namespace Expenses_Management_System
{
    public partial class Reports : Form
    {
        SqlConnection Ucon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Administrator\Documents\Expenses_db.mdf;Integrated Security = True; Connect Timeout = 30");

        public Reports()
        {
            InitializeComponent();
            GetMaxExp();
            GetMinExp();
            GetTotalExp();
            GetAvgExp();
            GetHighestExp();
            GetLowestExp();
        }

        private void GetMaxExp()
        {
            Ucon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select MAX(ExpAmnt) from ExpensesTable where ExpUser = '" + Login.User + "'", Ucon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Max_lbl.Text = "R" + dt.Rows[0][0].ToString();
            Ucon.Close();
        }

        private void GetMinExp()
        {
            Ucon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select MIN(ExpAmnt) from ExpensesTable where ExpUser = '" + Login.User + "'", Ucon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Min_lbl.Text = "R" + dt.Rows[0][0].ToString();
            Ucon.Close();
        }

        private void GetAvgExp()
        {
            Ucon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select SUM(ExpAmnt) from ExpensesTable where ExpUser = '" + Login.User + "'", Ucon);
            SqlDataAdapter sda1 = new SqlDataAdapter("select COUNT(*) from ExpensesTable where ExpUser = '" + Login.User + "'", Ucon);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            sda.Fill(dt);
            sda1.Fill(dt1);
            Double Avg = Convert.ToDouble(dt.Rows[0][0].ToString()) / Convert.ToDouble(dt1.Rows[0][0].ToString());
            Average_lbl.Text = "R" + Avg;
            Count_lbl.Text = dt1.Rows[0][0].ToString() + " Expenses";
            Ucon.Close();
        }

        private void GetTotalExp()
        {
            Ucon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select SUM(ExpAmnt) from ExpensesTable where ExpUser = '" + Login.User + "'", Ucon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Average_lbl.Text = "R" + dt.Rows[0][0].ToString();
            Ucon.Close();
        }

        private void GetTotalExpByCat()
        {
            Ucon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select SUM(ExpAmnt) from ExpensesTable where ExpUser = '" + Login.User + "' and ExpCat = '" + ExpCat_cmb.SelectedItem.ToString() + "'", Ucon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TotalCatExp_lbl.Text = "R" + dt.Rows[0][0].ToString();
            TotalCatExp_lbl.Visible = true;
            Ucon.Close();
        }

        private void GetHighestExp()
        {
            Ucon.Open();
            string InnerQuery = "select MAX(ExpAmnt) from ExpensesTable";
            DataTable dt1 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Ucon);
            sda1.Fill(dt1);
            string Query = "select ExpCat from ExpensesTable where ExpAmnt = '" + dt1.Rows[0][0].ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Ucon);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            Highest_lbl.Text = dt2.Rows[0][0].ToString();
            Ucon.Close();
        }

        private void GetLowestExp()
        {
            Ucon.Open();
            string InnerQuery = "select MIN(ExpAmnt) from ExpensesTable";
            DataTable dt1 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Ucon);
            sda1.Fill(dt1);
            string Query = "select ExpCat from ExpensesTable where ExpAmnt = '" + dt1.Rows[0][0].ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Ucon);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            Lowest_lbl.Text = dt2.Rows[0][0].ToString();
            Ucon.Close();
        }

        private void ExpCat_cmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTotalExpByCat();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
