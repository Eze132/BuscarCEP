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
	public partial class JSonPage : ContentPage
	{
		public JSonPage ()
		{
			InitializeComponent ();
           // NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ButtonBuscarCEPJson_Clicked(object sender, EventArgs e)
        {
            var cliente = new RestCorreios();
            var resultado = cliente.BuscapCEP(entryCEPJson.Text);
            labelResultadoCEPJson.Text = string.Format("Endereço: {0}\n"+
                                                        "Bairro: {1}\n"+
                                                        "Localidade: {2}"+
                                                        "UF: {3}",
                                                        resultado.Result.logradouro,
                                                        resultado.Result.bairro,
                                                        resultado.Result.localidade,
                                                        resultado.Result.uf);
        }
    }
}