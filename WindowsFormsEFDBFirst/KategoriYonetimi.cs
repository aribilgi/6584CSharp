using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEFDBFirst
{
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }
        AdoNetDbEntities tablolar = new AdoNetDbEntities();
        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = tablolar.Kategoriler.ToList();
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
            tablolar.Kategoriler.Add(kategori);
            tablolar.SaveChanges();
            dgvKategoriler.DataSource = tablolar.Kategoriler.ToList();
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            txtKategoriAdi.Text = string.Empty;
        }

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value.ToString());
            var kategori = tablolar.Kategoriler.Find(id);
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
            var kategori = tablolar.Kategoriler.Find(id);
            kategori.KategoriAdi = txtKategoriAdi.Text;
            tablolar.SaveChanges();
            dgvKategoriler.DataSource = tablolar.Kategoriler.ToList();
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            txtKategoriAdi.Text = string.Empty;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value.ToString());
            var kategori = tablolar.Kategoriler.Find(id);
            tablolar.Kategoriler.Remove(kategori);
            tablolar.SaveChanges();
            dgvKategoriler.DataSource = tablolar.Kategoriler.ToList();
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            txtKategoriAdi.Text = string.Empty;
        }
    }
}
