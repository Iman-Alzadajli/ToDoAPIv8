using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using ToDoAPIv8.Models;

namespace ToDoAPIv8.Context
{
    public class ApplicationDbContext : DbContext
    {



        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        //DbSet 

        public DbSet<Todo> todos { get; set; }
        public DbSet<Category> categories { get; set; }


    }

}
