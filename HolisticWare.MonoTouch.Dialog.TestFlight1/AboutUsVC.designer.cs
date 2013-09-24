// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace HolisticWare.MonoTouchDialog.TestFlight1
{
	[Register("AboutUsVC")]
	partial class AboutUsVC
	{
		[Outlet]
		MonoTouch.UIKit.UIBarButtonItem btnReturnToHome { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIWebView webViewAboutUs { get; set; }

		void ReleaseDesignerOutlets()
		{
			if (btnReturnToHome != null)
			{
				btnReturnToHome.Dispose();
				btnReturnToHome = null;
			}

			if (webViewAboutUs != null)
			{
				webViewAboutUs.Dispose();
				webViewAboutUs = null;
			}
		}
	}
}
