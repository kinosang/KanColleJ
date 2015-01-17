using System;
using System.Threading;
using TimersTimer = System.Timers.Timer;
using DotNet.Utilities;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	private int counter = 0;
	private object _timerLock = new object();
	private TimersTimer _TimersTimer = new TimersTimer();

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void _TimersTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {
		if (!Monitor.TryEnter(_timerLock))
		{
			return;
		}
		try
		{
			Monitor.Enter(_timerLock);
			Random ran = new Random();
			HttpHelper http = new HttpHelper();
			HttpItem item = new HttpItem()
			{
				URL = txt_url.Text,
				Method = "POST",
				Timeout = 10000,
				ReadWriteTimeout = 3000,
				IsToLower = false,
				Cookie = txt_cookie.Text,
				UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:18.0) Gecko/20100101 Firefox/18.0",
				Accept = "text/html, application/xhtml+xml, */*",
				ContentType = "application/x-www-form-urlencoded",
				Referer = txt_url.Text,
				Postdata = "name="+ran.Next()+"&password="+ran.Next()+"&world=1&seccode="+txt_captcha.Text+"&registersubmit=%E6%8F%90%E4%BA%A4",
			};	
			HttpResult result = http.GetHtml(item);
			string html = result.Html;
			//string cookie = result.Cookie;
			//byte[] b = result.ResultByte;
			Console.WriteLine(html);
			//http.GetHtml(item);
			this.counter++;
			this.lbl_count.Text = "已发送： " + this.counter + " 次";
		}
		finally
		{
			Monitor.Exit(_timerLock);
		}
	}

	protected void startstopatk (object sender, EventArgs e)
	{
		if (btn_startstop.Label == "开始(_S)") {
			btn_startstop.Label = "停止(_S)";
			this._TimersTimer.Interval = Convert.ToInt32(1000 / hs_speed.Adjustment.Value);
			this._TimersTimer.Elapsed += new System.Timers.ElapsedEventHandler(_TimersTimer_Elapsed);
			//this._TimersTimer.SynchronizingObject = lbl_count;
			this._TimersTimer.Start ();
		} else {
			btn_startstop.Label = "开始(_S)";
			this._TimersTimer.Stop ();
		}
	}

	protected void licensecheck (object sender, EventArgs e)
	{
		if (chk_license.Active==false) {
			btn_startstop.Sensitive = false;
			MessageDialog md = new MessageDialog (this, 
				DialogFlags.DestroyWithParent,
				MessageType.Error, 
				ButtonsType.Close, "未同意协议，不能使用");
			md.Run ();
			md.Destroy ();
		} else {
			btn_startstop.Sensitive = true;
		}
	}
}
