using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Hello2.Infrastructure.MVC;

namespace Hello2
{
	public class AppSetup : IAppSetup 
	{
		public void SetupDependencies(AppControlFactory factory)
		{
		}

		public void SetupControllers (AppControl app)
		{
			app.Attach(AppControlFactory.Resolve<HomeController>(), "app.home.{0}");
		}
	}
}

