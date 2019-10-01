using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCEP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrincipalPage : ContentPage
	{
		public PrincipalPage ()
		{
			InitializeComponent ();
            //NavigationPage.SetHasNavigationBar(this, false);
		}

        private void ButtonNuGet1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NuGetPage());
        }

        private void ButtonNuGet2_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonRestPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new JSonPage());
        }

        private async void ButtonSoapPage_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new MainPage());
        }
    }
}