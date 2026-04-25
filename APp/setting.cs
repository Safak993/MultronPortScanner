using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APp
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private void txtIP_TextChanged(object sender, EventArgs e)
        {
            GlobalData.HedefIP = txtIP.Text;
        }
        private void txtBaslangic_TextChanged(object sender, EventArgs e)
        {
            GlobalData.BaslangicPort = txtBaslangic.Text;
        }
        private void txtBitis_TextChanged(object sender, EventArgs e)
        {
            GlobalData.BitisPort = txtBitis.Text;
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                txtBaslangic.Text = "1";
                txtBitis.Text = "65535"; // Hızlı tarama için başlangıç ve bitiş portlarını otomatik olarak ayarla
            }
            else
            {
                txtBaslangic.Text = "1";
                txtBitis.Text = "1024"; // Normal tarama için başlangıç ve bitiş portlarını varsayılan değerlere döndür
            }
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                GlobalData.work = "200";
                GlobalData.timeout = "0.1"; // Hızlı tarama için başlangıç ve bitiş portlarını otomatik olarak ayarla
            }
            else
            {
                GlobalData.work = "100";
                GlobalData.timeout = "0.3"; // Normal tarama için başlangıç ve bitiş portlarını varsayılan değerlere döndür
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch3_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch3.Checked)
            {
                GlobalData.Servis_Tarama = "True";
            }
            else
            {
                GlobalData.Servis_Tarama = "False";
            }
        }
    }
}
