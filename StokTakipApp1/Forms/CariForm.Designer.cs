namespace StokTakipApp1.Forms
{
    partial class CariForm
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
            this.txtTelefon = new TextBox();
            this.txtAdres = new TextBox();
            this.btnEkle = new Button();
            this.btnGuncelle = new Button();
            this.btnSil = new Button();
            this.dataGridView1 = new DataGridView();
            this.lblAd = new Label();
            this.lblTelefon = new Label();
            this.lblAdres = new Label();
            ((System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
            this.SuspendLayout();

            // lblAd
            this.lblAd.Location = new Point(12, 20);
            this.lblAd.Size = new Size(80, 23);
            this.lblAd.Text = "Müşteri Adı:";

            // txtAd
            this.txtAd.Location = new Point(100, 17);
            this.txtAd.Size = new Size(200, 23);
            this.txtAd.Name = "txtAd";

            // lblTelefon
            this.lblTelefon.Location = new Point(12, 55);
            this.lblTelefon.Size = new Size(80, 23);
            this.lblTelefon.Text = "Telefon:";

            // txtTelefon
            this.txtTelefon.Location = new Point(100, 52);
            this.txtTelefon.Size = new Size(200, 23);
            this.txtTelefon.Name = "txtTelefon";

            // lblAdres
            this.lblAdres.Location = new Point(12, 90);
            this.lblAdres.Size = new Size(80, 23);
            this.lblAdres.Text = "Adres:";

            // txtAdres
            this.txtAdres.Location = new Point(100, 87);
            this.txtAdres.Size = new Size(200, 23);
            this.txtAdres.Name = "txtAdres";

            // btnEkle
            this.btnEkle.Location = new Point(12, 130);
            this.btnEkle.Size = new Size(90, 30);
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.BackColor = Color.FromArgb(40, 167, 69);
            this.btnEkle.ForeColor = Color.White;
            this.btnEkle.FlatStyle = FlatStyle.Flat;
            this.btnEkle.Click += new EventHandler(this.btnEkle_Click);

            // btnGuncelle
            this.btnGuncelle.Location = new Point(110, 130);
            this.btnGuncelle.Size = new Size(90, 30);
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.BackColor = Color.FromArgb(0, 123, 255);
            this.btnGuncelle.ForeColor = Color.White;
            this.btnGuncelle.FlatStyle = FlatStyle.Flat;
            this.btnGuncelle.Click += new EventHandler(this.btnGuncelle_Click);

            // btnSil
            this.btnSil.Location = new Point(208, 130);
            this.btnSil.Size = new Size(90, 30);
            this.btnSil.Text = "Sil";
            this.btnSil.Name = "btnSil";
            this.btnSil.BackColor = Color.FromArgb(220, 53, 69);
            this.btnSil.ForeColor = Color.White;
            this.btnSil.FlatStyle = FlatStyle.Flat;
            this.btnSil.Click += new EventHandler(this.btnSil_Click);

            // dataGridView1
            this.dataGridView1.Location = new Point(12, 175);
            this.dataGridView1.Size = new Size(760, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.SelectionChanged += new EventHandler(this.dataGridView1_SelectionChanged);

            // CariForm
            this.ClientSize = new Size(800, 550);
            this.Text = "Cari Listesi";
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Load += new EventHandler(this.CariForm_Load);
            ((System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private TextBox txtAd;
        private TextBox txtTelefon;
        private TextBox txtAdres;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dataGridView1;
        private Label lblAd;
        private Label lblTelefon;
        private Label lblAdres;
    }
}
