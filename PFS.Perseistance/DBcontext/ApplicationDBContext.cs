using Microsoft.EntityFrameworkCore;
using PFS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFS.Perseistance.DBcontext
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
            
        }
       public DbSet<Student> Students { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Student>().HasData(
        //        new Student {Id=0, Name ="aswin samuvel",college="IIT"},
        //        new Student {Id=0, Name = "Logu" ,college="KIT"}
        //        );
        //}
    }
}
