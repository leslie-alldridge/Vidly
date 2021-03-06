﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyNew.Models;
using VidlyNew.ViewModels;

namespace VidlyNew.Controllers
{
    public class MoviesController : Controller
    {
        [Route("movies")]
        public ActionResult Index()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1 ", Id = 1},
                new Customer {Name = "Customer 2 ", Id = 2}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}