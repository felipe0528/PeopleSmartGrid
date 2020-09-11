using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeopleSmartGrid.Interfaces;
using PeopleSmartGrid.Models;

namespace PeopleSmartGrid.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IDataContext _data;

        public PeopleController(IDataContext data)
        {
            _data = data;
        }
        // GET: PeopleController
        public ActionResult Index()
        {
            return View(_data.GetPeople());
        }

        // GET: PeopleController/Details/5
        public ActionResult Details(int id)
        {
            return View(_data.GetPerson(id));
        }

        // GET: PeopleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PeopleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Person person)
        {
            try
            {
                _data.AddPerson(person);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeopleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_data.GetPerson(id));
        }

        // POST: PeopleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Person person)
        {
            try
            {
                _data.EditPerson(person);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeopleController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                _data.DeletePerson(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
