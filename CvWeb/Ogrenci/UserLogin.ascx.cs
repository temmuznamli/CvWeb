using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvWeb.Ogrenci
{
	public partial class UserLogin : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void girisyap_Click(object sender, EventArgs e)
		{
			var kullanici = new Kullanici().GetByKullaniciVarMi(txt_kullaniciadi.Text, txt_sifre.Text);
			if (kullanici!=null)
			{
				Session["Kullanici"] kullanici;
			}
		}

		protected void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}