namespace FlightBookingForm
{
    partial class BookingSummery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingSummery));
            lblSummery = new Label();
            lblSuccess = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            passnoSum = new Label();
            passexpSum = new Label();
            label6 = new Label();
            label7 = new Label();
            lblName = new Label();
            lblDestCity = new Label();
            lblDates = new Label();
            lblPassNo = new Label();
            lblExpdate = new Label();
            lblweight = new Label();
            lblseatdata = new Label();
            btnDone = new Button();
            lblBoardcity = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // lblSummery
            // 
            lblSummery.AutoSize = true;
            lblSummery.Font = new Font("Castellar", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSummery.Location = new Point(284, 59);
            lblSummery.Name = "lblSummery";
            lblSummery.Size = new Size(74, 21);
            lblSummery.TabIndex = 0;
            lblSummery.Text = "label1";
            // 
            // lblSuccess
            // 
            lblSuccess.AutoSize = true;
            lblSuccess.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSuccess.Location = new Point(173, 116);
            lblSuccess.Name = "lblSuccess";
            lblSuccess.Size = new Size(62, 18);
            lblSuccess.TabIndex = 2;
            lblSuccess.Text = "Success";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(209, 210);
            label5.Margin = new Padding(5, 0, 3, 9);
            label5.Name = "label5";
            label5.Padding = new Padding(5);
            label5.Size = new Size(107, 33);
            label5.TabIndex = 9;
            label5.Text = "Full Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 294);
            label1.Margin = new Padding(5, 0, 3, 9);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(150, 33);
            label1.TabIndex = 10;
            label1.Text = "Deaparture City :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(209, 335);
            label2.Margin = new Padding(5, 0, 3, 9);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(105, 33);
            label2.TabIndex = 11;
            label2.Text = "Trip Dates :";
            // 
            // passnoSum
            // 
            passnoSum.AutoSize = true;
            passnoSum.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passnoSum.Location = new Point(209, 369);
            passnoSum.Margin = new Padding(5, 0, 3, 9);
            passnoSum.Name = "passnoSum";
            passnoSum.Padding = new Padding(5);
            passnoSum.Size = new Size(126, 33);
            passnoSum.TabIndex = 12;
            passnoSum.Text = "Passport No. :";
            // 
            // passexpSum
            // 
            passexpSum.AutoSize = true;
            passexpSum.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passexpSum.Location = new Point(209, 407);
            passexpSum.Margin = new Padding(5, 0, 3, 9);
            passexpSum.Name = "passexpSum";
            passexpSum.Padding = new Padding(5);
            passexpSum.Size = new Size(188, 33);
            passexpSum.TabIndex = 13;
            passexpSum.Text = "Passport Expiry Date :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(209, 446);
            label6.Margin = new Padding(5, 0, 3, 9);
            label6.Name = "label6";
            label6.Padding = new Padding(5);
            label6.Size = new Size(156, 33);
            label6.TabIndex = 14;
            label6.Text = "Baggage Weight :";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(209, 483);
            label7.Margin = new Padding(5, 0, 3, 9);
            label7.Name = "label7";
            label7.Padding = new Padding(5);
            label7.Size = new Size(149, 33);
            label7.TabIndex = 15;
            label7.Text = "Seat Preferance :";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(496, 210);
            lblName.Margin = new Padding(5, 0, 3, 9);
            lblName.Name = "lblName";
            lblName.Padding = new Padding(5);
            lblName.Size = new Size(107, 33);
            lblName.TabIndex = 16;
            lblName.Text = "Full Name :";
            // 
            // lblDestCity
            // 
            lblDestCity.AutoSize = true;
            lblDestCity.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestCity.Location = new Point(496, 294);
            lblDestCity.Margin = new Padding(5, 0, 3, 9);
            lblDestCity.Name = "lblDestCity";
            lblDestCity.Padding = new Padding(5);
            lblDestCity.Size = new Size(107, 33);
            lblDestCity.TabIndex = 17;
            lblDestCity.Text = "Full Name :";
            // 
            // lblDates
            // 
            lblDates.AutoSize = true;
            lblDates.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDates.Location = new Point(496, 335);
            lblDates.Margin = new Padding(5, 0, 3, 9);
            lblDates.Name = "lblDates";
            lblDates.Padding = new Padding(5);
            lblDates.Size = new Size(107, 33);
            lblDates.TabIndex = 18;
            lblDates.Text = "Full Name :";
            // 
            // lblPassNo
            // 
            lblPassNo.AutoSize = true;
            lblPassNo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassNo.Location = new Point(496, 369);
            lblPassNo.Margin = new Padding(5, 0, 3, 9);
            lblPassNo.Name = "lblPassNo";
            lblPassNo.Padding = new Padding(5);
            lblPassNo.Size = new Size(107, 33);
            lblPassNo.TabIndex = 19;
            lblPassNo.Text = "Full Name :";
            // 
            // lblExpdate
            // 
            lblExpdate.AutoSize = true;
            lblExpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpdate.Location = new Point(496, 407);
            lblExpdate.Margin = new Padding(5, 0, 3, 9);
            lblExpdate.Name = "lblExpdate";
            lblExpdate.Padding = new Padding(5);
            lblExpdate.Size = new Size(107, 33);
            lblExpdate.TabIndex = 20;
            lblExpdate.Text = "Full Name :";
            // 
            // lblweight
            // 
            lblweight.AutoSize = true;
            lblweight.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblweight.Location = new Point(496, 446);
            lblweight.Margin = new Padding(5, 0, 3, 9);
            lblweight.Name = "lblweight";
            lblweight.Padding = new Padding(5);
            lblweight.Size = new Size(107, 33);
            lblweight.TabIndex = 21;
            lblweight.Text = "Full Name :";
            // 
            // lblseatdata
            // 
            lblseatdata.AutoSize = true;
            lblseatdata.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblseatdata.Location = new Point(496, 483);
            lblseatdata.Margin = new Padding(5, 0, 3, 9);
            lblseatdata.Name = "lblseatdata";
            lblseatdata.Padding = new Padding(5);
            lblseatdata.Size = new Size(107, 33);
            lblseatdata.TabIndex = 22;
            lblseatdata.Text = "Full Name :";
            // 
            // btnDone
            // 
            btnDone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDone.BackColor = Color.SlateBlue;
            btnDone.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDone.Location = new Point(16, 600);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(989, 43);
            btnDone.TabIndex = 24;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // lblBoardcity
            // 
            lblBoardcity.AutoSize = true;
            lblBoardcity.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBoardcity.Location = new Point(496, 252);
            lblBoardcity.Margin = new Padding(5, 0, 3, 9);
            lblBoardcity.Name = "lblBoardcity";
            lblBoardcity.Padding = new Padding(5);
            lblBoardcity.Size = new Size(107, 33);
            lblBoardcity.TabIndex = 26;
            lblBoardcity.Text = "Full Name :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(209, 252);
            label9.Margin = new Padding(5, 0, 3, 9);
            label9.Name = "label9";
            label9.Padding = new Padding(5);
            label9.Size = new Size(133, 33);
            label9.TabIndex = 25;
            label9.Text = "Boarding City :";
            // 
            // BookingSummery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1017, 655);
            Controls.Add(lblBoardcity);
            Controls.Add(label9);
            Controls.Add(btnDone);
            Controls.Add(lblseatdata);
            Controls.Add(lblweight);
            Controls.Add(lblExpdate);
            Controls.Add(lblPassNo);
            Controls.Add(lblDates);
            Controls.Add(lblDestCity);
            Controls.Add(lblName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(passexpSum);
            Controls.Add(passnoSum);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(lblSuccess);
            Controls.Add(lblSummery);
            Name = "BookingSummery";
            Text = "BookingSummery";
            Load += BookingSummery_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSummery;
        private Label lblSuccess;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label passnoSum;
        private Label passexpSum;
        private Label label6;
        private Label label7;
        private Label lblName;
        private Label lblDestCity;
        private Label lblDates;
        private Label lblPassNo;
        private Label lblExpdate;
        private Label lblweight;
        private Label lblseatdata;
        private Button btnDone;
        private Label lblBoardcity;
        private Label label9;
    }
}