using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DNC_DI.logic.Handler.Customer;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DNC_DI.web.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
