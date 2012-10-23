using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;
using n.Infrastructure;
using n.Infrastructure.Impl;
using HelloWorld.Model;
using HelloWorld.Controllers;
using HelloWorld.ViewModels.Home;
using System.Collections.Generic;

namespace HelloWorld.Views.Home
{
	[Activity (Label = "HelloWorld.Views.Home.Cats")]
	public class CatsView : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView(new CatBlock(this));
		}
	}

	public class CatBlock : View {

		public CatBlock (Context context) : base(context) { }

		protected override void OnDraw (Canvas c)
		{
			var p = new Paint();
			p.SetStyle (Paint.Style.Fill);
			p.Color = Color.AliceBlue;
			c.DrawPaint(p);

			var cat = BitmapFactory.DecodeResource(Resources, Resource.Drawable.Cat);
			c.DrawBitmap(cat, c.Width / 2 - cat.Width / 2, c.Height / 2 - cat.Height / 2, p);

			p.Color = Color.Red;
			p.TextSize = Resources.GetDimensionPixelSize(Resource.Dimension.custom_text_size);
			p.AntiAlias = true;
			c.DrawText ("Purrrr", c.Width / 2, c.Height / 2, p);
		}

		public override bool OnTouchEvent (MotionEvent e)
		{
			nLog.Debug("Got a touch event at: " + e.GetX() + "," + e.GetY ()); 
			return base.OnTouchEvent (e);
		}
	}
}


