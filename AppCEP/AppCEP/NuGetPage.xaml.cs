using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ViaCEP;


namespace AppCEP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NuGetPage : ContentPage
	{
		public NuGetPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);

        }

        private void ButtonNuGetBuscar_Clicked(object sender, EventArgs e)
        {
            var resultado = ViaCEP.ViaCEPClient.Search(entryNuGetCEP.Text);
                labelResultadoNuGet.Text = string.Format("Endereço {0}\n"
                                                          + "Bairro: {1}\n" +
                                                          "Cidade: {2}\n" +
                                                          "UF: {3}", resultado.Street,resultado.Complement,resultado.City,resultado.IBGECode);

        }
    }
}