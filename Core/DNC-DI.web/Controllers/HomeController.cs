using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DNC_DI.logic.Handler.Customer;
using Microsoft.AspNetCore.Mvc;

namespace DNC_DI.web.Controllers
{
    public class HomeController : Controller
    {

        IGetCustomersHandler _getCustomersHandler;
        ICreateCustomerHandler _createCustomerHandler;

        public HomeController(IGetCustomersHandler getHandler, ICreateCustomerHandler createHandler)
        {
            _getCustomersHandler = getHandler;
            _createCustomerHandler = createHandler;
        }

        public IActionResult Index()
        {
            return View(_getCustomersHandler.GetCustomers());
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
