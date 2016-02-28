using System;
using System.IO;
using Xamarin.Forms;
using System.Reflection;
using System.Linq;
using Newtonsoft.Json;
namespace HackingTerimleri
{
	public class AboutHackers : ContentPage
	{
		public AboutHackers ()
		{
			hackerTerimleri ht = new hackerTerimleri();
			ListView hackerTerimleriListView;
			this.Title = "Hackerlar Hakkında";
			hackerTerimleriListView = new ListView
			{
				VerticalOptions=LayoutOptions.FillAndExpand
					
			};

			Assembly assembly = typeof(App).GetTypeInfo ().Assembly;
			Stream stream = assembly.GetManifestResourceStream ("HackingTerimleri.json.hackerTerimleri.json");
			string text = "";
			using (var reader = new System.IO.StreamReader (stream)) 
			{
				text = reader.ReadToEnd ();
			}

			ht = JsonConvert.DeserializeObject<hackerTerimleri> (text);
			hackerTerimleriListView.ItemTemplate = new DataTemplate (typeof(hackerListCell));
			hackerTerimleriListView.HasUnevenRows = true;

			hackerTerimleriListView.ItemsSource = ht._HackerTerimleri.Select (x => {
				return new hackerListCellHolder
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


