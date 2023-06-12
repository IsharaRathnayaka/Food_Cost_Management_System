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
    public partial class adminDash : Form
    {
        public adminDash()
        {
           
            InitializeComponent();
            Pstaff.Visible = false;
            P_staffregi.Visible = false;
            data_display.Visible = false;
            pUser.Visible = false;
            PanAdmin.Visible = true;    
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LUCKY\source\repos\KavinduLakmal2000\Project_Insurance_C-\Car_Insurance_DB.mdf;Integrated Security=True;Connect Timeout=30");

        //.//////////////////////////////////////////////////////////////// top button set /////////////////////////////////////////////////
        private void regi_tab_Click(object sender, EventArgs e)
        {
            line1.Left = regi_tab.Left;
            line1.Width = regi_tab.Width;
            Pstaff.Visible = false;
            P_staffregi.Visible = false;
            data_display.Visible = false;
            pUser.Visible = false;

            PanAdmin.Visible = true;

        }

        private void log_tab_Click(object sender, EventArgs e)
        {
            line1.Left = log_tab.Left;
            line1.Width = log_tab.Width;
            PanAdmin.Visible = false;
            P_staffregi.Visible = false;
            data_display.Visible = false;
            pUser.Visible = false;

            Pstaff.Visible = true;

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            line1.Left = del.Left;
            line1.Width = log_tab.Width;

            PanAdmin.Visible = false;
            P_staffregi.Visible = false;
            data_display.Visible = false;
            Pstaff.Visible = false;

            pUser.Visible = true;
        }

        private void chkData_Click(object sender, EventArgs e)
        {
            line1.Left = regi.Left;
            line1.Width = log_tab.Width;

            PanAdmin.Visible = false;
            Pstaff.Visible = false;
            pUser.Visible = false;
            data_display.Visible = false;

            P_staffregi.Visible = true;
            
            // chkData
        }

        private void chkData_Click_1(object sender, EventArgs e)
        {
            line1.Left = chkData.Left;
            line1.Width = log_tab.Width;

            PanAdmin.Visible = false;
            Pstaff.Visible = false;
            pUser.Visible = false;
            P_staffregi.Visible = false;

            data_display.Visible = true;
        }
       

        ///........................................................................admin panel ........................................
        private void bt_login_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from admin", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            AdminShow.DataSource = dt;
            conn.Close();

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            String AdminID = Aid.Text;
            String NPass = Npass.Text;
            String CPass = cPass.Text;

            if(NPass == CPass)
            {
              
               
                String insert = "UPDATE admin SET password='"+NPass+"' WHERE id='"+AdminID+"'";
                SqlCommand cmd = new SqlCommand(insert, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Password is Set!");
                    conn.Close();
                }

                catch (SqlException)
                {
                    MessageBox.Show("Password reset is failed! try again!");
                }

            }
            else
            {
                MessageBox.Show("Check Passwords Again !");
            }
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            String AdminID = Aid.Text;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT '"+AdminID+"', password FROM admin", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            AdminShow.DataSource = dt;
            conn.Close();

           

        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM settings", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            AdminShow.DataSource = dt;
            conn.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
         
        }
        //......................................................................................Staff panel ................................
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            // delete staff
            String id = Sid.Text;

          

            String insert = "DELETE FROM staff WHERE id = '"+id+"'";
            SqlCommand cmd = new SqlCommand(insert, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff Member Has been removed!");
                conn.Close();
            }

            catch (SqlException)
            {
                MessageBox.Show("Member removing failed! try again!");
            }

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
           
            String id = Sid.Text;
            // chk staff
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM staff WHERE id = '"+id+"'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StaffShow.DataSource = dt;
            conn.Close();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            //update staff

            String id = Sid.Text;
            String name = fname.Text;
            String Pass = pass.Text;
            String Email = mail.Text;
            String Address = adres.Text;


            String insert = "UPDATE staff SET First_name = '"+name+"', Email = '"+Email+"' , Password = '"+Pass+"' , Address = '"+Address+"'  WHERE id = '"+id+"' ";
            SqlCommand cmd = new SqlCommand(insert, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff Member data been updated!");
                conn.Close();
            }

            catch (SqlException)
            {
                MessageBox.Show("Data updating failed! try again!");
            }

        }

        private void StaffShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //...........................................................................User panel ..........................................
        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            String id = Uid.Text;

            String insert = "DELETE FROM client WHERE uid = '" + id + "'";
            SqlCommand cmd = new SqlCommand(insert, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Has been removed!");
                conn.Close();
            }

            catch (SqlException)
            {
                MessageBox.Show("Customer removing failed! Try Again!");
            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            String id = Uid.Text;
            // chk staff
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM client WHERE uid = '" + id + "'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            userData.DataSource = dt;
            conn.Close();
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            String id = Uid.Text;
            // chk staff
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM v_data WHERE vid = '" + id + "'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Vdata.DataSource = dt;
            conn.Close();
        }
        //........................................................................ staff register panel .....................................................................
        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            String sid = staffid.Text;
            String fname = firstN.Text;
            String lname = lastN.Text;
            String mail = email.Text;
            String adres = add.Text;
            String pass1 = f_pass.Text;
            String pass2 = con_pass.Text;
            String birth_d = b_day.Value.ToString();

            if (pass1 == pass2) {

                
                String insert = "INSERT INTO staff VALUES ('" + sid + "' ,'" + fname + "', '" + lname + "', '" + mail + "' , '"+pass1+"' , '"+adres+"', '"+birth_d+"' )";
                SqlCommand cmd = new SqlCommand(insert, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Member has been Registered!");
                    sid = "";
                    fname = "";
                    lname = "";
                    mail = "";
                    adres = "";
                    pass1 = "";
                    pass2 = "";
                    conn.Close();
                }

                catch (SqlException)
                {
                    MessageBox.Show("Data can not be upload & try again!");
                }

            }

            else
            {
                MessageBox.Show("Check both passwords & try again!");
            }

        }
        //....................................................................... check all panel ................................................................................................

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM admin", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            A_data.DataSource = dt;

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM staff", conn);
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            S_data.DataSource = dt2;

            SqlCommand cmd3 = new SqlCommand("SELECT * FROM client", conn);
            SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            U_data.DataSource = dt3;

            conn.Close();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Close();
            log.Show();

        }

        private void adminDash_Load(object sender, EventArgs e)
        {
            lbl_id.Text = Login.main_id;
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
           
        }

       
    }
}
