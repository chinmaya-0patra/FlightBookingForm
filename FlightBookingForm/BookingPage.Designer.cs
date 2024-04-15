namespace FlightBookingForm
{
    partial class BookingPage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textboarding = new TextBox();
            textDestination = new TextBox();
            label4 = new Label();
            boardingInfo = new Label();
            monthCalendar1 = new MonthCalendar();
            fname = new TextBox();
            label5 = new Label();
            lname = new TextBox();
            label6 = new Label();
            label7 = new Label();
            radioPassport = new RadioButton();
            radioIDcard = new RadioButton();
            lblDocno = new Label();
            textDocno = new TextBox();
            lblDocissue = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            lblDocExpiry = new Label();
            label11 = new Label();
            numericUpDown1 = new NumericUpDown();
            btnBook = new Button();
            label12 = new Label();
            radioEco = new RadioButton();
            radioBusiness = new RadioButton();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Castellar", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(342, 46);
            label1.Name = "label1";
            label1.Size = new Size(417, 21);
            label1.TabIndex = 0;
            label1.Text = "Welcome to LA Airlines Booking Page.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(445, 80);
            label2.Name = "label2";
            label2.Size = new Size(210, 18);
            label2.TabIndex = 1;
            label2.Text = "*Please fill the below details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(234, 169);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 2;
            label3.Text = "From";
            // 
            // textboarding
            // 
            textboarding.Location = new Point(301, 168);
            textboarding.Name = "textboarding";
            textboarding.Size = new Size(241, 27);
            textboarding.TabIndex = 3;
            // 
            // textDestination
            // 
            textDestination.Location = new Point(675, 168);
            textDestination.Name = "textDestination";
            textDestination.Size = new Size(270, 27);
            textDestination.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(637, 169);
            label4.Name = "label4";
            label4.Size = new Size(27, 23);
            label4.TabIndex = 4;
            label4.Text = "To";
            // 
            // boardingInfo
            // 
            boardingInfo.AutoSize = true;
            boardingInfo.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boardingInfo.Location = new Point(234, 136);
            boardingInfo.Name = "boardingInfo";
            boardingInfo.Size = new Size(420, 18);
            boardingInfo.TabIndex = 6;
            boardingInfo.Text = "*Please Enter your boarding and destination details here -";
            boardingInfo.Click += boardingInfo_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(445, 252);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            // 
            // fname
            // 
            fname.Location = new Point(342, 501);
            fname.Name = "fname";
            fname.Size = new Size(200, 27);
            fname.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(234, 500);
            label5.Name = "label5";
            label5.Size = new Size(102, 23);
            label5.TabIndex = 8;
            label5.Text = "First Name :";
            // 
            // lname
            // 
            lname.Location = new Point(719, 499);
            lname.Name = "lname";
            lname.Size = new Size(226, 27);
            lname.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(608, 501);
            label6.Name = "label6";
            label6.Size = new Size(105, 23);
            label6.TabIndex = 10;
            label6.Text = "Last Name : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(234, 556);
            label7.Name = "label7";
            label7.Size = new Size(156, 23);
            label7.TabIndex = 12;
            label7.Text = "Travel Documents :";
            // 
            // radioPassport
            // 
            radioPassport.AutoSize = true;
            radioPassport.Location = new Point(402, 556);
            radioPassport.Name = "radioPassport";
            radioPassport.Size = new Size(85, 24);
            radioPassport.TabIndex = 13;
            radioPassport.TabStop = true;
            radioPassport.Text = "Passport";
            radioPassport.UseVisualStyleBackColor = true;
            radioPassport.CheckedChanged += radioPassport_CheckedChanged;
            // 
            // radioIDcard
            // 
            radioIDcard.AutoSize = true;
            radioIDcard.Location = new Point(493, 556);
            radioIDcard.Name = "radioIDcard";
            radioIDcard.Size = new Size(78, 24);
            radioIDcard.TabIndex = 14;
            radioIDcard.TabStop = true;
            radioIDcard.Text = "ID card";
            radioIDcard.UseVisualStyleBackColor = true;
            radioIDcard.CheckedChanged += radioIDcard_CheckedChanged;
            // 
            // lblDocno
            // 
            lblDocno.AutoSize = true;
            lblDocno.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocno.Location = new Point(608, 557);
            lblDocno.Name = "lblDocno";
            lblDocno.Size = new Size(131, 23);
            lblDocno.TabIndex = 15;
            lblDocno.Text = "Document No. :";
            // 
            // textDocno
            // 
            textDocno.Location = new Point(745, 557);
            textDocno.Name = "textDocno";
            textDocno.Size = new Size(200, 27);
            textDocno.TabIndex = 16;
            // 
            // lblDocissue
            // 
            lblDocissue.AutoSize = true;
            lblDocissue.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocissue.Location = new Point(234, 608);
            lblDocissue.Name = "lblDocissue";
            lblDocissue.Size = new Size(183, 23);
            lblDocissue.TabIndex = 17;
            lblDocissue.Text = "Document Issue Date :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(423, 605);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(182, 27);
            dateTimePicker1.TabIndex = 18;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(811, 605);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(182, 27);
            dateTimePicker2.TabIndex = 20;
            // 
            // lblDocExpiry
            // 
            lblDocExpiry.AutoSize = true;
            lblDocExpiry.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocExpiry.Location = new Point(611, 608);
            lblDocExpiry.Name = "lblDocExpiry";
            lblDocExpiry.Size = new Size(193, 23);
            lblDocExpiry.TabIndex = 19;
            lblDocExpiry.Text = "Document Expiry Date :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(234, 656);
            label11.Name = "label11";
            label11.Size = new Size(143, 23);
            label11.TabIndex = 21;
            label11.Text = "Baggage(in kgs) :";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(383, 656);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 22;
            // 
            // btnBook
            // 
            btnBook.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBook.BackColor = Color.SlateBlue;
            btnBook.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.Location = new Point(63, 721);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(989, 43);
            btnBook.TabIndex = 23;
            btnBook.Text = "Book Flight";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(234, 225);
            label12.Name = "label12";
            label12.Size = new Size(225, 18);
            label12.TabIndex = 24;
            label12.Text = "*Choose your date of Journey -";
            // 
            // radioEco
            // 
            radioEco.AutoSize = true;
            radioEco.Location = new Point(910, 656);
            radioEco.Name = "radioEco";
            radioEco.Size = new Size(128, 24);
            radioEco.TabIndex = 27;
            radioEco.TabStop = true;
            radioEco.Text = "Economy Class";
            radioEco.UseVisualStyleBackColor = true;
            // 
            // radioBusiness
            // 
            radioBusiness.AutoSize = true;
            radioBusiness.Location = new Point(779, 656);
            radioBusiness.Name = "radioBusiness";
            radioBusiness.Size = new Size(122, 24);
            radioBusiness.TabIndex = 26;
            radioBusiness.TabStop = true;
            radioBusiness.Text = "Business Class";
            radioBusiness.UseVisualStyleBackColor = true;
            radioBusiness.CheckedChanged += radioBusiness_CheckedChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(611, 656);
            label13.Name = "label13";
            label13.Size = new Size(139, 23);
            label13.TabIndex = 25;
            label13.Text = "Seat Preference :";
            // 
            // BookingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1112, 776);
            Controls.Add(radioEco);
            Controls.Add(radioBusiness);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(btnBook);
            Controls.Add(numericUpDown1);
            Controls.Add(label11);
            Controls.Add(dateTimePicker2);
            Controls.Add(lblDocExpiry);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblDocissue);
            Controls.Add(textDocno);
            Controls.Add(lblDocno);
            Controls.Add(radioIDcard);
            Controls.Add(radioPassport);
            Controls.Add(label7);
            Controls.Add(lname);
            Controls.Add(label6);
            Controls.Add(fname);
            Controls.Add(label5);
            Controls.Add(monthCalendar1);
            Controls.Add(boardingInfo);
            Controls.Add(textDestination);
            Controls.Add(label4);
            Controls.Add(textboarding);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BookingPage";
            Text = "TravelBookingPage";
            Load += BookingPage_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textboarding;
        private TextBox textDestination;
        private Label label4;
        private Label boardingInfo;
        private MonthCalendar monthCalendar1;
        private TextBox fname;
        private Label label5;
        private TextBox lname;
        private Label label6;
        private Label label7;
        private RadioButton radioPassport;
        private RadioButton radioIDcard;
        private Label lblDocno;
        private TextBox textDocno;
        private Label lblDocissue;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label lblDocExpiry;
        private Label label11;
        private NumericUpDown numericUpDown1;
        private Button btnBook;
        private Label label12;
        private RadioButton radioEco;
        private RadioButton radioBusiness;
        private Label label13;
    }
}