using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FlightBookingForm
{
    public partial class BookingPage : Form
    {

        public static Boolean passport;
        public static Boolean idCard;
        public static string boarding, destination, firstname, lastname, startTripdate, endTripdate, docNo, docIssuedate, docExpirydate, baggageWeight, seat;



        public BookingPage()
        {
            InitializeComponent();
        }

        private void BookingPage_Load(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 100;
            monthCalendar1.ShowToday = true;
        }

        private void boardingInfo_Click(object sender, EventArgs e)
        {

        }

        private void radioPassport_CheckedChanged(object sender, EventArgs e)
        {
            lblDocno.Text = "Passport No.";
            lblDocissue.Text = "Passport issue Date";
            lblDocExpiry.Text = "Passport Expiry Date";

            passport = true;

        }

        private void radioIDcard_CheckedChanged(object sender, EventArgs e)
        {
            lblDocno.Text = "ID No.";
            lblDocissue.Text = "ID issue Date";
            lblDocExpiry.Text = "ID Expiry Date";

            idCard = true;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            boarding = textboarding.Text;
            destination = textDestination.Text;
            firstname = fname.Text;
            lastname = lname.Text;
            startTripdate = monthCalendar1.SelectionStart.ToString("dd MM yyyy");
            endTripdate = monthCalendar1.SelectionEnd.ToString("dd MM yyyy");
            docNo = textDocno.Text;
            docIssuedate = dateTimePicker1.Value.ToString("dd MM yyyy");
            docExpirydate = dateTimePicker2.Value.ToString("dd MM yyyy");
            baggageWeight = numericUpDown1.Value.ToString();
            seatfun();

            


            


            if (numericUpDown1.Value > 20)
            {
                DialogResult dr = MessageBox.Show("You shouldn't exceed maximum weight limit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                this.Hide();
                BookingSummery bs = new BookingSummery();
                bs.Show();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            dateTimePicker2.MinDate = dt;
        }

        private void radioBusiness_CheckedChanged(object sender, EventArgs e)
        {
            seatfun();
        }

        private void seatfun()
        {
            if (radioBusiness.Checked == true)
            {
                seat = radioBusiness.Text;
            }
            if (radioEco.Checked == true)
            {
                seat = radioEco.Text;
            }
        }
    }
}
