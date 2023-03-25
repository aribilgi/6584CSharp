using System;
using System.Windows.Forms;

namespace WindowsFormsADONet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UrunDAL urunDAL = new UrunDAL();
        private void Form1_Load(object sender, EventArgs e)
        {
            // dgvUrunler.DataSource = urunDAL.UrunleriGetir();
            dgvUrunler.DataSource = urunDAL.UrunleriDataTablelaGetir();
            dgvUrunler.Columns[1].HeaderText = "Ürün Adı";
            dgvUrunler.Columns[2].HeaderText = "Ürün Fiyatı";
            dgvUrunler.Columns[3].HeaderText = "Stok Miktarı";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try // hata yakalama işlemi
            {
                // çalışmasını beklediğimiz kodlar bu bloğa
                var sonuc = urunDAL.Add(new Urun()
                {
                    StokMiktari = int.Parse(txtStokMiktari.Text),
                    UrunAdi = txtUrunAdi.Text,
                    UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text)
                });
                if (sonuc > 0)
                {
                    dgvUrunler.DataSource = urunDAL.UrunleriDataTablelaGetir();
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız!");
                }
            }
            catch (Exception hata)
            {
                // hata oluştuğunda çalıştıracağımız kodlar buraya yazılır
                MessageBox.Show("Hata Oluştu!\n" + hata.Message);
            }

        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // ürün bilgisini direk data grid view dan alma:
            //txtUrunAdi.Text = dgvUrunler.CurrentRow.Cells[1].Value.ToString();
            //txtUrunFiyati.Text = dgvUrunler.CurrentRow.Cells[2].Value.ToString();
            //txtStokMiktari.Text = dgvUrunler.CurrentRow.Cells[3].Value.ToString();
            try
            {
                var id = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value.ToString());// gridden seçilen satırda ilk sütundaki id değerini al, int e çevir ve id değişkenine aktar.
                var urun = urunDAL.Get(id); // 1 tane ürün getiren get metodumuza bu id yi gönderiyoruz ki bize o id ile eşleşen ürünü getirsin
                if (urun != null)
                {
                    txtUrunAdi.Text = urun.UrunAdi;
                    txtUrunFiyati.Text = urun.UrunFiyati.ToString();
                    txtStokMiktari.Text = urun.StokMiktari.ToString();
                }
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try // hata yakalama işlemi
            {
                // çalışmasını beklediğimiz kodlar bu bloğa
                var sonuc = urunDAL.Update(new Urun()
                {
                    Id = int.Parse(dgvUrunler.CurrentRow.Cells[0].Value.ToString()),
                    StokMiktari = int.Parse(txtStokMiktari.Text),
                    UrunAdi = txtUrunAdi.Text,
                    UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text)
                });
                if (sonuc > 0)
                {
                    dgvUrunler.DataSource = urunDAL.UrunleriDataTablelaGetir();
                    btnGuncelle.Enabled = false;
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız!");
                }
            }
            catch (Exception hata)
            {
                // hata oluştuğunda çalıştıracağımız kodlar buraya yazılır
                MessageBox.Show("Hata Oluştu!\n" + hata.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var urunId = int.Parse(dgvUrunler.CurrentRow.Cells[0].Value.ToString());
                var sonuc = urunDAL.Delete(urunId);
                if (sonuc > 0)
                {
                    dgvUrunler.DataSource = urunDAL.UrunleriDataTablelaGetir();
                    btnGuncelle.Enabled = false;
                    btnSil.Enabled = false;
                    MessageBox.Show("Kayıt Silme Başarılı!");
                }
                else
                {
                    MessageBox.Show("Kayıt Silme Başarısız!");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!\n" + hata.Message);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = urunDAL.UrunleriDataTablelaGetir(txtAra.Text.Trim());
        }
    }
}
