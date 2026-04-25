using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace APp
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect, int nTopRect,
        int nRightRect, int nBottomRect,
        int nWidthEllipse, int nHeightEllipse);

        Uc sayfaTarayici = new Uc();
        UserControl1 sayfasettings = new UserControl1();
        public Form1()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panel1.BackColor = Color.FromArgb(20, 20, 28);

            // Başlık label
            lblBaslik.Text = "⚡ MULTRON PORT SCANNER";
            lblBaslik.ForeColor = Color.FromArgb(200, 180, 60); // sarı
            lblBaslik.Font = new Font("Consolas", 11, FontStyle.Bold);
            lblVersiyon.Text = "v0.1.0 Beta";
            lblVersiyon.ForeColor = Color.FromArgb(120, 110, 40); // sarının soluk hali
            lblVersiyon.Font = new Font("Consolas", 7, FontStyle.Regular);
            // Ayarlar butonu
            guna2Button2.FillColor = Color.FromArgb(35, 35, 45);
            guna2Button2.BorderColor = Color.FromArgb(200, 180, 60);
            guna2Button2.BorderThickness = 1;
            guna2Button2.ForeColor = Color.FromArgb(200, 180, 60);
            guna2Button2.BorderRadius = 8;
            guna2Button2.Text = "⚙ Ayarlar";

            // Tara butonu
            guna2Button1.FillColor = Color.FromArgb(200, 180, 60);
            guna2Button1.ForeColor = Color.FromArgb(20, 20, 28);
            guna2Button1.BorderThickness = 0;
            guna2Button1.BorderRadius = 8;
            guna2Button1.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            guna2Button1.Text = "▶ Tara";
            // Çıkış butonu
            guna2Button3.FillColor = Color.FromArgb(35, 35, 45);
            guna2Button3.BorderColor = Color.FromArgb(180, 40, 40);
            guna2Button3.BorderThickness = 1;
            guna2Button3.ForeColor = Color.FromArgb(180, 40, 40);
            guna2Button3.BorderRadius = 8;
            guna2Button3.Text = "✕";
            guna2Button3.Size = new Size(36, 30);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Üst bar paneli
        guna2Button3.MouseEnter += (s, ev) =>
            guna2Button3.FillColor = Color.FromArgb(180, 40, 40);

        guna2Button3.MouseLeave += (s, ev) =>
                guna2Button3.FillColor = Color.FromArgb(35, 35, 45);
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }
        // Üst bar paneline mouse events
        private Point panel1_mouseDown;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1_mouseDown = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(
                    this.Left + e.X - panel1_mouseDown.X,
                    this.Top + e.Y - panel1_mouseDown.Y);
        }

        private void SayfayiGoster(UserControl sayfa)
        {
            pnlIcerik.Controls.Clear();
            sayfa.Dock = DockStyle.Fill;
            pnlIcerik.Controls.Add(sayfa);
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SayfayiGoster(sayfaTarayici);
        }
        private void pnlIcerik_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SayfayiGoster(sayfasettings);
        }



        // 'pnlIcerik' alanının erişim düzeyini 'public' olarak değiştirin

    }
}
