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

			//admin yetikleri düzenlenecek:
			route.MapPageRoute("Cv", "Admin/Cv", "~/Admin/Cv.aspx");
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