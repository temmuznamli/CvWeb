using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CvWeb
{
	public enum Yetki
	{
		Öğrenci=1,
		Admin=2,
		Isveren=3
	}

	public class YetkiKontrol:System.Web.UI.Page
	{
		protected override void OnPreLoad(EventArgs e)
		{
			var yetki = (Kullanici)System.Web.HttpContext.Current.Session["Kullanici"];
			if (yetki.KullaniciYetkiTuru!="Öğrenci")
				Response.Redirect("/Login.aspx");
			base.OnLoad(e);
		}
	}
}