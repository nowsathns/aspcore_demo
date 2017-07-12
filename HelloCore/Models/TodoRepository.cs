using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCore.Models
{
    public class TodoRepository : IRepository
    {
        static List<Todo> _items = new List<Todo>()
        {
            new Todo{Title="Santosh",Done=false,Id=1,TaskType=TaskType.High}
        };
        public void Add(Todo item)
        {
            _items.Add(item);
        }

        public List<Todo> GetAll()
        {
            return _items;
        }

        public void Remove(Todo item)
        {
            _items.Remove(item);
        }
    }
}
