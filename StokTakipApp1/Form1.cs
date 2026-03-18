using StokTakipApp1.Forms;

namespace StokTakipApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Stok Takip Uygulamasý";
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            new StokForm().Show();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            new CariForm().Show();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            new SatisForm().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // test commit
        }
    }
}
