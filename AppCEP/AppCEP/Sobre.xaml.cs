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
	public partial class Sobre : ContentPage
	{
		public Sobre ()
		{
			InitializeComponent ();
		}

        private void ButtonSiteSenac_Clicked(object sender, EventArgs e)
        {
            string url = "http://www.sp.senac.br/botucatu";

            //Navegador nativo
            //Device.OpenUri(new Uri(url)); //chama o navegador padrão

            //WebView
            //"mascarando o navegador"

            var navegador = new WebView();
            navegador.Source = url;

            NavigationPage.SetHasNavigationBar(this, false); // não mostrar o menu

            Content = navegador;
        }
    }
}