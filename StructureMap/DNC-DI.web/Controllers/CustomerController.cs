using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNC_DI.logic.Handler.Customer;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DNC_DI.web.Controllers
{
    public class CustomerController : Controller
    {

        private readonly IMediator _mediatr;

        public CustomerController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        // GET: Customer
        public async Task<ActionResult> Index()
        {
            var getResponse = await _mediatr.Send(new GetCustomersRequest());
            return View(getResponse.Customers);
        }

        // GET: Customer/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var response = await _mediatr.Send(new GetCustomerByIDRequest
            {
                ID = id
            });

            return View(response.Customer);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}