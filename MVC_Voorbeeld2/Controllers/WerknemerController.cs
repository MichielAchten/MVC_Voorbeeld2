using MVC_Voorbeeld2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Voorbeeld2.Controllers
{
    public class WerknemerController : Controller
    {
        // GET: Werknemer
        public ActionResult Index()
        {
            return View("AndereNaam");
        }
        [NonAction]
        public void GeenAction()
        {

        }

        public ActionResult AlleWerknemers()
        {
            List<Werknemer> werknemers = new List<Werknemer>();
            werknemers.Add(new Werknemer { Voornaam = "Steven", Wedde = 1000m, InDienst = DateTime.Today });
            werknemers.Add(new Werknemer { Voornaam = "steven", Wedde = 2000m, InDienst = DateTime.Today.AddDays(2) });
            return View(werknemers);
        }
    }
}