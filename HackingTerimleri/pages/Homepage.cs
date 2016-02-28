using System;
using System.Reflection;
using Xamarin.Forms;
namespace HackingTerimleri
{
	public class Homepage : ContentPage
	{
		public Homepage ()
		{
			this.Title = "Başlangıç";
			var webImage = new Image { Aspect = Aspect.AspectFit };
			webImage.Source = ImageSource.FromUri(new Uri("https://mertkaplanblog.files.wordpress.com/2016/01/wah.png"));
			Label iTanitim = new Label
			{
				TextColor = Color.Green

			};
			iTanitim.Text = "Hacker Terimleri uygulamasına hoşgeldiniz.\n\n\n"
				+ "Bu app siber farkındalık yaratmak için yazılmış olup, application'nun geliştirilmesi adına tüm hakları serbesttir.\n\n" 
				+ "Saygılarımla\n\nMert KAPLAN\nKültür Üniversitesi - Bilgisayar Mühendisliği";

			var layout = new StackLayout
			{
				BackgroundColor = Color.Black,
				Orientation = StackOrientation.Vertical,
				Padding = 0,
				Children = {
					webImage,
					iTanitim
				}
			};
			var scrollView = new ScrollView { Content = layout };
			Content = scrollView;
		}
	}
}




