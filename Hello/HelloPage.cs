using System;

using Xamarin.Forms;

namespace Hello
{
	public class HelloPage : ContentPage
	{
		public HelloPage()
		{
			Label label = new Label();
			label.Text = "New Page!";
			this.Content = label;
		}
	}
}


