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
	public partial class MenuPage : MasterDetailPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
            Detail = new NavigationPage(new PrincipalPage());
		}

        private void PaginaSoap_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MainPage());
            IsPresented = false;//Fecha o menu
        }

        private void PaginaSobre_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Sobre());
            IsPresented = false;
        }

        private void PaginaRest_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new JSonPage());
            IsPresented = false;
        }

        private void PaginaNuget_Tapped(object sender, EventArgs e)
        {

        }
    }
}