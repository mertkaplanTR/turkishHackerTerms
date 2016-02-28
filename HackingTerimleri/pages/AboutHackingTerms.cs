using System;
using System.IO;
using Xamarin.Forms;
using System.Reflection;
using System.Linq;
using Newtonsoft.Json;
namespace HackingTerimleri
{
	public class AboutHackingTerms : ContentPage
	{
		public AboutHackingTerms ()
		{
            hackingTerimleri ht = new hackingTerimleri();
			ListView hackerTerimleriListView;
			this.Title = "Hacking Terimleri";
			hackerTerimleriListView = new ListView
			{
				VerticalOptions=LayoutOptions.FillAndExpand
			};

			Assembly assembly = typeof(App).GetTypeInfo ().Assembly;
			Stream stream = assembly.GetManifestResourceStream ("HackingTerimleri.json.hackingTerimleri.json");
			string text = "";
			using (var reader = new System.IO.StreamReader (stream)) 
			{
				text = reader.ReadToEnd ();
			}

            ht = JsonConvert.DeserializeObject<hackingTerimleri>(text);
			hackerTerimleriListView.ItemTemplate = new DataTemplate (typeof(hackingListCell));
			hackerTerimleriListView.HasUnevenRows = true;

			hackerTerimleriListView.ItemsSource = ht._HackingTerimleri.Select (x => {
				return new hackingListCellHolder
				{ 
					terim = x.terim,
					aciklama = x.aciklama
				};
			});
			Content = new StackLayout 
			{
				BackgroundColor = Color.Black,
				Children = { hackerTerimleriListView }
			};


		}
	}
}


