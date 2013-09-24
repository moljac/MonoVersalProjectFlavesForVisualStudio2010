using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Text;

namespace HolisticWare.MonoTouchDialog.TestFlight1
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main(string[] args)
		{
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.

			try
			{
				AppDomain.CurrentDomain.UnhandledException +=
					new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

				UIApplication.Main(args, null, "AppDelegate");
			}
			catch (System.Exception x)
			{
				CurrentDomain_UnhandledException
					(
					  new AppDelegate()
					, new UnhandledExceptionEventArgs(x, true)
					);
			}
			finally
			{
			}

		}

		static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			StringBuilder sb_msg = new StringBuilder();
			sb_msg.Append("");
			throw new System.Exception(sb_msg.ToString());
		}
	}
}
