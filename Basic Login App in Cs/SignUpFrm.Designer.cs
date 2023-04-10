namespace Basic_Login_App_in_Cs
{
    partial class SignUpFrm
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
            pwd = new TextBox();
            lastName = new TextBox();
            firstName = new TextBox();
            label4 = new Label();
            pwdConf = new TextBox();
            signUpBtn = new Button();
            sign_inLbl = new LinkLabel();
            errorLbl = new Label();
            label5 = new Label();
            label6 = new Label();
            emailTxtBox = new TextBox();
            emailErrorLbl = new Label();
            firstnameErrorLbl = new Label();
            lastnameErrorLbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 106);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 148);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "LastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 188);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // pwd
            // 
            pwd.Location = new Point(243, 180);
            pwd.Name = "pwd";
            pwd.PasswordChar = '*';
            pwd.Size = new Size(100, 23);
            pwd.TabIndex = 3;
            pwd.TextChanged += pwd_TextChanged;
            // 
            // lastName
            // 
            lastName.Location = new Point(243, 140);
            lastName.Name = "lastName";
            lastName.Size = new Size(100, 23);
            lastName.TabIndex = 4;
            lastName.TextChanged += lastName_TextChanged;
            // 
            // firstName
            // 
            firstName.Location = new Point(243, 98);
            firstName.Name = "firstName";
            firstName.Size = new Size(100, 23);
            firstName.TabIndex = 5;
            firstName.TextChanged += firstName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 227);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 6;
            label4.Text = "Password Confrim";
            // 
            // pwdConf
            // 
            pwdConf.Location = new Point(260, 224);
            pwdConf.Name = "pwdConf";
            pwdConf.PasswordChar = '*';
            pwdConf.Size = new Size(100, 23);
            pwdConf.TabIndex = 7;
            pwdConf.TextChanged += pwdConf_TextChanged;
            // 
            // signUpBtn
            // 
            signUpBtn.Location = new Point(214, 275);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(75, 23);
            signUpBtn.TabIndex = 8;
            signUpBtn.Text = "Sign Up";
            signUpBtn.UseVisualStyleBackColor = true;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // sign_inLbl
            // 
            sign_inLbl.AutoSize = true;
            sign_inLbl.Location = new Point(324, 279);
            sign_inLbl.Name = "sign_inLbl";
            sign_inLbl.Size = new Size(143, 15);
            sign_inLbl.TabIndex = 9;
            sign_inLbl.TabStop = true;
            sign_inLbl.Text = "Have an account?, Sign In";
            sign_inLbl.LinkClicked += sign_inLbl_LinkClicked;
            // 
            // errorLbl
            // 
            errorLbl.AutoSize = true;
            errorLbl.ForeColor = Color.Red;
            errorLbl.Location = new Point(150, 257);
            errorLbl.Name = "errorLbl";
            errorLbl.Size = new Size(0, 15);
            errorLbl.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Mono SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(97, 9);
            label5.Name = "label5";
            label5.Size = new Size(322, 32);
            label5.TabIndex = 11;
            label5.Text = "User Management System";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(150, 69);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 12;
            label6.Text = "Email";
            // 
            // emailTxtBox
            // 
            emailTxtBox.Location = new Point(243, 61);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(100, 23);
            emailTxtBox.TabIndex = 13;
            emailTxtBox.TextChanged += emailTxtBox_TextChanged;
            // 
            // emailErrorLbl
            // 
            emailErrorLbl.AutoSize = true;
            emailErrorLbl.ForeColor = Color.Red;
            emailErrorLbl.Location = new Point(358, 69);
            emailErrorLbl.Name = "emailErrorLbl";
            emailErrorLbl.Size = new Size(0, 15);
            emailErrorLbl.TabIndex = 14;
            emailErrorLbl.Visible = false;
            // 
            // firstnameErrorLbl
            // 
            firstnameErrorLbl.AutoSize = true;
            firstnameErrorLbl.ForeColor = Color.Red;
            firstnameErrorLbl.Location = new Point(349, 101);
            firstnameErrorLbl.Name = "firstnameErrorLbl";
            firstnameErrorLbl.Size = new Size(169, 15);
            firstnameErrorLbl.TabIndex = 16;
            firstnameErrorLbl.Text = "Length must be greater than 3!";
            firstnameErrorLbl.Visible = false;
            // 
            // lastnameErrorLbl
            // 
            lastnameErrorLbl.AutoSize = true;
            lastnameErrorLbl.ForeColor = Color.Red;
            lastnameErrorLbl.Location = new Point(349, 143);
            lastnameErrorLbl.Name = "lastnameErrorLbl";
            lastnameErrorLbl.Size = new Size(169, 15);
            lastnameErrorLbl.TabIndex = 17;
            lastnameErrorLbl.Text = "Length must be greater than 3!";
            lastnameErrorLbl.Visible = false;
            // 
            // SignUpFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 326);
            Controls.Add(lastnameErrorLbl);
            Controls.Add(firstnameErrorLbl);
            Controls.Add(emailErrorLbl);
            Controls.Add(emailTxtBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(errorLbl);
            Controls.Add(sign_inLbl);
            Controls.Add(signUpBtn);
            Controls.Add(pwdConf);
            Controls.Add(label4);
            Controls.Add(firstName);
            Controls.Add(lastName);
            Controls.Add(pwd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUpFrm";
            Text = "SignUpFrm";
            Load += SignUpFrm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox pwd;
        private TextBox lastName;
        private TextBox firstName;
        private Label label4;
        private TextBox pwdConf;
        private Button signUpBtn;
        private LinkLabel sign_inLbl;
        private Label errorLbl;
        private Label label5;
        private Label label6;
        private TextBox emailTxtBox;
        private Label emailErrorLbl;
        private Label firstnameErrorLbl;
        private Label lastnameErrorLbl;
    }
}