using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VertoExcercise.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "";
            var client = new WebClients();
            var firstQuery = client.GetWikiGeoSearchAsync();
            var wikiGeoSearchRoot = firstQuery.Result;
            var wikiGeoSearchQuery = wikiGeoSearchRoot.query;
            var wikiGeoSearches = wikiGeoSearchQuery.Geosearch;
            return View(wikiGeoSearches);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}