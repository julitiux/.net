using CursoNETCompleto.Models;
using CursoNETCompleto.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoNETCompleto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //InicioService inicio = new InicioService();
            //inicio.Test("87126", 8273647);

            List<Cadena> cadenas = new List<Cadena>() { new Cadena() { nombre = "Julio"}, new Cadena() { nombre = "Ale"} };

            ViewBag.Message = "Your application description page.";
            ViewBag.Cadenas = cadenas;

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