using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsEFCodeFirst
{
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }
        EFCodeFirstModel model = new EFCodeFirstModel();
        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = model.Urunler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKategoriAdi.Text))
            {
                MessageBox.Show("Kategori Ad Boş Geçilemez!");
                return; // dön, aşağıdaki kodları çalıştırma.
            }
            var kategori = new Kategori();
            kategori.KategoriAdi = txtKategoriAdi.Text;
            model.Kategoriler.Add(kategori);
            model.SaveChanges();
            dgvKategoriler.DataSource = model.Kategoriler.ToList();
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            txtKategoriAdi.Text = string.Empty;
        }

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value.ToString());
            var kategori = model.Kategoriler.Find(id);
            txtKategoriAdi.Text = kategori.KategoriAdi;
            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKategoriAdi.Text))
            {
                MessageBox.Show("Kategori Ad Boş Geçilemez!");
                return; // dön, aşağıdaki kodları çalıştırma.
            }
            var id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value.ToString());
            var kategori = model.Kategoriler.Find(id);
            kategori.KategoriAdi = txtKategoriAdi.Text;
            model.SaveChanges();
            dgvKategoriler.DataSource = model.Kategoriler.ToList();
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            txtKategoriAdi.Text = string.Empty;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value.ToString());
            var kategori = model.Kategoriler.Find(id);
            model.Kategoriler.Remove(kategori);
            model.SaveChanges();
            dgvKategoriler.DataSource = model.Kategoriler.ToList();
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            txtKategoriAdi.Text = string.Empty;
        }
    }
}
