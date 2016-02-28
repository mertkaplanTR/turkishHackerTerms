using System;

using Xamarin.Forms;

namespace HackingTerimleri
{
	public class hackingListCell : ViewCell
	{
		public hackingListCell ()
		{
			Label lblhackinglistcell = new Label {
				TextColor = Color.Green,
				FontSize = 14,
				XAlign = TextAlignment.Start
			};
			lblhackinglistcell.SetBinding (Label.TextProperty, "terim");



			Label lblhackinglistcellsecond = new Label 
			{
				TextColor = Color.White,
				FontSize = 14,
				XAlign = TextAlignment.Start
			};
			lblhackinglistcellsecond.SetBinding (Label.TextProperty, "aciklama");


			var stcRoot = new StackLayout
			{ 
				Orientation=StackOrientation.Horizontal,
				VerticalOptions=LayoutOptions.FillAndExpand,
				Spacing=7,
				Padding=7,
				Children={lblhackinglistcell,lblhackinglistcellsecond}
			};

			this.View = stcRoot;
		}
	}
}


