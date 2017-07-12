using HelloCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCore.Controllers
{
    [Authorize(ActiveAuthenticationSchemes = "Bearer")]
    [Route("/api/[controller]")]
    public class TodoApiController : Controller
    {

        private readonly TodoContext _context;
        public TodoApiController(TodoContext context)
        {
            this._context = context;


            if (_context.Todos.Count() == 0)
            {
                _context.Todos.Add(new Todo { TaskType = Models.TaskType.High, Title = "Item1", Done = false });
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public IEnumerable<Todo> GetAll()
        {
            return _context.Todos.ToList();
        }
        [HttpGet("{id}", Name = "GetTotoItem")]
        public IActionResult GetById(long id)
        {
            var item = _context.Todos.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Todo item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _context.Todos.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetTotoItem", new { id = item.Id }, item);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var item = _context.Todos.First(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            _context.Todos.Remove(item);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}

