using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SalvaMiVida.Service
{
    class RestClient
    {

        public async Task<T> validacionUsuario<T>(string p_username, string p_pass)
        {
            HttpClient client = new HttpClient();
            string url = "https://apex.oracle.com/pls/apex/walterdb/consultas/sesion?username="
                        + p_username + "&pass=" + p_pass;
            var response = await client.GetAsync(url);
            var jsonstring = await response.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonstring);
        }


        public async Task<T> GetUrl<T>(string url)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            var jsonstring = await response.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonstring);
        }
    }
}
