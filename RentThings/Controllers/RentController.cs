using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using RentThings.Interfaces;
using RentThings.Services;

namespace RentThings.Controllers
{
    public class RentController : Controller
    {
        public IRentService _rentService;

        public RentController(IRentService rentService)
        {
            _rentService = rentService;
        }
        // GET: Rent
        public ActionResult BrowseItems()
        {
            var products = _rentService.GetAllFreeProducts();
            return View(products);
        }

        public ActionResult DetailProduct(int id)
        {
            var product = _rentService.GetProductById(id);
            return View(product);
        }
    }
}