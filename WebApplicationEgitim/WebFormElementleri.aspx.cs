using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationEgitim
{
    public partial class WebFormElementleri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // windows forms daki form açılırken db den verileri çekip ekrana yollamak için kullandığımız form load metodu web de pageload olarak aynı işlem için kullanılıyor.
            // Bu kısımda win forms daki code behind işlemleri yapılır CRUD vb.
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "butona tıklandı!";
            Label1.Text += "Dropdownlist den seçilen değer : SelectedValue : " + DropDownList1.SelectedValue + " - SelectedItem.Text : " + DropDownList1.SelectedItem.Text;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = "HiddenField elementi sayfada gizli veri tutar";
        }
    }
}