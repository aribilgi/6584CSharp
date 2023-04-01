using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsEFCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EFCodeFirstModel model = new EFCodeFirstModel();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = model.Urunler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var urun = new Urun()
            {
                StokMiktari = int.Parse(txtStokMiktari.Text),
                UrunAdi = txtUrunAdi.Text,
                UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text)
            };
            model.Urunler.Add(urun);
            var islemSonucu = model.SaveChanges();
            if (islemSonucu > 0)
            {
                dgvUrunler.DataSource = model.Urunler.ToList();
                MessageBox.Show("Kayıt Başarılı!");
            }
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value.ToString());
            var urun = model.Urunler.Find(id);
            txtStokMiktari.Text = urun.StokMiktari.ToString();
            txtUrunAdi.Text = urun.UrunAdi;
            txtUrunFiyati.Text = urun.UrunFiyati.ToString();
            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value.ToString());
            var urun = model.Urunler.Find(id);
            urun.StokMiktari = int.Parse(txtStokMiktari.Text);
            urun.UrunAdi = txtUrunAdi.Text;
            urun.UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text);
            var islemSonucu = model.SaveChanges();
            if (islemSonucu > 0)
            {
                dgvUrunler.DataSource = model.Urunler.ToList();
                btnEkle.Enabled = true;
                btnGuncelle.Enabled = false;
                btnSil.Enabled = false;
                MessageBox.Show("Kayıt Başarılı!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value.ToString());
            var urun = model.Urunler.Find(id);
            model.Urunler.Remove(urun);
            var islemSonucu = model.SaveChanges();
            if (islemSonucu > 0)
            {
                dgvUrunler.DataSource = model.Urunler.ToList();
                btnEkle.Enabled = true;
                btnGuncelle.Enabled = false;
                btnSil.Enabled = false;
                MessageBox.Show("Kayıt Silme Başarılı!");
            }
        }
    }
}
