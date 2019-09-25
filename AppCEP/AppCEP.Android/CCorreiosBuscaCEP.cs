using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

//Diretiva de Compilação: Essa diretiva indica ao sistema AppCEP qual a plataforma que o sistema esta sendo aberto e qual classe lê deve usar. 
[assembly:Dependency(typeof(AppCEP.Droid.CCorreiosBuscaCEP))]
namespace AppCEP.Droid
{
    public class CCorreiosBuscaCEP : ICorreios
    {
        public void BuscaCEP(string cep)
        {
            try
            {
                var correios = new WSCorreios.AtendeClienteService();
                var buscar = correios.consultaCEP(cep);
                aCEP.endereco = buscar.end;
                aCEP.bairro = buscar.bairro;
                aCEP.cidade = buscar.cidade;
                aCEP.UF = buscar.uf;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}