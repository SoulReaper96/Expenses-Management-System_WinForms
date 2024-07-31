namespace Expenses_Management_System
{
    public partial class Loading : Form
    {
        private int StartP = 0;

        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StartP += 1;
            Loading_pbar.Value = StartP;
            LoadValue_lbl.Text = StartP + "%";
            if (Loading_pbar.Value == 100)
            {
                Loading_pbar.Value = 0;
                timer1.Stop();
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
