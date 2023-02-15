using Microsoft.EntityFrameworkCore;
using Milgot.Repositories;
using Milgot.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Milgot.Context
{
    public class MyDBContext: DbContext,IContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Children> Childrens { get; set;  }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PracticomProject;Trusted_Connection=True;");
        }
    }
}
