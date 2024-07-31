using System.Data.SqlClient;
using System.Data;

namespace Expenses_Management_System
{
    public partial class Users : Form
    {
        SqlConnection Ucon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Administrator\Documents\Expenses_db.mdf;Integrated Security = True; Connect Timeout = 30");

        public Users()
        {
            InitializeComponent();
            ShowUser();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VwExpLink_lbl_Click(object sender, EventArgs e)
        {
            AdminExpenses adminExpenses = new AdminExpenses();
            adminExpenses.Show();
            this.Hide();
        }

        private void ShowUser()
        {
            Ucon.Open();
            string query = "select * from UsersTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Ucon);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Users_dgv.DataSource = ds.Tables[0];
            Ucon.Close();
        }

        private void Clear()
        {
            AddName_tb.Text = "";
            PhoneNumber_tb.Text = "";
            Password_tb.Text = "";
            Address_tb.Text = "";
        }

        private void AddUser_btn_Click(object sender, EventArgs e)
        {
            if (AddName_tb.Text == "" || PhoneNumber_tb.Text == "" || Password_tb.Text == "" || Address_tb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Ucon.Open();
                string query = "insert into UsersTable (UName, UDob, UPhone, UPass, UAddress) values(@UN, @UD, @UP, @UPA, @UA)";
                SqlCommand cmd = new SqlCommand(query, Ucon);
                cmd.Parameters.AddWithValue("@UN", AddName_tb.Text);
                cmd.Parameters.AddWithValue("@UD", DobDate_dtp.Value.Date);
                cmd.Parameters.AddWithValue("@UP", PhoneNumber_tb.Text);
                cmd.Parameters.AddWithValue("@UPA", Password_tb.Text);
                cmd.Parameters.AddWithValue("@UA", Address_tb.Text);
                cmd.ExecuteNonQuery();
                Ucon.Close();
                MessageBox.Show("User Added Successfully");
                ShowUser();
                Clear();
            }
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }
    }
}
