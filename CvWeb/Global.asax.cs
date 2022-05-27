using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace CvWeb
{
	public class Global : System.Web.HttpApplication
	{
		void Yonlendir(RouteCollection route)
		{
			route.MapPageRoute("Giriş", "GirisYap", "~/Login.aspx");
			route.MapPageRoute("Kayıt", "KayıtOl", "~/Kayit.aspx");
			route.MapPageRoute("Şifre", "SifremiUnuttum", "~/SifremiUnuttum.aspx");

			//admin yetikleri
			route.MapPageRoute("Cv", "Admin/Cv", "~/Admin/Cv.aspx");
			route.MapPageRoute("Mezun", "Admin/Mezun", "~/Admin/Mezun.aspx");
			route.MapPageRoute("Fakulte", "Admin/Fakulte", "~/Admin/Fakulte.aspx");
			route.MapPageRoute("Okul", "Admin/Okul", "~/Admin/Okul.aspx");
			route.MapPageRoute("Uye", "Admin/Uye", "~/Admin/Uye.aspx");
			route.MapPageRoute("Referans", "Admin/Referans", "~/Admin/Referans.aspx");

			//
		}
		protected void Application_Start(object sender, EventArgs e)
		{
			Yonlendir(RouteTable.Routes);
		}

		protected void Session_Start(object sender, EventArgs e)
		{

		}

		protected void Application_BeginRequest(object sender, EventArgs e)
		{

		}

		protected void Application_AuthenticateRequest(object sender, EventArgs e)
		{

		}

		protected void Application_Error(object sender, EventArgs e)
		{

		}

		protected void Session_End(object sender, EventArgs e)
		{

		}

		protected void Application_End(object sender, EventArgs e)
		{

		}
	}
}