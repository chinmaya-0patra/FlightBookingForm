namespace FlightBookingForm
{
    public partial class LoginForm : Form
    {

        public static string id,pass;
        
        public LoginForm()
        {
            InitializeComponent();
        }

        
        private void loginfun()
        {
            id = userID.Text;
            pass = userPass.Text;

            if (id == "sam" && pass == "12345")
            {
                this.Hide();
                BookingPage bpage = new BookingPage();
                bpage.Show();
            }
            if (userID.Text == null && userPass.Text == null)
            {
                errorLbl.Text = "*Credentials are Empty! Please enter some value, Moron.";
            }
            else
            {
                errorLbl.Text = "*Credentials are incorrect! Try again.";
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            
            loginfun();
            
        }

        private void loginBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loginfun();
                
            }
        }

        
    }
}
