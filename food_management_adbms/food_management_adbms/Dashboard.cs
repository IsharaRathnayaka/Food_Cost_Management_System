using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_project2
{
    public partial class Dashboard : Form
    {
        string connectionString = "DATA SOURCE=localhost:1521/xe;User ID=system;Password=1111";
        public Dashboard()
        {
            InitializeComponent();
            panelAddProduct.Visible = true;
            panelAddReceipe.Visible = false;
            panelAddSupplier.Visible = false;
            panelCostCalculate.Visible = false;
            panelAddWasteMangement.Visible = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inventry_tab_Click(object sender, EventArgs e)
        {

            line1.Left = Btn_inventry.Left;
            line1.Width = Btn_inventry.Width;

            panelAddProduct.Visible = true;
            panelAddReceipe.Visible = false;
            panelAddSupplier.Visible = false;
            panelCostCalculate.Visible = false;
            panelAddWasteMangement.Visible = false;
        }

        private void Receipe_tab_Click(object sender, EventArgs e)
        {
            line1.Left = Btn_receipe.Left;
            line1.Width = Btn_receipe.Width;

            panelAddProduct.Visible = false;
            panelAddReceipe.Visible = true;
            panelAddSupplier.Visible = false;
            panelCostCalculate.Visible = false;
            panelAddWasteMangement.Visible = false;
        }

        private void Supplier_tab_Click(object sender, EventArgs e)
        {
            line1.Left = Btn_supplier.Left;
            line1.Width = Btn_supplier.Width;

            panelAddProduct.Visible = false;
            panelAddReceipe.Visible = false;
            panelAddSupplier.Visible = true;
            panelCostCalculate.Visible = false;
            panelAddWasteMangement.Visible = false;
        }

        private void Waste_manage_tab_Click(object sender, EventArgs e)
        {
            line1.Left = Btn_waste_manage.Left;
            line1.Width = Btn_waste_manage.Width;

            panelAddProduct.Visible = false;
            panelAddReceipe.Visible = false;
            panelAddSupplier.Visible = false;
            panelAddWasteMangement.Visible = true;
            panelCostCalculate.Visible = false;
            
        }

        private void Cost_tab_Click(object sender, EventArgs e)
        {
            line1.Left = Btn_cost.Left;
            line1.Width = Btn_cost.Width;

            panelAddProduct.Visible = false;
            panelAddReceipe.Visible = false;
            panelAddSupplier.Visible = false;
            panelAddWasteMangement.Visible = false;
            panelCostCalculate.Visible = true;
            
        }

        private void bunifuCustomLabel13_Click(object sender, EventArgs e)
        {

        }

        private void panelCostCalculate_Paint(object sender, PaintEventArgs e)
        {

        }



        // --------------------------------------------------- funtions ------------------------------------------------


        public void AddFoodItem(int itemId, string itemName, int quantity, decimal price, DateTime expirationDate)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("sys.add_food_item", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("p_item_id", OracleDbType.Int32).Value = itemId;
                        command.Parameters.Add("p_item_name", OracleDbType.Varchar2).Value = itemName;
                        command.Parameters.Add("p_quantity", OracleDbType.Int32).Value = quantity;
                        command.Parameters.Add("p_price", OracleDbType.Decimal).Value = price;
                        command.Parameters.Add("p_expiration_date", OracleDbType.Date).Value = expirationDate;

                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Data insert successfully! ");
                            connection.Close();
                        }

                        catch (Exception ex) { 
                        
                            MessageBox.Show(ex.Message);    
                        }

                   

                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        ///------------------------------------------------------------------------------------------------------------------ 

        public void Addrecipe(int reciId, string reciName,string reciNote, decimal reciCost)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("sys.add_recipe", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("recipe_id", OracleDbType.Int32).Value = reciId;
                        command.Parameters.Add("recipe_name", OracleDbType.Varchar2).Value = reciName;
                        command.Parameters.Add("notes", OracleDbType.Varchar2).Value = reciNote;
                        command.Parameters.Add("recipe_cost", OracleDbType.Int32).Value = reciCost;


                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Data insert successfully! ");
                            connection.Close();
                        }

                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }



                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // -------------------------------------------------------------------------------------------------------------------------------

        public void AddtotCost(int cost, DateTime date)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("sys.add_daily_cost", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("total_cost", OracleDbType.Int32).Value = cost;
                        command.Parameters.Add("marked_date", OracleDbType.Date).Value = date;

                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Daily Cost saved successfully! ");
                            connection.Close();
                        }

                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }



                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        // -------------------------------------------------------------------------------------------------------------------------------
        public void Addsupp(int suppId, string suppName, int suppPhone, string suppitems)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("sys.add_supplier", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("s_id", OracleDbType.Int32).Value = suppId;
                        command.Parameters.Add("s_name", OracleDbType.Varchar2).Value = suppName;
                        command.Parameters.Add("s_mobile", OracleDbType.Int32).Value = suppPhone;
                        command.Parameters.Add("s_items", OracleDbType.Varchar2).Value = suppitems;


                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Data insert successfully! ");
                            connection.Close();
                        }

                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }



                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        // ----------------------------------------------------------------------------------------------------------------
        
        public void UpdateInventory(int itemId, int quantity)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("sys.update_inventory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("p_item_id", OracleDbType.Int32).Value = itemId;
                        command.Parameters.Add("p_quantity", OracleDbType.Int32).Value = quantity;


                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Data is updated successfully! ");
                            connection.Close();
                        }

                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }

                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public DataTable GetInventory()
        {
            DataTable inventoryTable = new DataTable();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("SELECT * FROM sys.food_inventory", connection))
                    {
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            adapter.Fill(inventoryTable);

                            invView.DataSource = inventoryTable;

                            connection.Close();
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return inventoryTable;
        }

        // ---------------------------------------------------------------------------------------------------------------------



        public DataTable Getrecipe()
        {
            DataTable inventoryTable = new DataTable();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("SELECT * FROM sys.recipe", connection))
                    {
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            adapter.Fill(inventoryTable);

                            rece_view.DataSource = inventoryTable;

                            connection.Close();
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return inventoryTable;
        }

        //------------------------------------------------------------------------------------------------------------------------

        public DataTable GetSupplier()
        {
            DataTable inventoryTable = new DataTable();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("SELECT * FROM sys.supplier", connection))
                    {
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            adapter.Fill(inventoryTable);

                            suppView.DataSource = inventoryTable;

                            connection.Close();
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return inventoryTable;
        }

        //--------------------------------------------------------------------------------------------------------------------------

        public void Deleterecipe(int RId)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("DELETE FROM sys.recipe WHERE recipe_id = :rId", connection))
                    {
                        command.Parameters.Add(":rId", OracleDbType.Int32).Value = RId;
                        command.ExecuteNonQuery();
                        MessageBox.Show("Recepe Deleted successfully! ");
                        connection.Close();
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public void DeleteSupplier(int SId)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("DELETE FROM sys.supplier WHERE supplier_id = :sId", connection))
                    {
                        command.Parameters.Add(":sId", OracleDbType.Int32).Value = SId;
                        command.ExecuteNonQuery();
                        MessageBox.Show("Supplier Deleted successfully! ");
                        connection.Close();
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // ----------------------------------------------------------------------------------------------------

        public void updateSupplier(int suppId, string suppItem)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("UPDATE sys.supplier SET supplier_Items = :suppItems WHERE supplier_id = :suppId", connection))
                   
                    {

                        command.Parameters.Add(new OracleParameter("suppId", suppId));
                        command.Parameters.Add(new OracleParameter("suppItems", suppItem));
                        
                        command.ExecuteNonQuery();
                        MessageBox.Show("Item updated successfully! ");
                        connection.Close();
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // ----------------------------------------------------------------------------------------------------------------------- 

        public DataTable GetSelectedrecipe(string category)
        {
            DataTable recipeTable = new DataTable();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "BEGIN " +
                                              "  OPEN :cursor FOR " +
                                              "  SELECT * FROM sys.recipe WHERE recipe_name = :category; " +
                                              "END;";

                        OracleParameter cursorParam = new OracleParameter();
                        cursorParam.ParameterName = ":cursor";
                        cursorParam.Direction = ParameterDirection.Output;
                        cursorParam.OracleDbType = OracleDbType.RefCursor;

                        OracleParameter categoryParam = new OracleParameter();
                        categoryParam.ParameterName = ":category";
                        categoryParam.OracleDbType = OracleDbType.Varchar2;
                        categoryParam.Value = category;

                        command.Parameters.Add(cursorParam);
                        command.Parameters.Add(categoryParam);

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            recipeTable.Load(reader);
                            rece_view.DataSource = recipeTable;
                            reader.Close();
                        }
                    }

                    connection.Close();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return recipeTable;
        }


        // -----------------------------------------------------------------------------------------------------------------

        public DataTable GetSelectedsupplier(string name)
        {
            DataTable recipeTable = new DataTable();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "BEGIN " +
                                              "  OPEN :cursor FOR " +
                                              "  SELECT * FROM sys.supplier WHERE supplier_name = :sname; " +
                                              "END;";

                        OracleParameter cursorParam = new OracleParameter();
                        cursorParam.ParameterName = ":cursor";
                        cursorParam.Direction = ParameterDirection.Output;
                        cursorParam.OracleDbType = OracleDbType.RefCursor;

                        OracleParameter categoryParam = new OracleParameter();
                        categoryParam.ParameterName = ":sname";
                        categoryParam.OracleDbType = OracleDbType.Varchar2;
                        categoryParam.Value = name;

                        command.Parameters.Add(cursorParam);
                        command.Parameters.Add(categoryParam);

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            recipeTable.Load(reader);
                            supp_view.DataSource = recipeTable;
                            reader.Close();
                        }
                    }

                    connection.Close();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return recipeTable;
        }

        //----------------------------------------------------------------------------------------------------------- button working

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lbl_id.Text = Login.main_id;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Login login = new Login();  
            login.Show();
            this.Hide();
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            int itemId = Convert.ToInt32(pid.Text);
            string itemName = p_name.Text;
            int quantity = Convert.ToInt32(p_qua.Text);
            decimal price = Convert.ToDecimal(p_price.Text);
            DateTime expirationDate = exp_date.Value;

            AddFoodItem(itemId, itemName, quantity, price, expirationDate);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            int itemId = Convert.ToInt32(update_pid.Text);
            int quantity = Convert.ToInt32(update_pqua.Text);

            UpdateInventory(itemId, quantity);
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

            Getrecipe();
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int RId = int.Parse(test2.Text);
            string RName = r_name.Text;
            string RNote = r_note.Text;
            int RCost = int.Parse(r_cost.Text);

            Addrecipe(RId, RName, RNote, RCost);

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            // remove recipe
            int RId = int.Parse(test2.Text);

            Deleterecipe(RId);

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            // selected recipe 

            string recipeName = r_name.Text;    

            GetSelectedrecipe(recipeName);

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            // add supp
            int sId = int.Parse(supp_id.Text);
            string sName = supp_name.Text;
            int Smobile = int.Parse(supp_phone.Text);
            string sItems = supp_items.Text;

            Addsupp(sId,sName,Smobile,sItems);

        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            //check supplier

            string suppName = supp_name.Text;  
            GetSelectedsupplier(suppName);
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {

            // update supplier
            int sId = int.Parse(supp_id.Text);
            string sItems = supp_items.Text;

            updateSupplier(sId, sItems);
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            //delete supp
            int sId = int.Parse(supp_id.Text);
            DeleteSupplier(sId);

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            int Inv = int.Parse(inv_price.Text);
            int supp = int.Parse(supp_pay.Text);
            int cook = int.Parse(cook_pay.Text);
            int EleBill = int.Parse(ele_bill.Text);

            int total = Inv + supp + cook + EleBill;

            tot.Text = total.ToString();

        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            int Inv = int.Parse(inv_price.Text);
            int supp = int.Parse(supp_pay.Text);
            int cook = int.Parse(cook_pay.Text);
            int EleBill = int.Parse(ele_bill.Text);

            int total = Inv + supp + cook + EleBill;


            DateTime MDate = datepick_cost.Value;

            AddtotCost(total, MDate);

        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            // check all

            GetInventory();
            GetSupplier();

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            DevInfo devInfo = new DevInfo();   
            devInfo.Show();
        }
    }


}
