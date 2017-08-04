using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OptimalWork.Controllers
{
    public class HomeController : Controller
    {
        private Models.TiendaEntities bd = new Models.TiendaEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buscar(string id="")
        {
            //Lógica de acceso a base de datos
            var productos = bd.Producto
                .Where(x=>x.Descripcion.Contains(id))
                .Take(20)
                .ToList();
            //Lista de productos
            ViewBag.clave = id;
            return View(productos);
        }
    }
}