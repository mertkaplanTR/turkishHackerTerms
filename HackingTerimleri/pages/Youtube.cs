using System;

using Xamarin.Forms;

namespace HackingTerimleri
{
	public class Youtube : ContentPage
	{
		public Youtube ()
		{
			this.Title = "Hakkımda";
			var wordpressresim = new Image { Aspect = Aspect.AspectFit };
			wordpressresim.Source = ImageSource.FromUri(new Uri("http://www.rayswebstudio.co.uk/images_main/wordpress.png"));

			var twitterresim=new Image { Aspect = Aspect.AspectFit };
			twitterresim.Source = ImageSource.FromUri(new Uri("http://icongal.com/gallery/image/14864/twitter_white_social.png"));

			var youtuberesim = new Image { Aspect = Aspect.AspectFit };
			youtuberesim.Source = ImageSource.FromUri(new Uri("http://danieltomberlin.net/wp-content/uploads/2014/09/youtube-icon-transparent-background.png"));

			Button btnIzle = new Button
			{
				Text = "Blog Adresim",
				WidthRequest = 50,
				HeightRequest = 30,
				BackgroundColor = Color.Black,
				TextColor = Color.Green
			};

			Button btnIzle2 = new Button
			{
				Text = "Twitter Hesabım",
				WidthRequest = 50,
				HeightRequest = 30,
				BackgroundColor = Color.Black,
				TextColor = Color.Green
			};


			Button btnIzle3 = new Button
			{
				Text = "Youtube Kanalım",
				WidthRequest = 50,
				HeightRequest = 30,
				BackgroundColor = Color.Black,
				TextColor = Color.Green
			};



			btnIzle.Clicked += btnIzle_Clicked;
			btnIzle2.Clicked += btnIzle2_Clicked;
			btnIzle3.Clicked += btnIzle3_Clicked;

			var layout = new StackLayout
			{
				BackgroundColor = Color.Black,
				Orientation = StackOrientation.Vertical,
				Padding = 0,
				Children = {
					wordpressresim,

					btnIzle,

					twitterresim,

					btnIzle2,

					youtuberesim,

					btnIzle3

				}
			};

			var scrolView = new ScrollView{Content = layout};
			Content = scrolView;
		}

		void btnIzle_Clicked(object sender, EventArgs e)
		{
			Device.OpenUri(new Uri("https://mertkaplanblog.wordpress.com"));
		}


		void btnIzle2_Clicked(object sender, EventArgs e)
		{
			Device.OpenUri(new Uri("https://twitter.com/mertkaplan_Tr"));
		}

		void btnIzle3_Clicked(object sender, EventArgs e)
		{
			Device.OpenUri(new Uri("https://www.youtube.com/user/mertkaplanblog"));
		}
	}
}

