using StoreWeb.Entity.Parameters;
using StoreWeb.Logic;
using StoreWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreWeb.Controllers
{
    public class RegistroEmpresaController : Controller
    {
        private modelList model;
        private BUPais bupais;
        public RegistroEmpresaController()
        {
            //Aqui se usa una mala practica de este profesor que da el curso 
            model = new modelList();
            bupais = new BUPais();
        }

        public ActionResult RegistroEmpresa(ENRegistroEmpresa paramss)
        {
            string token = "";

            model.listPais = bupais.listarPaises(paramss, token);

            return View();
        }

    }
}
