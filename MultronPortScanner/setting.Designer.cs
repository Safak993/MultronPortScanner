namespace APp
{
    partial class UserControl1
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBaslangic = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBitis = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ToggleSwitch2 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ToggleSwitch3 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2ToggleSwitch4 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.BorderColor = System.Drawing.Color.Black;
            this.txtBaslangic.BorderRadius = 20;
            this.txtBaslangic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBaslangic.DefaultText = "";
            this.txtBaslangic.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBaslangic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBaslangic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBaslangic.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBaslangic.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBaslangic.FillColor = System.Drawing.Color.DimGray;
            this.txtBaslangic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBaslangic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBaslangic.ForeColor = System.Drawing.Color.White;
            this.txtBaslangic.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBaslangic.Location = new System.Drawing.Point(0, 62);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.PlaceholderText = "Kaçıncı porttan başlasın";
            this.txtBaslangic.SelectedText = "";
            this.txtBaslangic.Size = new System.Drawing.Size(153, 62);
            this.txtBaslangic.TabIndex = 0;
            this.txtBaslangic.TextChanged += new System.EventHandler(this.txtBaslangic_TextChanged);
            // 
            // txtIP
            // 
            this.txtIP.BorderColor = System.Drawing.Color.Yellow;
            this.txtIP.BorderRadius = 20;
            this.txtIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIP.DefaultText = "";
            this.txtIP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIP.FillColor = System.Drawing.Color.DimGray;
            this.txtIP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIP.ForeColor = System.Drawing.Color.White;
            this.txtIP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIP.Location = new System.Drawing.Point(0, 0);
            this.txtIP.Name = "txtIP";
            this.txtIP.PlaceholderText = "Taranacak IP yi giriniz";
            this.txtIP.SelectedText = "";
            this.txtIP.Size = new System.Drawing.Size(153, 62);
            this.txtIP.TabIndex = 1;
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // txtBitis
            // 
            this.txtBitis.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txtBitis.BorderRadius = 20;
            this.txtBitis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBitis.DefaultText = "";
            this.txtBitis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBitis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBitis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBitis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBitis.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBitis.FillColor = System.Drawing.Color.DimGray;
            this.txtBitis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBitis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBitis.ForeColor = System.Drawing.Color.White;
            this.txtBitis.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBitis.Location = new System.Drawing.Point(0, 124);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.PlaceholderText = "Kaçıncı porttan bitsin";
            this.txtBitis.SelectedText = "";
            this.txtBitis.Size = new System.Drawing.Size(153, 62);
            this.txtBitis.TabIndex = 2;
            this.txtBitis.TextChanged += new System.EventHandler(this.txtBitis_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBitis);
            this.panel1.Controls.Add(this.txtBaslangic);
            this.panel1.Controls.Add(this.txtIP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 413);
            this.panel1.TabIndex = 3;
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.Animated = true;
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(200, 380);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(68, 20);
            this.guna2ToggleSwitch1.TabIndex = 4;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(185, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "-p- (All ports)";
            // 
            // guna2ToggleSwitch2
            // 
            this.guna2ToggleSwitch2.Animated = true;
            this.guna2ToggleSwitch2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch2.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.Location = new System.Drawing.Point(319, 380);
            this.guna2ToggleSwitch2.Name = "guna2ToggleSwitch2";
            this.guna2ToggleSwitch2.Size = new System.Drawing.Size(68, 20);
            this.guna2ToggleSwitch2.TabIndex = 6;
            this.guna2ToggleSwitch2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch2.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(331, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fast ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(432, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "-sS(⚠️ SVC Scan)";
            // 
            // guna2ToggleSwitch3
            // 
            this.guna2ToggleSwitch3.Animated = true;
            this.guna2ToggleSwitch3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch3.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch3.Location = new System.Drawing.Point(462, 380);
            this.guna2ToggleSwitch3.Name = "guna2ToggleSwitch3";
            this.guna2ToggleSwitch3.Size = new System.Drawing.Size(68, 20);
            this.guna2ToggleSwitch3.TabIndex = 9;
            this.guna2ToggleSwitch3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch3.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch3.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch3.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch3_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(321, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "(Svc risk)";
            // 
            // guna2ToggleSwitch4
            // 
            this.guna2ToggleSwitch4.Animated = true;
            this.guna2ToggleSwitch4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch4.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch4.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch4.Location = new System.Drawing.Point(599, 380);
            this.guna2ToggleSwitch4.Name = "guna2ToggleSwitch4";
            this.guna2ToggleSwitch4.Size = new System.Drawing.Size(68, 20);
            this.guna2ToggleSwitch4.TabIndex = 11;
            this.guna2ToggleSwitch4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch4.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch4.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(602, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "No Ping";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2ToggleSwitch4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2ToggleSwitch3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2ToggleSwitch2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ToggleSwitch1);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(735, 413);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox txtBaslangic;
        public Guna.UI2.WinForms.Guna2TextBox txtIP;
        public Guna.UI2.WinForms.Guna2TextBox txtBitis;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch4;
        private System.Windows.Forms.Label label5;
    }
}
