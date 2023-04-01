using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Bu alan form1 yüklenirken çalışır, burada veritabanına bağlanıp db deki kayıtları çekip ekrana gönderebiliriz.
            trackBar1.Minimum = 10;
            trackBar1.Maximum = 25;
            trackBar1.TickFrequency = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Butona tıkladığımızda bu metot çalışır ve burada veritabanı işlemleri veya ekranla alakalı işlemler gerçekleştirebiliriz.
            butonAdi.Text = "Buton Adı Değişti";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle(); // UrunEkle formundan bir nesne oluştur
            //urunEkle.Show(); // oluşan nesneyi ekrana getir
            urunEkle.ShowDialog(); // ekrana sadece 1 tane urunEkle penceresi açılabilmesini istiyorsak
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("İki Tarih Arasında " + (dateTimePicker2.Value - dateTimePicker1.Value).Days.ToString() + " gün fark vardır."); // kısayolu mbox ı seçip tab a basmak
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Lütfen bir sayı giriniz");
            }
            else
            {
                button2.Enabled = false;
                int sayi = Convert.ToInt32(textBox1.Text);
                progressBar1.Maximum = sayi;
                for (int i = 0; i < sayi; i++)
                {
                    progressBar1.Value = i;
                }
                button2.Enabled = true;
            }
        }

        private void yeniEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // menüye tıklayınca işlem yaptırabileceğimiz metot
            UrunEkle urunEkle = new UrunEkle();
            urunEkle.ShowDialog();
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll(); // richTextBox1 deki tüm içeriği seç
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy(); // richTextBox1 deki tüm seçili içeriği kopyala
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste(); // richTextBox1 deki tüm seçili içeriği yapıştır
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut(); // richTextBox1 deki tüm seçili içeriği kes
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // ekrandaki trackBar1 kaydırma çubuğu hareket ettiğinde bu metot tetiklenir.
            richTextBox1.Font = new Font("Tahoma", trackBar1.Value);
        }
    }
}
