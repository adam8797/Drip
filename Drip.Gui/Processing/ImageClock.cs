using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Drip.Gui.Utility;
using Timer = System.Windows.Forms.Timer;

namespace Drip.Gui.Processing
{
	public class ImageClock
	{
		public ImageClock(int delay)
		{
			_timer = new Timer()
			{
				Interval = delay * 1000,
			};


			_timer.Tick += (sender, args) =>
			{
				//Remove any threads that have completed their task.
				_runningThreads.RemoveAll(tt => !tt.IsAlive);

				//Make a new thread for each download, as not to lock up the UI
				Thread t = new Thread(Snap);
				_runningThreads.Add(t);
				t.Start();
			};

			_runningThreads = new List<Thread>();
		}

		private Timer _timer;
		private List<Thread> _runningThreads;

		public bool IsRunning => _timer.Enabled;

		public int DelayInSeconds
		{
			get { return _timer.Interval / 1000; }
			set { _timer.Interval = value * 1000; }
		}

		public void Start()
		{
			_timer.Start();
		}

		public void Stop()
		{
			_timer.Stop();
			foreach (var runningThread in _runningThreads)
			{
				runningThread.Abort();
			}
		}
		

		public void Snap()
		{
			try
			{
				WebClient wc = new WebClient();

				var url = ApplicationConfig.Shared.CaptureUrl;

				var path = Path.Combine(ApplicationConfig.Shared.ImageSaveDirectory,
					DateTime.Now.ToString(ApplicationConfig.Shared.ImageNameFormat) + ".jpeg");

				if (!Directory.Exists(ApplicationConfig.Shared.ImageSaveDirectory))
					Directory.CreateDirectory(ApplicationConfig.Shared.ImageSaveDirectory);

				wc.DownloadFile(url, path);
			}
			catch (ThreadAbortException)
			{
				Debug.WriteLine("Thread Aborted");
			}
			catch (WebException ex)
			{
				Debug.WriteLine("Error while capturing image");
				Debug.WriteLine(ex.ToString());
			}
		}
	}
}
