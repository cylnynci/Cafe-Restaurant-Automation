namespace GirisForm
{
    partial class FrmGrs
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.CbKullanici = new System.Windows.Forms.ComboBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CbKullanici
            // 
            this.CbKullanici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbKullanici.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbKullanici.FormattingEnabled = true;
            this.CbKullanici.Location = new System.Drawing.Point(969, 152);
            this.CbKullanici.Name = "CbKullanici";
            this.CbKullanici.Size = new System.Drawing.Size(220, 31);
            this.CbKullanici.TabIndex = 0;
            this.CbKullanici.SelectedIndexChanged += new System.EventHandler(this.CbKullanici_SelectedIndexChanged);
            // 
            // TxtSifre
            // 
            this.TxtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(970, 189);
            this.TxtSifre.Multiline = true;
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(219, 31);
            this.TxtSifre.TabIndex = 1;
            this.TxtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackgroundImage = global::GirisForm.Properties.Resources._11842_kucuk1;
            this.BtnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGiris.Location = new System.Drawing.Point(935, 236);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(150, 40);
            this.BtnGiris.TabIndex = 2;
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackgroundImage = global::GirisForm.Properties.Resources.Screenshot_2018_09_05_12_37_05_e15361403376171;
            this.BtnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCikis.Location = new System.Drawing.Point(1091, 236);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(146, 40);
            this.BtnCikis.TabIndex = 2;
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::GirisForm.Properties.Resources.k_02211710_Hosgeldiniz;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(838, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(351, 90);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(834, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(908, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // FrmGrs
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GirisForm.Properties.Resources.white_pure_orchid_flower_spiral_notepad_pencil_coffee_cup_blue_background_23_2148066489;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 559);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.CbKullanici);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGrs";
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.FrmGrs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbKullanici;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

