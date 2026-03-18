namespace StokTakipApp1.Forms
{
    partial class StokForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtAd = new TextBox();
            this.txtFiyat = new TextBox();
            this.txtStok = new TextBox();
            this.cmbKategori = new ComboBox();
            this.btnEkle = new Button();
            this.btnGuncelle = new Button();
            this.btnSil = new Button();
            this.dataGridView1 = new DataGridView();
            this.lblAd = new Label();
            this.lblFiyat = new Label();
            this.lblStok = new Label();
            this.lblKategori = new Label();
            ((System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
            this.SuspendLayout();

            // lblAd
            this.lblAd.Location = new Point(12, 20);
            this.lblAd.Size = new Size(80, 23);
            this.lblAd.Text = "Ürün Adı:";

            // txtAd
            this.txtAd.Location = new Point(100, 17);
            this.txtAd.Size = new Size(200, 23);
            this.txtAd.Name = "txtAd";

            // lblFiyat
            this.lblFiyat.Location = new Point(12, 55);
            this.lblFiyat.Size = new Size(80, 23);
            this.lblFiyat.Text = "Fiyat:";

            // txtFiyat
            this.txtFiyat.Location = new Point(100, 52);
            this.txtFiyat.Size = new Size(200, 23);
            this.txtFiyat.Name = "txtFiyat";

            // lblStok
            this.lblStok.Location = new Point(12, 90);
            this.lblStok.Size = new Size(80, 23);
            this.lblStok.Text = "Stok:";

            // txtStok
            this.txtStok.Location = new Point(100, 87);
            this.txtStok.Size = new Size(200, 23);
            this.txtStok.Name = "txtStok";

            // lblKategori
            this.lblKategori.Location = new Point(12, 125);
            this.lblKategori.Size = new Size(80, 23);
            this.lblKategori.Text = "Kategori:";

            // cmbKategori
            this.cmbKategori.Location = new Point(100, 122);
            this.cmbKategori.Size = new Size(200, 23);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;

            // btnEkle
            this.btnEkle.Location = new Point(12, 165);
            this.btnEkle.Size = new Size(90, 30);
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.BackColor = Color.FromArgb(40, 167, 69);
            this.btnEkle.ForeColor = Color.White;
            this.btnEkle.FlatStyle = FlatStyle.Flat;
            this.btnEkle.Click += new EventHandler(this.btnEkle_Click);

            // btnGuncelle
            this.btnGuncelle.Location = new Point(110, 165);
            this.btnGuncelle.Size = new Size(90, 30);
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.BackColor = Color.FromArgb(0, 123, 255);
            this.btnGuncelle.ForeColor = Color.White;
            this.btnGuncelle.FlatStyle = FlatStyle.Flat;
            this.btnGuncelle.Click += new EventHandler(this.btnGuncelle_Click);

            // btnSil
            this.btnSil.Location = new Point(208, 165);
            this.btnSil.Size = new Size(90, 30);
            this.btnSil.Text = "Sil";
            this.btnSil.Name = "btnSil";
            this.btnSil.BackColor = Color.FromArgb(220, 53, 69);
            this.btnSil.ForeColor = Color.White;
            this.btnSil.FlatStyle = FlatStyle.Flat;
            this.btnSil.Click += new EventHandler(this.btnSil_Click);

            // dataGridView1
            this.dataGridView1.Location = new Point(12, 210);
            this.dataGridView1.Size = new Size(760, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.SelectionChanged += new EventHandler(this.dataGridView1_SelectionChanged);

            // StokForm
            this.ClientSize = new Size(800, 580);
            this.Text = "Stok Yönetimi";
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Load += new EventHandler(this.StokForm_Load);
            ((System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private TextBox txtAd;
        private TextBox txtFiyat;
        private TextBox txtStok;
        private ComboBox cmbKategori;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dataGridView1;
        private Label lblAd;
        private Label lblFiyat;
        private Label lblStok;
        private Label lblKategori;
    }
}
