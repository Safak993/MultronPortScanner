using FastColoredTextBoxNS;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APp
{
    public partial class Uc : UserControl
    {
        private readonly TextStyle styleYesil = new TextStyle(new SolidBrush(Color.LimeGreen), null, FontStyle.Regular);
        private readonly TextStyle styleKirmizi = new TextStyle(new SolidBrush(Color.Red), null, FontStyle.Regular);
        private readonly TextStyle styleSari = new TextStyle(new SolidBrush(Color.Yellow), null, FontStyle.Regular);
        private readonly TextStyle styleGri = new TextStyle(new SolidBrush(Color.Gray), null, FontStyle.Regular);
        private readonly TextStyle styleCyan = new TextStyle(new SolidBrush(Color.Cyan), null, FontStyle.Regular);
        private readonly TextStyle styleOrange = new TextStyle(new SolidBrush(Color.Orange), null, FontStyle.Regular);

        public Uc()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.BackColor = Color.White;
            richTextBox1.BackColor = Color.White;
            richTextBox1.ForeColor = Color.LimeGreen;
            richTextBox1.Font = new Font("Consolas", 10);
            richTextBox1.ReadOnly = true;

            // Görsel Panel Ayarları
            Panel panel = new Panel();
            panel.Size = richTextBox1.Size;
            panel.Location = richTextBox1.Location;
            panel.BackColor = Color.FromArgb(30, 30, 30);

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            panel.Region = new Region(path);

            if (richTextBox1.Parent != null)
                richTextBox1.Parent.Controls.Remove(richTextBox1);

            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Dock = DockStyle.Fill;
            panel.Controls.Add(richTextBox1);
            this.Controls.Add(panel);
        }

        private void AppendRenkli(string text, Color renk)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.BeginInvoke(new Action(() => AppendRenkli(text, renk)));
                return;
            }

            TextStyle style;
            if (renk == Color.LimeGreen) style = styleYesil; // manuel 
            else if (renk == Color.Red) style = styleKirmizi;
            else if (renk == Color.Yellow) style = styleSari;
            else if (renk == Color.Gray) style = styleGri;
            else if (renk == Color.Cyan) style = styleCyan;
            else if (renk == Color.Orange) style = styleOrange;
            else style = styleYesil;

            richTextBox1.AppendText(text + Environment.NewLine, style);
            richTextBox1.GoEnd();
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            guna2Button1.Enabled = false;

            // DİKKAT: Verileri ayarlar dosyasından çekiyoruz
            // Eğer Settings'teki isimlerin farklıysa buraları onlara göre düzelt
            string hedef = GlobalData.HedefIP;
            string baslangicStr = GlobalData.BaslangicPort;
            string bitisStr = GlobalData.BitisPort;
            string work = GlobalData.work;
            string timeout = GlobalData.timeout;
            string servisTarama = GlobalData.Servis_Tarama;
            
            if (work == "200")
            {
                AppendRenkli("-------- Hızlı Tarama Modu Seçildi --------", Color.Orange);
            }
            else
            {
                AppendRenkli("-------- Normal Tarama Modu Seçildi --------", Color.Orange);
            }
            // Ayar kontrolü
            if (!int.TryParse(baslangicStr, out int start) || !int.TryParse(bitisStr, out int end))
            {
                AppendRenkli("HATA: Ayarlar geçersiz!", Color.Red);
                guna2Button1.Enabled = true;
                return;
            }

            int toplamPort = end - start + 1;
            guna2CircleProgressBar1.Minimum = 0;
            guna2CircleProgressBar1.Maximum = toplamPort;
            guna2CircleProgressBar1.Value = 0;

            await Task.Run(() =>
            {
                int acikPortSayisi = 0;
                int tamamlanan = 0;

                try
                {
                    using (Process process = new Process())
                    {
                        process.StartInfo.FileName = "python";
                        process.StartInfo.Arguments = $"-u tarama.py {hedef} {start} {end} {work} {timeout} {servisTarama}";
                        process.StartInfo.RedirectStandardOutput = true;
                        process.StartInfo.RedirectStandardError = true;
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.CreateNoWindow = true;
                        process.Start();

                        while (!process.StandardOutput.EndOfStream)
                        {
                            // Karakter karakter oku
                            int readChar = process.StandardOutput.Read();
                            if (readChar == -1) break;

                            char c = (char)readChar;

                            // Eğer gelen karakter 'P' ise barı ilerlet
                            if (c == 'P')
                            {
                                tamamlanan++;
                                int currentTamamlanan = tamamlanan;
                                int currentToplam = toplamPort;

                                this.BeginInvoke(new Action(() => {
                                    if (!guna2CircleProgressBar1.IsDisposed)
                                        guna2CircleProgressBar1.Value = Math.Min(currentTamamlanan, currentToplam);
                                }));
                            }
                            // Eğer gelen karakter '|' ise satırın geri kalanını (port bilgisini) oku
                            else if (c == '|')
                            {
                                string line = process.StandardOutput.ReadLine();
                                if (string.IsNullOrEmpty(line)) continue;
                                string currentLine = line;

                                this.BeginInvoke(new Action(() => {
                                    
                                    if (currentLine.StartsWith("ACIK:"))
                                    {
                                        acikPortSayisi++;
                                        AppendRenkli("[ACIK] Port " + currentLine.Split(':')[1], Color.LimeGreen);
                                    }
                                    else if (currentLine.Contains("BITTI"))
                                    {
                                        AppendRenkli("------------------------------", Color.Gray);
                                        AppendRenkli($"Tarama Tamamlandı! {acikPortSayisi} açık port bulundu.", Color.Cyan);
                                    }
                                    
                                    else if (currentLine.StartsWith("PING kontrol"))
                                    {
                                        AppendRenkli($"Hedef: {hedef}", Color.Orange);
                                        AppendRenkli("[*] Host kontrol ediliyor...", Color.Yellow);

                                    }
                                    else if (currentLine.StartsWith("PING_OK"))
                                    {
                                        
                                        AppendRenkli("[+] Host aktif, tarama başlıyor...", Color.LimeGreen);
                                    }
                                    else if (currentLine.StartsWith("PING_BASARISIZ"))
                                    {
                                        AppendRenkli("[!] Host'a ulaşılamadı!", Color.Red);
                                        AppendRenkli("[*] Firewall ping'i bloklıyor olabilir.", Color.Orange);
                                    }
                                }));
                            }
                        }
                        process.WaitForExit();
                    }
                }
                catch (Exception ex)
                {
                    this.BeginInvoke(new Action(() => AppendRenkli("Sistem Hatası: " + ex.Message, Color.Red)));
                }
                finally
                {
                    this.BeginInvoke(new Action(() => {
                        if (!guna2Button1.IsDisposed) guna2Button1.Enabled = true;
                    }));
                }
            });
        }

        // Tasarımcı hatalarını önlemek için boş event'ler
        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            // Ana formu bul (Form1 olduğunu varsayıyoruz)
            var anaForm = this.FindForm() as Form1;

            if (guna2ToggleSwitch1.Checked)
            {
                // --- DARK MODE RENKLERİ ---
                Color darkBg = Color.FromArgb(33, 37, 43); // Atom/OneDark tarzı koyu gri

                this.BackColor = darkBg;

                if (anaForm != null && anaForm.panel1 != null)
                {
                    richTextBox1.BackColor = darkBg; // RichTextBox için biraz daha koyu bir renk
                    // Eğer formda başka kontroller varsa onları da buradan boyayabilirsin
                }

                // RichTextBox zaten koyu olduğu için ona dokunmuyoruz 
                // ama istersen kenarlık renklerini vs. güncelleyebilirsin.
            }
            else
            {
                // --- LIGHT MODE RENKLERİ ---
                Color lightBg = Color.White;

                this.BackColor = lightBg;

                if (anaForm != null && anaForm.panel1 != null)
                {
                    richTextBox1.BackColor = lightBg; // RichTextBox için açık renk
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e) { }
        private void Uc_Load(object sender, EventArgs e) { }
    }
}