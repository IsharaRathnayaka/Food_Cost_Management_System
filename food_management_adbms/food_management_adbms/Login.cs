using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.ManagedDataAccess.Client;
//using System;
//using System.Data;



namespace ES_project2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            box_log_pass.isPassword = true;          
        }

        public static string main_id = "";

       
        string connectionString = "DATA SOURCE=localhost:1521/xe;User ID=system;Password=1111";

        

        private bool AuthenticateUser(string username, string password)
        {
            bool isAuthenticated = false;



            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("SELECT COUNT(*) FROM sys.user_login WHERE username = :username AND password = :password", connection))
                    {
                        
                        command.Parameters.Add("username", OracleDbType.Varchar2).Value = username; 
                        command.Parameters.Add("password", OracleDbType.Varchar2).Value = password;
                     

                        int count = Convert.ToInt32(command.ExecuteScalar());

                       

                        if (count > 0)
                        {
                            isAuthenticated = true;
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return isAuthenticated;
        }


        private void bt_login_Click(object sender, EventArgs e)
        {
            String userid = box_id.Text;
            String userpass = box_log_pass.Text;
            main_id = userid;



            bool isAuthenticated = AuthenticateUser(userid, userpass);

            if (isAuthenticated)
            {
                
                MessageBox.Show("Login successful!");

                Dashboard dash = new Dashboard();
                dash.Show();
                this.Hide();

                
            }
            else
            {
               
                MessageBox.Show("Invalid username or password. Please try again.");

            }

       
            }

            private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkbox_OnChange(object sender, EventArgs e)
        {
            if (chkbox.Checked)
            {
                box_log_pass.isPassword = false;
            }
            else
            {
                box_log_pass.isPassword = true;
            }
        }

        private void box_id_OnValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
