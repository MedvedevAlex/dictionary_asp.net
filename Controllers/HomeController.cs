using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDictionary.Models;

namespace WebDictionary.Controllers
{
    public class HomeController : Controller
    {
        DriverContext driverContext = new DriverContext();
        public ActionResult Index()
        {
            IEnumerable<Driver> drivers = driverContext.Drivers.ToList();

            return View(drivers);
        }

        [HttpGet]
        public ActionResult SearchDriver(string Name)
        {
            IEnumerable<Driver> drivers = driverContext.Drivers.ToList();

            return View(drivers.Where(str => str.LastName.Contains(Name)));
        }
    }
}