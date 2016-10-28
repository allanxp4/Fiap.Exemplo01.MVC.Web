using Fiap.Exemplo01.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Web.Controllers
{

    public class ProdutoController : Controller
    {
        private static List<Produto> _lista = new List<Produto>();

        // GET: Produto
        [HttpGet]
        public ActionResult Listar()
        {   
            return View(_lista);
        }

        [HttpGet]
        public ActionResult Cadastrar() { 
            TempData["success"] = false;
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Produto produto)
        {
            _lista.Add(produto);
            TempData["success"] = true;
            return View(produto);
            //return Content(produto.Nome + " " + produto.Quantidade + " " + produto.Valor);
        }
    }
}