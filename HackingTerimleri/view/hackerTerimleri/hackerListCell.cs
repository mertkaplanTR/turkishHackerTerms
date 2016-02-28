using System;

using Xamarin.Forms;

namespace HackingTerimleri
{
	public class hackerListCell : ViewCell
	{
		public hackerListCell ()
		{

			Label lblhackerlistcell = new Label {
				TextColor = Color.Green,
				FontSize = 14,
				XAlign = TextAlignment.Start
			};
			lblhackerlistcell.SetBinding (Label.TextProperty, "terim");



			Label lblhackerlistcellsecond = new Label 
			{
				TextColor = Color.White,
				FontSize = 14,
				XAlign = TextAlignment.Start
			};
			lblhackerlistcellsecond.SetBinding (Label.TextProperty, "aciklama");


			var stcRoot = new StackLayout
			{ 
				Orientation=StackOrientation.Horizontal,
				VerticalOptions=LayoutOptions.FillAndExpand,
				Spacing=7,
				Padding=7,
				Children={lblhackerlistcell,lblhackerlistcellsecond}
			};

			this.View = stcRoot;
		}
	}
}


