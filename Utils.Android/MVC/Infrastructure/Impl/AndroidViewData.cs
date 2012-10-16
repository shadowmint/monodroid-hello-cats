using System;
using MVC.Infrastructure;
using System.Collections.Generic;
using Android.Content;
using Android.OS;

namespace MVC.Infrastructure.Impl
{
	public sealed class AndroidViewData : ViewData, Java.Lang.Object, IParcelable
	{
		priviate AndroidViewData(Parcel parcel) {
			Controller = parcel.Read
		}
	}
}

