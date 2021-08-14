using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Sample : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            return View();
        }

        // GET: Sample/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpPost]
        // GET: Sample/Create
        public ActionResult Create(FormOneViewModel model)
        {
            try
            {
                String FirstName = model.FirstName;
                String LastName = model.LastName;
                ViewBag.FullName = FirstName + " " + LastName;

                return View();
            }
            catch
            {
               
            return View();
            }
        }

        // POST: Sample/Create
        [HttpPost]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Sample/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sample/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Sample/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sample/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
