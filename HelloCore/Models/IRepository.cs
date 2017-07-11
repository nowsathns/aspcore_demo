using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCore.Models
{
    public interface IRepository
    {
        void Add(Todo item);
        void Remove(Todo item);
        List<Todo> GetAll();
    }
}
