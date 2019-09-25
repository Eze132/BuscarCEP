using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected virtual void OnAppering()
        {
            entryCEP.Focus();
        }

        private void ButtonBuscar_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entryCEP.Text))
            {
                var servico = DependencyService.Get<ICorreios>();
                servico.BuscaCEP(entryCEP.Text);

                labelResultado.Text = string.Format("Endereço: {0}\n" +
                                                    "Bairro: {1}\n" +
                                                    "Cidade: {2}\n" +
                                                    "UF: {3}", aCEP.endereco, aCEP.bairro, aCEP.cidade, aCEP.UF);
            }
            else
            {
                DisplayAlert("Ops...","Houve um erro","OK");
            }
        }
    }
}
