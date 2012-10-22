using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using n.Infrastructure;

namespace HelloWorld.ViewModels.Home
{
	public class IndexViewModel : nModel
	{
		public string Value { get; set; }
		public int Count { get; set; }
	}
}


