using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Butona tıkladığımızda bu metot çalışır ve burada veritabanı işlemleri veya ekranla alakalı işlemler gerçekleştirebiliriz.
            butonAdi.Text = "Merhaba";
        }
    }
}
