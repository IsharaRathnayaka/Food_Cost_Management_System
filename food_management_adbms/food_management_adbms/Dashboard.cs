using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ES_project2
{
    public partial class Dashboard : Form
    {
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
            panelAddProduct.Visible = true;
            panelAddReceipe.Visible = false;
            panelAddSupplier.Visible = false;
            panelCostCalculate.Visible = false;
            panelAddWasteMangement.Visible = false;
        }

        private void Receipe_tab_Click(object sender, EventArgs e)
        {
            panelAddProduct.Visible = false;
            panelAddReceipe.Visible = true;
            panelAddSupplier.Visible = false;
            panelCostCalculate.Visible = false;
            panelAddWasteMangement.Visible = false;
        }

        private void Supplier_tab_Click(object sender, EventArgs e)
        {
            panelAddProduct.Visible = false;
            panelAddReceipe.Visible = false;
            panelAddSupplier.Visible = true;
            panelCostCalculate.Visible = false;
            panelAddWasteMangement.Visible = false;
        }

        private void Waste_manage_tab_Click(object sender, EventArgs e)
        {
            panelAddProduct.Visible = false;
            panelAddReceipe.Visible = false;
            panelAddSupplier.Visible = false;
            panelAddWasteMangement.Visible = true;
            panelCostCalculate.Visible = false;
            
        }

        private void Cost_tab_Click(object sender, EventArgs e)
        {
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
    }
}
