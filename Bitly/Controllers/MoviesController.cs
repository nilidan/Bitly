using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bitly.Models;

namespace Bitly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "The Shadow" };
            return View(movie);
        }
    }
}