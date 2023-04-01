using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc; // MessageBox.Show metodunun geri dönüş türü DialogResult tır.
            sonuc = MessageBox.Show("Kapatmak istiyor musunuz?", "Uyarı", MessageBoxButtons.OKCancel);
            if (sonuc == DialogResult.OK)
                this.Close(); // bu Formu kapat
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kapatmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) // MessageBoxIcon.Exclamation pencereye ikon ekleyebilmemizi sağlar
            {
                Application.Exit(); // uygulamadan çık
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // timer a çift klik yaparak olayını etkinleştirebiliriz
            Random random = new Random(); // C# ta rastgele değer üreyen yapı
            //this.BackColor = Color.FromArgb(random.Next(1, 100), random.Next(1, 100), random.Next(1, 100)); // bu ekranın arkaplan rengini Color yapısı içindeki FromArgb metoduna random nesnesini kullanarak 1 ile 100 arası rasgele oluşacak değerler gönderiyoruz, bu değerler de renk kodu olarak kullanılıyor. RGB(Red,Green,Blue) ana renklerin karışımı kullanılıyor
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Burada ürün bilgileri veritabanına kaydedilir
            if (string.IsNullOrEmpty(txtUrunAdi.Text)) // eğer txtUrunAdi.Text boşsa
            {
                MessageBox.Show("Ürün Adı Boş Geçilemez!"); // Ekrana mesaj penceresi ile uyarı vermemizi sağlayan metot
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lblResim.Font = new Font("Arial", (float)numericUpDown1.Value); // Oklarla sayıları değiştirdiğimizde label ın yazı boyutunu değiştir
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            lblResim.Font = new Font(domainUpDown1.SelectedItem.ToString(), (float)numericUpDown1.Value);
        }

        private void UrunEkle_Load(object sender, EventArgs e) // Formdaki her hangi bir boş alana çift clik yaparak load eventini oluşturabiliriz. Bu olay form yüklenirken işlemler yapabilmemizi sağlar.
        {
            // Form yüklenirken domainUpDown1 e for un içindeki verileri ekle
            for (int i = 0; i < 50; i++)
            {
                domainUpDown1.Items.Add(FontFamily.Families[i].Name); // sistemdeki fontlardan domainUpDown1 e ekleme yaptık
            }
            domainUpDown1.Wrap = true; // liste sonunda başa dön
        }
    }
}
