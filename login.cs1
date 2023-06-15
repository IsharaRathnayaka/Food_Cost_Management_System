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



namespace ES_project2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            box_log_pass.isPassword = true;         
        }
        public static string main_id = ""; // use this id in everywhere

        private void bt_login_Click(object sender, EventArgs e)
        {
            String userid = box_id.Text;
            //String userpass = box_log_pass.Text;

            main_id = userid;



            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Project_Insurance_C-\Car_Insurance_DB.mdf;Integrated Security=True;Connect Timeout=30");


            String res = userid.Substring(0, 1);
  
            if (res == "1")
            {

                /////////////////////////////////////////////for admin login ///////////////////////////////////////////
                

                String chkquery = "select * from admin where id = '" + box_id.Text.Trim() + "' and password = '" + box_log_pass.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(chkquery, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                   MessageBox.Show("Admin Login successful!");
                   adminDash ad = new adminDash();
                   ad.Show();
                   this.Hide();

                }
                else
                {
                    MessageBox.Show("check your password & ID then try again!");
                }
               
            }
            else if (res == "2")
            {
                ///////////////////////////////////////////////for staf login ///////////////////////////////////////////////////

                String chkquery = "select * from staff where id = '" + box_id.Text.Trim() + "' and password = '" + box_log_pass.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(chkquery, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Staff Login successful!");
                    staffDash ad = new staffDash();
                    ad.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("check your password & ID then try again!");
                }

            }

            else
            {
                MessageBox.Show("Check your ID and try again !");
            }


            // after enter id and pass then press login
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
