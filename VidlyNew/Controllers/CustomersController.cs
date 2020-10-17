using System.Collections.Generic;
using System.Web.Mvc;
using VidlyNew.Models;
using VidlyNew.ViewModels;

namespace VidlyNew.Controllers
{
    public class CustomersController : Controller
    {
        [Route("customers")]
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1 ", Id = 1},
                new Customer {Name = "Customer 2 ", Id = 2}
            };

            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }
    }
}