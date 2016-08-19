using System;

using Xamarin.Forms;

namespace Hello
{
	public class App : Application
	{
		public App ()
		{


			// The root page of your application
			//MainPage = new ContentPage
			MainPage = new NavigationPage(new EverydayLife());
			     /*
				new TabbedPage
			{
				Children =
				{
					new Categories(),
					new Events(),
					new Extras()
				}
			};
				*/
			/*{
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Center,
					Padding = 30,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "INTEGREAT"
						},
					btn,
					}
				}
			};*/
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

