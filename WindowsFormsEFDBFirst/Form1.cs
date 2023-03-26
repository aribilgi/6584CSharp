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
            dgvUrunler.DataSource = tablolar.Urunler.ToList(); // veritabanındaki ürünleri listele
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var urun = new Urun() // ekrandan girilen bilgilerle 1 ürün oluştur
            {
                StokMiktari = int.Parse(txtStokMiktari.Text),
                UrunAdi = txtUunAdi.Text,
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
    }
}
