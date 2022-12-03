using StoreWeb.Entity.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreWeb.Models
{
    public class modelList
    {
        public List<ResponsePais> listPais { get; set; }
        public List<ResponseMoneda> listMoneda { get; set; }
        public List<ResponsePImpuestos> listPImpuestos { get; set; }

    }
}