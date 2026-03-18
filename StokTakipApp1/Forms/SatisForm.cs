using StokTakipApp1.Entities;
using StokTakipApp1.Repositories;

namespace StokTakipApp1.Forms
{
    public partial class SatisForm : Form
    {
        UrunRepository urunRepo = new UrunRepository();
        MusteriRepository musteriRepo = new MusteriRepository();
        SatisRepository satisRepo = new SatisRepository();
        GenelRepository<SatisDetay> detayRepo = new GenelRepository<SatisDetay>();

        List<SatisDetay> sepet = new List<SatisDetay>();
        double toplamTutar = 0;

        public SatisForm()
        {
            InitializeComponent();
        }

        private async void SatisForm_Load(object sender, EventArgs e)
        {
            var musteriler = await musteriRepo.HepsiniGetir();
            cmbMusteri.DataSource = musteriler;
            cmbMusteri.DisplayMember = "Ad";
            cmbMusteri.ValueMember = "Id";

            var urunler = await urunRepo.HepsiniGetir();
            cmbUrun.DataSource = urunler;
            cmbUrun.DisplayMember = "Ad";
            cmbUrun.ValueMember = "Id";
        }

        private void btnSatisEkle_Click(object sender, EventArgs e)
        {
            var urun = (Urun)cmbUrun.SelectedItem;
            int adet = int.Parse(txtAdet.Text);

            var detay = new SatisDetay
            {
                UrunId = urun.Id,
                Adet = adet,
                BirimFiyat = urun.Fiyat,
                ToplamFiyat = urun.Fiyat * adet
            };

            sepet.Add(detay);
            toplamTutar += detay.ToplamFiyat;
            lblTutar.Text = $"{toplamTutar:F2} TL";
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sepet.ToList();
        }

        private async void btnSatisTamamla_Click(object sender, EventArgs e)
        {
            if (sepet.Count == 0)
            {
                MessageBox.Show("Sepet boş!");
                return;
            }

            var satis = new Satis
            {
                MusteriId = (int)cmbMusteri.SelectedValue,
                SatisTarihi = DateTime.Now,
                ToplamTutar = toplamTutar,
                SatisDetaylar = sepet
            };

            await satisRepo.Ekle(satis);
            MessageBox.Show($"Satış tamamlandı! Toplam: {toplamTutar:F2} TL");

            sepet.Clear();
            toplamTutar = 0;
            lblTutar.Text = "0,00 TL";
            dataGridView1.DataSource = null;
        }
    }
}