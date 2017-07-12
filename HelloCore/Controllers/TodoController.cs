using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloCore.Models;

namespace HelloCore.Controllers
{

    public class TodoController : Controller
    {
        private IRepository _repo;

        public TodoController(IRepository repo)
        {
            this._repo = repo;

        }
        public IActionResult Index()
        {
            return View(this._repo.GetAll());
        }

        public IActionResult Details(int id)
        {
            var items = _repo.GetAll().Find(x => x.Id == id);
            return View(items);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var items = _repo.GetAll().Find(x => x.Id == id);
            return View(items);
        }
        [HttpPost]
        public IActionResult Edit(Todo item)
        {
            var items = _repo.GetAll().Find(x => x.Id == item.Id);
            items.Title = item.Title;
            items.Done = item.Done;
            item.TaskType = item.TaskType;
            int i = _repo.GetAll().IndexOf(items);
            _repo.GetAll()[i] = items;
            return RedirectToAction("Index");
        }
    }
}