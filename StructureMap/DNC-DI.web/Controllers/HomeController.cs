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

        private readonly IMediator _mediatr;

        public HomeController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
