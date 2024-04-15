namespace FlightBookingForm
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            groupBox1 = new GroupBox();
            loginBtn = new Button();
            userPass = new TextBox();
            userID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            errorLbl = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Castellar", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 69);
            label1.Name = "label1";
            label1.Size = new Size(432, 34);
            label1.TabIndex = 0;
            label1.Text = "Welcome to LA Airlines!";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(loginBtn);
            groupBox1.Controls.Add(userPass);
            groupBox1.Controls.Add(userID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe Print", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(205, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(548, 293);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.IndianRed;
            loginBtn.Font = new Font("Rusty Fever_Bold_DEMO", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.Location = new Point(224, 223);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(94, 36);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            loginBtn.KeyPress += loginBtn_KeyPress;
            // 
            // userPass
            // 
            userPass.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userPass.ForeColor = Color.Black;
            userPass.Location = new Point(224, 142);
            userPass.Name = "userPass";
            userPass.Size = new Size(269, 25);
            userPass.TabIndex = 3;
            // 
            // userID
            // 
            userID.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userID.ForeColor = Color.Black;
            userID.Location = new Point(224, 78);
            userID.Name = "userID";
            userID.Size = new Size(269, 25);
            userID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 137);
            label3.Name = "label3";
            label3.Size = new Size(123, 35);
            label3.TabIndex = 1;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 78);
            label2.Name = "label2";
            label2.Size = new Size(122, 35);
            label2.TabIndex = 0;
            label2.Text = "Email/ID :";
            // 
            // errorLbl
            // 
            errorLbl.AutoSize = true;
            errorLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorLbl.ForeColor = Color.Red;
            errorLbl.Location = new Point(366, 470);
            errorLbl.Name = "errorLbl";
            errorLbl.Size = new Size(0, 23);
            errorLbl.TabIndex = 2;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(963, 537);
            Controls.Add(errorLbl);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Button loginBtn;
        private TextBox userPass;
        private TextBox userID;
        private Label errorLbl;
    }
}
