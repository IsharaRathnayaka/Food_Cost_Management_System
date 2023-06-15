using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_project2
{
    public partial class DevInfo : Form
    {
        public DevInfo()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/KavinduLakmal2000");
            Process.Start(sInfo);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/IsharaRathnayaka");
            Process.Start(sInfo);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/MDCDCHAMATHKA");
            Process.Start(sInfo);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/MadhushaniRajakaruna");
            Process.Start(sInfo);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/Dananuvindu");
            Process.Start(sInfo);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
