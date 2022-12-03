using Newtonsoft.Json;
using StoreWeb.DataAccess;
using StoreWeb.Entity.Parameters;
using StoreWeb.Entity.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWeb.Logic
{
    public class BUPais
    {
        private Client client;

        public BUPais()
        {
            client = new Client();
        }

        public List<ResponsePais> listarPaises(ENRegistroEmpresa paramss, string token)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<ResponsePais>>(client.Post<ENRegistroEmpresa>("RegistroEmpresa/listarPaises", paramss, token));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
