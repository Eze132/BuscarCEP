using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace AppCEP
{
    public class RestCorreios
    {
        public async Task<JSonCEP> BuscapCEP(string cep)
        {
            try
            {
                var servico = new HttpClient();
                //var json = await servico.GetStringAsync(string.Format( "http://viacep.com.br/ws/{0}/json/",cep));
                var json = await servico.GetStringAsync($"http://viacep.com.br/ws/{cep}/json/");//Binding
                var dados = JsonConvert.DeserializeObject<JSonCEP>(json);
                return dados;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
