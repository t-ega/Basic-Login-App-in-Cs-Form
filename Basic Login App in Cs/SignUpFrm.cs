using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Basic_Login_App_in_Cs
{
    public partial class SignUpFrm : Form
    {
        LoginForm loginWindow = new LoginForm();

        bool emailValid = false;
        bool passwordValid = false;
        bool firstnameValid = false;
        bool lastnameValid = false;

        public SignUpFrm()
        {
            InitializeComponent();

        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            // set the connection to the database
            string connectionString = "server=localhost;database=usermanagementsystem;uid=root;pwd=admin;";
            MySqlConnection signUpConn = new MySqlConnection();
            signUpConn.ConnectionString = connectionString;

            // get the email from the email text box
            string email = emailTxtBox.Text;
            string emailQuery = "SELECT * FROM Users WHERE email=@email";
            MySqlCommand emailExistCommand = new MySqlCommand(emailQuery, signUpConn);

            //Set SqlParameter
            MySqlParameter emailParam = new MySqlParameter();
            emailParam.ParameterName = "email";
            emailParam.MySqlDbType = MySqlDbType.VarChar;
            emailParam.Value = emailQuery;
            emailExistCommand.Parameters.Add(emailParam);

            // open the connection to the database
            signUpConn.Open();

            object response = emailExistCommand.ExecuteScalar();

            if (response != null)
            {
                MessageBox.Show("A user with this email Already exists");

                // close the db connction
                signUpConn.Close();
                return;
            }

            string firstname = firstName.Text;
            string lastname = lastName.Text;
            string password = pwd.Text;

            string query = "INSERT INTO Users (firstname, lastname, password, username, email) VALUES ( @firstname, @lastname, @password, @username, @email)";
            MySqlCommand command = new MySqlCommand(query, signUpConn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //Set SqlParameter
            MySqlParameter param = new MySqlParameter();
            param.ParameterName = "firstname";
            param.MySqlDbType = MySqlDbType.VarChar;
            param.Value = firstname;

            MySqlParameter param2 = new MySqlParameter();
            param2.ParameterName = "lastname";
            param2.MySqlDbType = MySqlDbType.VarChar;
            param2.Value = lastname;

            MySqlParameter param3 = new MySqlParameter();
            param3.ParameterName = "password";
            param3.MySqlDbType = MySqlDbType.VarChar;
            param3.Value = password;

            MySqlParameter usernameParam = new MySqlParameter();
            usernameParam.ParameterName = "username";
            usernameParam.MySqlDbType = MySqlDbType.VarChar;
            int start = 0;
            int length = 3;
            string first = firstname.Substring(start, length);
            string last = lastname.Substring(start, length);
            string username = first + last;
            usernameParam.Value = username;



            // add the sql parameters
            command.Parameters.Add(param);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);
            command.Parameters.Add(usernameParam);
            command.Parameters.AddWithValue("email", email);


            // execute the command
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();

            // SHow a message
            MessageBox.Show($"Registerd Successfuly!\n, Now login in with your the following:-\n" +
                $"Username: {username}\n password: your password");

            // close the connection to the database
            signUpConn.Close();

            // close the sign up window and show the login page
            this.Hide();
            loginWindow.Show();

        }

        private void sign_inLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            loginWindow.Show();
        }

        private void pwdConf_TextChanged(object sender, EventArgs e)
        {
            Validate_Passwords();
        }

        private void pwd_TextChanged(object sender, EventArgs e)
        {
            Validate_Passwords();
        }

        private void Validate_Passwords()
        {
            int pwdLength = pwd.TextLength;
            int pwdConfLenght = pwdConf.TextLength;
            if (pwd.Text != pwdConf.Text && pwd.Text != null && pwdConf.Text != null)
            {
                errorLbl.Text = "Password 1 and password 2 dont match!";
                errorLbl.Visible = true;
                passwordValid = false;
            }
            else
            {
                errorLbl.Visible = false;
                passwordValid = true;
            }
            UpdateSignUpBtn();

        }

        private void SignUpFrm_Load_1(object sender, EventArgs e)
        { // disable sign up button on load
            signUpBtn.Enabled = false;

        }

        private bool ValidateEmail(string emailAddress)
        {
            {
                var regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
                bool isValid = Regex.IsMatch(emailAddress, regex, RegexOptions.IgnoreCase);
                return isValid;
            }
        }

        private void emailTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (emailTxtBox.Text != "")
            {

            bool isValid = ValidateEmail(emailTxtBox.Text);
            if (isValid)
            {
                emailValid = true;
                emailErrorLbl.Visible = false;
            }
            else
            {
                emailErrorLbl.Text = "Invalid email format";
                emailValid = false;
                emailErrorLbl.Visible =true;
            }
            UpdateSignUpBtn();
            }
            else
            {
                emailErrorLbl.Visible = false;
               
            }
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            if (firstName.TextLength >= 3)
            {
                firstnameValid = true;
                firstnameErrorLbl.Visible = false;
            }
            else
            {
                firstnameErrorLbl.Visible = true;
                firstnameValid = false;
            }
            UpdateSignUpBtn();
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            if (lastName.TextLength >= 3)
            {
                lastnameValid = true;
                lastnameErrorLbl.Visible = false;
            }
            else
            {
                lastnameValid = false;
                lastnameErrorLbl.Visible = true;
            }
            UpdateSignUpBtn();
        }

        private void UpdateSignUpBtn()
        {
            if (emailValid && firstnameValid && lastnameValid && passwordValid)
            {
                signUpBtn.Enabled = true;
            }
            else
            {
                signUpBtn.Enabled = false;
            }
        }
    }
}
