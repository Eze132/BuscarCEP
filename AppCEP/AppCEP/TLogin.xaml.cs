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
    public partial class TLogin : ContentPage
    {
        public TLogin()
        {
            InitializeComponent();

        }

        private void ButtonLogar_Clicked()
        {

        }

        private  void ButtonLogar_Clicked_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(entryUsuario.Text)||
                string.IsNullOrEmpty(entrySenha.Text))
            {
                 DisplayAlert("ERRO", "°Não deixe os campos em brancos", "OK");


            }
            else if (entryUsuario.Text == "admin" || entrySenha.Text == "123456")
            {
                 Navigation.PushAsync(new MenuPage());
            }

            else
            {
                DisplayAlert("ERRO", "°Senha ou Nome incorretos", "OK");

            }
        }

        private void ButtonLimpar_Clicked(object sender, EventArgs e)
        {
            entryUsuario.Text = "";
            entrySenha.Text = "";
        }
    }
}