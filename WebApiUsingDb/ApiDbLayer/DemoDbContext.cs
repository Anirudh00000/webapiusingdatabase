using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiDbLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiDbLayer
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext()
        {

        }
        public DemoDbContext(DbContextOptions options)
       : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers{ get; set; }
        public DbSet<Classroom> Classrooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Data Source=DESKTOP-0GGBKPE\SQLEXPRESS;Initial Catalog=FIRSTWEBAPIDATA;Integrated Security=True");
        }
    }
}
