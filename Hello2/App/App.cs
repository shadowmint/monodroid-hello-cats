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
	[Activity (Label = "Main", MainLauncher = true)]
	public class App : Activity1 
	{
		public static AppControl mvc = null;

		protected override void OnCreate (Bundle bundle)
		{
			if (mvc == null) {
				AppControlFactory.Register<IAppSetup>(new AppSetup());
				mvc = AppControlFactory.Resolve<AppControl>();
				mvc.Navigate("app.home.HelloWorld");
			}
		}
	}
}

