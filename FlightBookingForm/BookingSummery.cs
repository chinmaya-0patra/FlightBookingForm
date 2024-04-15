using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightBookingForm
{
    public partial class BookingSummery : Form
    {
        public BookingSummery()
        {
            InitializeComponent();
        }

        private static string fnamedata, lnamedata, sdate, edate;
        private void BookingSummery_Load(object sender, EventArgs e)
        {
            if (BookingPage.passport)
            {
                passnoSum.Text = "Passport No. :";
                passexpSum.Text = "Passport Expiry Date :";

            }
            if (BookingPage.idCard)
            {
                passnoSum.Text = "ID Card No. :";
                passexpSum.Text = "ID Expiry Date :";

            }
            fnamedata = BookingPage.firstname;
            lnamedata = BookingPage.lastname;
            lblSummery.Text = "Welcome to LA Airlines Booking Summery Page.";
            lblSuccess.Text = "Congratulation! Your flight has been booked on " + BookingPage.startTripdate + " Please bring your original Passport/ID card. \n Further details has been sent to you on your Email. Have a safe flight" + fnamedata;
            
            lblName.Text = fnamedata + " " + lnamedata;
            lblBoardcity.Text = BookingPage.boarding;
            lblDestCity.Text = BookingPage.destination;
            sdate = BookingPage.startTripdate;
            edate = BookingPage.endTripdate;
            lblDates.Text = sdate + " To " + edate;
            lblPassNo.Text = BookingPage.docNo;
            lblExpdate.Text = BookingPage.docExpirydate;
            lblweight.Text = BookingPage.baggageWeight + " Kgs";
            lblseatdata.Text = BookingPage.seat;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enjoy your Flight");
            //this.Hide();
        }
    }
}
