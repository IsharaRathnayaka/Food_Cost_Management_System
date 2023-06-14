using Oracle.ManagedDataAccess.Client;
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

                    using (OracleCommand command = new OracleCommand("SELECT * FROM food_inventory", connection))
                    {
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            adapter.Fill(inventoryTable);
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
    }


}
