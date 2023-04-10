namespace Basic_Login_App_in_Cs
{
    partial class LoginForm
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
            usernameTxtBox = new TextBox();
            passwordTxtBox = new TextBox();
            LoginBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            SignupLink = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 119);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 69);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // usernameTxtBox
            // 
            usernameTxtBox.Location = new Point(236, 61);
            usernameTxtBox.Name = "usernameTxtBox";
            usernameTxtBox.Size = new Size(100, 23);
            usernameTxtBox.TabIndex = 2;
            usernameTxtBox.TextChanged += usernameTxtBox_TextChanged;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Location = new Point(236, 111);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Size = new Size(100, 23);
            passwordTxtBox.TabIndex = 3;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(193, 171);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(75, 23);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(86, 9);
            label3.Name = "label3";
            label3.Size = new Size(322, 32);
            label3.TabIndex = 5;
            label3.Text = "User Management System";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 212);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 6;
            label4.Text = "Forgot Password?";
            label4.Click += label4_Click;
            // 
            // SignupLink
            // 
            SignupLink.AutoSize = true;
            SignupLink.Location = new Point(69, 212);
            SignupLink.Name = "SignupLink";
            SignupLink.Size = new Size(179, 15);
            SignupLink.TabIndex = 8;
            SignupLink.TabStop = true;
            SignupLink.Text = "Don't have an Account?, Sign up";
            SignupLink.LinkClicked += SignupLink_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 278);
            Controls.Add(SignupLink);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LoginBtn);
            Controls.Add(passwordTxtBox);
            Controls.Add(usernameTxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameTxtBox;
        private TextBox passwordTxtBox;
        private Button LoginBtn;
        private Label label3;
        private Label label4;
        private LinkLabel SignupLink;
    }
}