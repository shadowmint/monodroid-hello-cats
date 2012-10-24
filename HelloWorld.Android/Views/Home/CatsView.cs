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

	/** Cat drawer */
	public class CatBlock : View {

		public CatBlock (Context context) : base(context) { }

		private List<CatPurr> _purrs = new List<CatPurr>();
		private Bitmap _cat;
		private Bitmap _bubble;
		private Random _r;
		private float _width;
		private float _height;
		private Paint _p = null;

		private void Init(Canvas c)
		{
			if (_p == null) {
				_cat = BitmapFactory.DecodeResource(Resources, Resource.Drawable.Cat);
				_bubble = BitmapFactory.DecodeResource(Resources, Resource.Drawable.Bubble);
				_r = new Random();
				_p = new Paint();
			}
			_width = c.Width;
			_height = c.Height;
		}

		protected override void OnDraw(Canvas c)
		{
			Init(c);

			_p.SetStyle (Paint.Style.Fill);
			_p.Color = Color.White;
			c.DrawPaint(_p);

			float scale = (float) _cat.Width / (float) _cat.Height;
			int new_height = c.Height * 3 / 4;
			int new_width = (int) (new_height * scale);
			c.DrawBitmap(
				_cat, 
				new Rect(0, 0, _cat.Width, _cat.Height),
				new Rect(0, c.Width / 4, new_width, new_height + c.Width / 4),
				//new Rect(0, (int) (c.Height-new_height), (int) new_width, (int) c.Height),
				_p
			);

			foreach (var purr in _purrs) {
				purr.Render(c, _p);
			}
		}

		public override bool OnTouchEvent(MotionEvent e)
		{
			if (_p != null) {
				var size = Resources.GetDimensionPixelSize(Resource.Dimension.custom_text_size);
				_purrs.Add(new CatPurr(_width, _height, size, _bubble, _r));
				Invalidate(); // Request redraw
			}
			return base.OnTouchEvent (e);
		}
	}

	/** Purrable */
	public class CatPurr {

		private float _x;
		private float _y;
		private float _textSize;
		private Bitmap _bubble;
		private Color _color;

		public CatPurr(float width, float height, float ts, Bitmap bubble, Random r)
		{
			_x = (float) r.NextDouble() * width;
			_y = (float) r.NextDouble() * height * 1 / 4;
			_bubble = bubble;
			_color = RandomColor(r);
			_textSize = ts;
		}

		public void Render(Canvas c, Paint p) {
			c.DrawBitmap(_bubble, _x, _y, p);
			p.Color = _color;
			p.TextSize = _textSize;
			p.AntiAlias = true;
			c.DrawText ("Purr", _x + _bubble.Width / 2 - p.MeasureText("Purr") / 2, _y + _bubble.Height / 2 + _textSize / 4, p);
		}

	    private Color RandomColor(Random r) {
			int blue = (r.Next() % 255);
			int red = (r.Next() % 255);
			Color rtn = Color.Argb(255, red, 0, blue);
			return rtn;
		}
	}
}


