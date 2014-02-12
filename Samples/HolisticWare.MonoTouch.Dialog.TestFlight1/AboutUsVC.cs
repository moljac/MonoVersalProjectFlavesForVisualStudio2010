
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HolisticWare.MonoTouchDialog.TestFlight1
{
	public partial class AboutUsVC : UIViewController
	{
		public AboutUsVC()
			: base("AboutUsVC", null)
		{
			this.NavigationItem.Title = "About Us";

		}

		public override void DidReceiveMemoryWarning()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning();

			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Perform any additional setup after loading the view, typically from a nib.
			this.btnReturnToHome.Clicked += (object sender, EventArgs e) =>
			{
				DismissViewController(true, null);
			};

			//TODO: moki daj pogledaj zakaj ovo ne dela
			//CHECK WEB PAGE REACHABILITY
			//			if(!Reachability.IsHostReachable("http://www.holisticware.com"))
			//				{
			//					//IF NOT REACHABLE LOAD STATIC VIEW (AboutUsOfflineDVC)
			//					// Put alternative content/message here
			//					AboutUsOfflineDVC aboutUsOffline = new AboutUsOfflineDVC();
			//					UINavigationController aboutUsOffline_NavigationController = new UINavigationController(aboutUsOffline);
			//					aboutUsOffline_NavigationController.SetNavigationBarHidden(true,false);
			//					aboutUsOffline_NavigationController.View.Frame = new RectangleF(0,44f,
			//					                                                                this.View.Bounds.Width,
			//					                                                                this.View.Bounds.Height);
			//					
			//					this.AddChildViewController(aboutUsOffline_NavigationController);
			//					this.View.AddSubview(aboutUsOffline_NavigationController.View);
			//				
			//				}
			//			else
			{
				//IF REACHABLE LOAD UP WEB 
				// Put Internet Required Code here

				string url = "http://www.holisticware.com";
				NSUrl nsurl = new NSUrl(url);
				NSUrlRequest nsurlRequest = new NSUrlRequest(nsurl);

				this.webViewAboutUs.ScalesPageToFit = true;
				this.webViewAboutUs.LoadRequest(nsurlRequest);
			}


		}

		public override void ViewDidUnload()
		{
			base.ViewDidUnload();

			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;

			ReleaseDesignerOutlets();
		}

		public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}

	}
}

