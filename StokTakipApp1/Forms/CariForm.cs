using StokTakipApp1.Entities;
using StokTakipApp1.Repositories;

namespace StokTakipApp1.Forms
{
    public partial class CariForm : Form
    {
        MusteriRepository musteriRepo = new MusteriRepository();

        public CariForm()
        {
            InitializeComponent();
        }

        private async void CariForm_Load(object sender, EventArgs e)
        {
            await ListeYenile();
        }

        private async Task ListeYenile()
        {
            var musteriler = await musteriRepo.HepsiniGetir();
            dataGridView1.DataSource = musteriler;
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            var musteri = new Musteri
            {
                Ad = txtAd.Text,
                Telefon = txtTelefon.Text,
                Adres = txtAdres.Text,
                KayitTarihi = DateTime.Now
            };
            await musteriRepo.Ekle(musteri);
            await ListeYenile();
            Temizle();
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                var musteri = new Musteri
                {
                    Id = id,
                    Ad = txtAd.Text,
                    Telefon = txtTelefon.Text,
                    Adres = txtAdres.Text,
                    KayitTarihi = DateTime.Now
                };
                await musteriRepo.Guncelle(musteri);
                await ListeYenile();
                Temizle();
            }
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                await musteriRepo.Sil(id);
                await ListeYenile();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtAd.Text = dataGridView1.SelectedRows[0].Cells["Ad"].Value.ToString();
                txtTelefon.Text = dataGridView1.SelectedRows[0].Cells["Telefon"].Value.ToString();
                txtAdres.Text = dataGridView1.SelectedRows[0].Cells["Adres"].Value.ToString();
            }
        }

        private void Temizle()
        {
            txtAd.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
        }
    }
}