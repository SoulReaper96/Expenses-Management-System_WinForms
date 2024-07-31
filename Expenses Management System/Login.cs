using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expenses_Management_System
{
    public partial class Login : Form
    {
        SqlConnection Ucon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Administrator\Documents\Expenses_db.mdf;Integrated Security = True; Connect Timeout = 30");
        public static string User;

        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            Ucon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from UsersTable where UName = '"+ Username_tb.Text +"' and UPass = '"+ Password_tb.Text +"'", Ucon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                User = Username_tb.Text;
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
                Ucon.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username and/or Password. Please check and try again.");
            }
            Ucon.Close();
        }

        private void Admin_lbl_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }
    }
}
