using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCore.Models
{
    public class TodoContext : IdentityDbContext<IdentityUser>
    {
        
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }
        public DbSet<Todo> Todos { get; set; }
    }
    //public class UserDbContext : IdentityDbContext<IdentityUser>
    //{
    //    public UserDbContext(DbContextOptions<UserDbContext> options)
    //            : base(options)
    //    {
    //        Database.EnsureCreated();
    //    }
    //}
}
