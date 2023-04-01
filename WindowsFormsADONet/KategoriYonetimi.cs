using System;
using System.Windows.Forms;

namespace WindowsFormsADONet
{
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }
        KategoriDAL dal = new KategoriDAL();
        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = dal.GetAllDataTable(sql: "select * from kategoriler");
            dgvKategoriler.Columns[1].HeaderText = "Kategori Adı"; // grid view ın kolon başlığını değiştirme işlemi
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez!");
            }
            else
            {
                var kategori = new Kategori()
                {
                    KategoriAdi = txtKategoriAdi.Text
                };
                var sonuc = dal.Add(kategori);
                if (sonuc > 0)
                {
                    dgvKategoriler.DataSource = dal.GetAllDataTable(sql: "select * from kategoriler");
                    txtKategoriAdi.Text = string.Empty;
                    txtKategoriAdi.Focus();
                    MessageBox.Show("Kayıt Başarılı!");
                }
            }
        }

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value.ToString());
                var kategori = dal.Get(id);
                if (kategori != null)
                {
                    txtKategoriAdi.Text = kategori.KategoriAdi;
                }
                btnEkle.Enabled = false;
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
                {
                    MessageBox.Show("Kategori Adı Boş Geçilemez!");
                }
                else
                {
                    var kategori = new Kategori()
                    {
                        Id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value),
                        KategoriAdi = txtKategoriAdi.Text
                    };
                    var sonuc = dal.Update(kategori);
                    if (sonuc > 0)
                    {
                        dgvKategoriler.DataSource = dal.GetAllDataTable(sql: "select * from kategoriler");
                        txtKategoriAdi.Text = string.Empty;
                        txtKategoriAdi.Focus();
                        btnEkle.Enabled = true;
                        btnGuncelle.Enabled = false;
                        btnSil.Enabled = false;
                        MessageBox.Show("Kayıt Başarılı!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    var id = int.Parse(dgvKategoriler.CurrentRow.Cells[0].Value.ToString());
                    var sonuc = dal.Delete(id);
                    if (sonuc > 0)
                    {
                        dgvKategoriler.DataSource = dal.GetAllDataTable("select * from kategoriler");
                        btnGuncelle.Enabled = false;
                        btnSil.Enabled = false;
                        txtKategoriAdi.Text = string.Empty;
                        txtKategoriAdi.Focus();
                        btnEkle.Enabled = true;
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
        }
    }
}
