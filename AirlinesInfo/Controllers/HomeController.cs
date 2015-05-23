using AirlinesInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirlinesInfo.Controllers
{
    public class HomeController : Controller
    {
        private AirlinesInfoContext db = new AirlinesInfoContext();

        public ActionResult Index()
        {
            if (User.IsInRole("Admin"))
            {
                return RedirectToAction("Admin");
            }
            else if (User.IsInRole("User")) return RedirectToAction("UserInteraction");
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

        [Authorize(Roles="User")]
        public ActionResult UserInteraction()
        {
            List<ViewModelFlights> result = new List<ViewModelFlights>();

            foreach (var airplane in db.Airplanes.ToList())
            {
                result.Add(new ViewModelFlights() { FlightNumber = airplane.Flight.ID, 
                    Status = airplane.Status, 
                    PlaneType = airplane.Type, 
                    Arival = airplane.Flight.Arival.Name,
                    Departure = airplane.Flight.Departure.Name
                });
            }
            return View(result);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Admin()
        {
            return View();
        }
    }
}