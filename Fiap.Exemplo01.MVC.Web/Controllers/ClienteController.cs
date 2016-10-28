using Fiap.Exemplo01.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Web.Controllers
{
    public class ClienteController : Controller
    {
        private static List<Cliente> _lista = new List<Cliente>();

        // GET: Cliente
        [HttpGet]
        public ActionResult Index()
        {
            return RedirectToAction("Form");
        }

        [HttpGet]
        public ActionResult Form()
        {
            //TempData["success"] = false;
            return View();
        }

        [HttpPost]
        public ActionResult Form(Cliente cliente)
        {
            _lista.Add(cliente);
            TempData["success"] = true;
            return View(cliente);
        }

        [HttpGet]
        public ActionResult Listar()
        {
            ViewBag.lista = _lista;
            return View();
        }
    }
}