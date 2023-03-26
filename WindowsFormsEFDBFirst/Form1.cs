using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsEFDBFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AdoNetDbEntities tablolar = new AdoNetDbEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            // Entityframework ado net deki gibi sql kodları yazmadan veritabanı crud işlemlerini yapabilmemizi sağlayan bir kütüphanedir. Projeye sonradan Nuget package manager aracılığı ile eklenir. 
            // Projeye Entityframework ekleyebilmek için projeye sağ tıklayıp açılan menüden nuget package manager i seçip açılan pencereden browse seçeneğine basıp oradan entity framework paketini seçip yükle butonu ile açılan onay pencerekerine onay vermemiz gerekir.
            // UrunYonetimi.edmx i oluşturmak için : projeye sağ tık add new item > sol menüden data yı seçtik > gelen ekranda ilk seçeneği seçip next dedik > aşağıda isim verip next dedik > gelen ekranda veritabanı ayarlarını yaptık > ok ile pencereyi kapatıp tabloların ekrana gelmesini bekledik. > üstte kaydet butonuna bastık > kayıt tamam.
            // veritabanı işlemleri UrunYonetimi.edmx in altındaki AdoNetDbEntities class ı kullanılarak yapılıyor!
            dgvUrunler.DataSource = tablolar.Urunler.ToList(); // veritabanındaki ürünleri listele
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var urun = new Urun() // ekrandan girilen bilgilerle 1 ürün oluştur
            {
                StokMiktari = int.Parse(txtStokMiktari.Text),
                UrunAdi = txtUrunAdi.Text,
                UrunFiyati = decimal.Parse(txtUrunFiyati.Text)
            };
            tablolar.Urunler.Add(urun); // üstteki ürünü ef deki tablolardan urunler tablosuna ekle
            int sonuc = tablolar.SaveChanges(); // tablolardaki değişikliği kaydet ve veritabanına işle. SaveChanges metodu bize etkilenen kayıt sayısını getirir.
            if (sonuc > 0)
            {
                dgvUrunler.DataSource = tablolar.Urunler.ToList();
                MessageBox.Show("Kayıt Başarılı");
            }
            else MessageBox.Show("Kayıt Başarısız!");
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value.ToString()); // seçili satırdaki id değerini yakala
            var urun = tablolar.Urunler.Find(id); // yakalanan id ile ef find metodunu kullanarak db den bu id ye ait ürünü getir
            txtUrunFiyati.Text = urun.UrunFiyati.ToString(); // db den gelen ürün deki bilgileri textbox lara doldur
            txtUrunAdi.Text = urun.UrunAdi;
            txtStokMiktari.Text = urun.StokMiktari.ToString();
            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value.ToString());
                var urun = tablolar.Urunler.Find(id);
                urun.UrunFiyati = decimal.Parse(txtUrunFiyati.Text);
                urun.StokMiktari = int.Parse(txtStokMiktari.Text);
                urun.UrunAdi = txtUrunAdi.Text;
                int sonuc = tablolar.SaveChanges();
                if (sonuc > 0)
                {
                    dgvUrunler.DataSource = tablolar.Urunler.ToList();
                    btnEkle.Enabled = true;
                    btnGuncelle.Enabled = false;
                    btnSil.Enabled = false;
                    MessageBox.Show("Kayıt Başarılı");
                }
                else MessageBox.Show("Kayıt Başarısız!");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value.ToString()); // seçili satırdan id değerini aldık
            var urun = tablolar.Urunler.Find(id); // veritabanından bu id li ürünü bulduk
            tablolar.Urunler.Remove(urun); // bulunan ürünü sildik

            int sonuc = tablolar.SaveChanges(); // silme işlemini db ye işledik yoksa silme gerçekleşmez!
            if (sonuc > 0) // silindiyse
            {
                dgvUrunler.DataSource = tablolar.Urunler.ToList();
                btnEkle.Enabled = true;
                btnGuncelle.Enabled = false;
                btnSil.Enabled = false;
                MessageBox.Show("Kayıt Silme Başarılı");
            }
            else MessageBox.Show("Kayıt Silme Başarısız!");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = tablolar.Urunler.Where(x => x.UrunAdi.Contains(txtAra.Text)).ToList(); // x => x.UrunAdi şeklindeki yazım türünü entity framework de lambda expression denir. tablolar.Urunler den sonra where metodunu çağırıp içerisinde ürünadı kolonunda txtara dan gelecek değerle eşleşen kayıt varsa filtreleme yapar.
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = tablolar.Urunler.Where(x => x.UrunAdi.Contains(txtAra.Text)).ToList(); // textbox daki içerik değitikçe sorgula
        }
    }
}
