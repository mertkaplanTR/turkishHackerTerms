using System;

using Xamarin.Forms;

namespace HackingTerimleri
{
	public class TabPage : TabbedPage
	{
		public TabPage ()
		{
			this.Children.Add (new Homepage());
			this.Children.Add (new AboutHackers());
			this.Children.Add (new AboutHackingTerms());
			this.Children.Add (new Youtube ());

		}
	}
}


