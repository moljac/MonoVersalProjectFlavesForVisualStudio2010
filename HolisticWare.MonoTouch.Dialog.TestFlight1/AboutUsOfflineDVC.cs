
using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using MonoTouch.Dialog;

namespace HolisticWare.MonoTouchDialog.TestFlight1
{
	public partial class AboutUsOfflineDVC : DialogViewController
	{
		public AboutUsOfflineDVC()
			: base(UITableViewStyle.Grouped, null)
		{
			//we will use this in case there is no internet connection available
			string holisticware = "Located in Zagreb ...." + "\n MonoTouch ....";

			Root = new RootElement("About") 
			{
				new Section ("","HolisticWare Ltd.")
				{
				},
				new Section("")
				{
					new MultilineElement(holisticware),
				}
			};
		}
	}
}
