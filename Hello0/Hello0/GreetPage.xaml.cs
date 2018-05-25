using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello0
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage : ContentPage
	{
		public GreetPage ()
		{
			InitializeComponent ();

            mySlider.Value = 0.5;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Title", "hello Steph!", "Ok");
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            // e.NewValue = slider position
            myLabel.Text = String.Format("slider postion: {0:F2}", e.NewValue);
        }
    }
}