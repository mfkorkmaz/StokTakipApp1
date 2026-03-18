namespace StokTakipApp1.Forms
{
    partial class SatisForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbMusteri = new ComboBox();
            this.cmbUrun = new ComboBox();
            this.txtAdet = new TextBox();
            this.btnSatisEkle = new Button();
            this.btnSatisTamamla = new Button();
            this.dataGridView1 = new DataGridView();
            this.lblMusteri = new Label();
            this.lblUrun = new Label();
            this.lblAdet = new Label();
            this.lblToplamTutar = new Label();
            this.lblTutar = new Label();
            ((System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
            this.SuspendLayout();

            // lblMusteri
            this.lblMusteri.Location = new Point(12, 20);
            this.lblMusteri.Size = new Size(80, 23);
            this.lblMusteri.Text = "Müşteri:";

            // cmbMusteri
            this.cmbMusteri.Location = new Point(100, 17);
            this.cmbMusteri.Size = new Size(200, 23);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.DropDownStyle = ComboBoxStyle.DropDownList;

            // lblUrun
            this.lblUrun.Location = new Point(12, 55);
            this.lblUrun.Size = new Size(80, 23);
            this.lblUrun.Text = "Ürün:";

            // cmbUrun
            this.cmbUrun.Location = new Point(100, 52);
            this.cmbUrun.Size = new Size(200, 23);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.DropDownStyle = ComboBoxStyle.DropDownList;

            // lblAdet
            this.lblAdet.Location = new Point(12, 90);
            this.lblAdet.Size = new Size(80, 23);
            this.lblAdet.Text = "Adet:";

            // txtAdet
            this.txtAdet.Location = new Point(100, 87);
            this.txtAdet.Size = new Size(100, 23);
            this.txtAdet.Name = "txtAdet";

            // btnSatisEkle
            this.btnSatisEkle.Location = new Point(12, 130);
            this.btnSatisEkle.Size = new Size(120, 30);
            this.btnSatisEkle.Text = "Sepete Ekle";
            this.btnSatisEkle.Name = "btnSatisEkle";
            this.btnSatisEkle.BackColor = Color.FromArgb(0, 123, 255);
            this.btnSatisEkle.ForeColor = Color.White;
            this.btnSatisEkle.FlatStyle = FlatStyle.Flat;
            this.btnSatisEkle.Click += new EventHandler(this.btnSatisEkle_Click);

            // btnSatisTamamla
            this.btnSatisTamamla.Location = new Point(140, 130);
            this.btnSatisTamamla.Size = new Size(120, 30);
            this.btnSatisTamamla.Text = "Satışı Tamamla";
            this.btnSatisTamamla.Name = "btnSatisTamamla";
            this.btnSatisTamamla.BackColor = Color.FromArgb(40, 167, 69);
            this.btnSatisTamamla.ForeColor = Color.White;
            this.btnSatisTamamla.FlatStyle = FlatStyle.Flat;
            this.btnSatisTamamla.Click += new EventHandler(this.btnSatisTamamla_Click);

            // lblToplamTutar
            this.lblToplamTutar.Location = new Point(12, 175);
            this.lblToplamTutar.Size = new Size(100, 23);
            this.lblToplamTutar.Text = "Toplam Tutar:";
            this.lblToplamTutar.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // lblTutar
            this.lblTutar.Location = new Point(120, 175);
            this.lblTutar.Size = new Size(150, 23);
            this.lblTutar.Text = "0,00 TL";
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.lblTutar.ForeColor = Color.FromArgb(40, 167, 69);

            // dataGridView1
            this.dataGridView1.Location = new Point(12, 210);
            this.dataGridView1.Size = new Size(760, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.AllowUserToAddRows = false;

            // SatisForm
            this.ClientSize = new Size(800, 580);
            this.Text = "Satış Formu";
            this.Controls.Add(this.lblMusteri);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.lblUrun);
            this.Controls.Add(this.cmbUrun);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.btnSatisEkle);
            this.Controls.Add(this.btnSatisTamamla);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.dataGridView1);
            this.Load += new EventHandler(this.SatisForm_Load);
            ((System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private ComboBox cmbMusteri;
        private ComboBox cmbUrun;
        private TextBox txtAdet;
        private Button btnSatisEkle;
        private Button btnSatisTamamla;
        private DataGridView dataGridView1;
        private Label lblMusteri;
        private Label lblUrun;
        private Label lblAdet;
        private Label lblToplamTutar;
        private Label lblTutar;
    }
}
