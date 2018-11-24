using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Akron.Negocio;
using Akron.Negocio.Home;
namespace AkronWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Instaniamos la capa Negocio
            var _homeNegocio = new HomeNegocio();
            // Obtenemos los productos NUEVOS y DESTACADOS
            ViewBag.Productosnuevos = _homeNegocio.ObtenerProductosNuevos();
            ViewBag.ProductosDestacados = _homeNegocio.ObtenerProductosDestacados();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}