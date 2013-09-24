
using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;


using System.Xml.Linq;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Drawing;
using MonoTouch.MapKit;
using MonoTouch.CoreLocation;


namespace HolisticWare.MonoTouchDialog.TestFlight1
{
	public partial class HomeDVC : DialogViewController
	{
		Section screen_main_section_cities = null;

		Section screen_main_section_categories = null;

		//VIEWS
		AboutUsVC aboutUsView;

		//UI NAV BAR BUTTON
		public UIBarButtonItem button_back = null;

		public override void ViewDidLoad()
		{

			//			button_back = new UIBarButtonItem
			//				(
			//					"Start"
			//					, UIBarButtonItemStyle.Plain
			//					, NavigateBack
			//					);
			//			button_back.Clicked += NavigateBack;
			//			NavigationItem.BackBarButtonItem = button_back;
			//			NavigationItem.LeftBarButtonItem = button_back;

			//UI BUTTONS

			UIBarButtonItem rightBarButton = new UIBarButtonItem("About Us", UIBarButtonItemStyle.Bordered, null);
			NavigationItem.RightBarButtonItem = rightBarButton;
			rightBarButton.Title = "About Us";
			rightBarButton.Clicked += (object sender, EventArgs e) =>
			{
				if (aboutUsView == null)
				{
					aboutUsView = new AboutUsVC()
					{
						ModalTransitionStyle = UIModalTransitionStyle.FlipHorizontal,
					};
					PresentViewController(aboutUsView, true, null);
				}
				else
					PresentViewController(aboutUsView, true, null);
			};

			base.ViewDidLoad();


			//TEST BUTTON RELATIVE POSITION
			//TODO: Moki button relative position
			var buttonTest = UIButton.FromType(UIButtonType.RoundedRect);

			//buttonTest.Frame = new System.Drawing.RectangleF(20f, 282f, 280f, 37f);

			//This will take whole table view, and put the bottom at the end and it will not be visible until pull
			//screen down

			//IDEA: create bounds for ui table view, so that the max is half of the screen, and then use 
			//TableView.Bounds.Bottom

			buttonTest.Frame = new System.Drawing.RectangleF(20f, this.Root.TableView.Bounds.Bottom, 280f, 37f);
			buttonTest.SetTitle("Notes", UIControlState.Normal);

			this.View.Add(buttonTest);
			//------------------------------



			return;
		}




		public HomeDVC()
			: base(UITableViewStyle.Grouped, null)
		{


			const string header = "HolisticWare & D4Me";
			const string footer = "Pretraga točki interesa";


			//------------------------CURRENT-LOCATION-----------------------
			//ONLY TEMPORARY
			this.RefreshRequested += delegate
			{
			};

			// screen_main_string_element_city_current.Tapped += () =>
			// {
			// 	var x = new UIAlertView("Warning", "Pull Down The Screen To Get Current Location", null, "Ok");
			// 	x.Show();
			// 
			// 	//this.NavigationController.PushViewController(mapViewCurrent, true);
			// };

			//MAIN ELEMENT OF THIS VIEW
			Root = new RootElement("Destination4Me") 
			{
			};

		}

		public void NavigateBack(object sender, EventArgs ea)
		{
			Debug.WriteLine("NavigateBack");

			return;
		}

		UIAlertView uiav = new UIAlertView
								(
								  "Only 1 city for search"
								, "Only 1 city for search"
								, null
								, "OK"
								, null
								);



		RootElement RucnoPretrazivanje()
		{
			RootElement menu = new RootElement("Ručno Pretraživanje")
			{
				new Section ("Gradovi:") 
				{
				  new StringElement("Zagreb")
				, RucnoPretrazivanjeKategorije()
				}
			};
			return menu;

			//TODO: mokee tu mi treba citanje gradova, i dodavanje gore, s time da mora biti
			//recimo new StringElement(imeGrada,RucnoPretrazivanjeKategorija())
			//sad neznam da li ce to ici mozda ce morati se to drugacije sloziti jel StringElement neda ()
			//prvo pokreni aplikaciju da vidis kak sam to zamislis
		}




		private RootElement RucnoPretrazivanjeKategorije()
		{
			RootElement menu = new RootElement("Kategorije")
			{
			  new Section ("Commands")
			  {
			  } 				
			};

			return menu;
		}



		private RootElement StvoriKorisnickePostavke()
		{

			RootElement menu = new RootElement("Korisničke Postavke")
			{				
				new Section () 
				{
				}
			};
			return menu;
		}




	}
}
