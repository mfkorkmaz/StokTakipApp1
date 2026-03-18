using StokTakipApp1.Entities;
using StokTakipApp1.Repositories;

namespace StokTakipApp1.Forms
{
    public partial class StokForm : Form
    {
        UrunRepository urunRepo = new UrunRepository();
        GenelRepository<Kategori> kategoriRepo = new GenelRepository<Kategori>();

        public StokForm()
        {
            InitializeComponent();
        }

        private async void StokForm_Load(object sender, EventArgs e)
        {
            await ListeYenile();
            await KategorileriYukle();
        }

        private async Task ListeYenile()
        {
            var urunler = await urunRepo.TumunuKategoriyleGetir();
            dataGridView1.DataSource = urunler;
        }

        private async Task KategorileriYukle()
        {
            var kategoriler = await kategoriRepo.HepsiniGetir();
            cmbKategori.DataSource = kategoriler;
            cmbKategori.DisplayMember = "Ad";
            cmbKategori.ValueMember = "Id";
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            var urun = new Urun
            {
                Ad = txtAd.Text,
                Fiyat = double.Parse(txtFiyat.Text),
                StokMiktari = int.Parse(txtStok.Text),
                KategoriId = (int)cmbKategori.SelectedValue,
                EklemeTarihi = DateTime.Now
            };
            await urunRepo.Ekle(urun);
            await ListeYenile();
            Temizle();
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                var urun = new Urun
                {
                    Id = id,
                    Ad = txtAd.Text,
                    Fiyat = double.Parse(txtFiyat.Text),
                    StokMiktari = int.Parse(txtStok.Text),
                    KategoriId = (int)cmbKategori.SelectedValue,
                    EklemeTarihi = DateTime.Now
                };
                await urunRepo.Guncelle(urun);
                await ListeYenile();
                Temizle();
            }
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                await urunRepo.Sil(id);
                await ListeYenile();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtAd.Text = dataGridView1.SelectedRows[0].Cells["Ad"].Value.ToString();
                txtFiyat.Text = dataGridView1.SelectedRows[0].Cells["Fiyat"].Value.ToString();
                txtStok.Text = dataGridView1.SelectedRows[0].Cells["StokMiktari"].Value.ToString();
            }
        }

        private void Temizle()
        {
            txtAd.Clear();
            txtFiyat.Clear();
            txtStok.Clear();
        }
    }
}