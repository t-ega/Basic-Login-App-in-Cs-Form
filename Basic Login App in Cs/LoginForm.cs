using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Login_App_in_Cs
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // set the connection string
            string connectionString = "server=localhost;database=usermanagementsystem;uid=root;pwd=admin;";
            string query = "SELECT * FROM USERS WHERE username = @username and password = @password";

            // set the connection object
            MySqlConnection loginConn = new MySqlConnection();
            loginConn.ConnectionString = connectionString;
            MySqlCommand command = new MySqlCommand(query, loginConn);

            // set the parameters
            MySqlParameter usernameParam = new MySqlParameter();
            usernameParam.ParameterName = "username";
            usernameParam.Value = usernameTxtBox.Text;

            MySqlParameter passwordParam = new MySqlParameter();
            passwordParam.ParameterName = "password";
            passwordParam.Value = passwordTxtBox.Text;

            // add the parameters to the command
            command.Parameters.Add(usernameParam);
            command.Parameters.Add(passwordParam);

            // open the connection
            loginConn.Open();
            object result = command.ExecuteScalar();

            // checks if there was any user found with such details
            if (result != null)
            {
                MessageBox.Show("Logged In");

            }
            else
            {
                MessageBox.Show("Username or password not correct");
            }
            loginConn.Close();
            // dispose/delete the connection
            command.Dispose();


        }

        private void SignupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpFrm signUpWindow = new SignUpFrm();
            signUpWindow.Show();

        }

        private void usernameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
