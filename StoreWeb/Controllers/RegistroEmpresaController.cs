using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreWeb.Controllers
{
    public class RegistroEmpresaController : Controller
    {
        // GET: RegistroEmpresa
        public ActionResult Index()
        {
            return View();
        }

        // GET: RegistroEmpresa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegistroEmpresa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistroEmpresa/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RegistroEmpresa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegistroEmpresa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RegistroEmpresa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegistroEmpresa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
