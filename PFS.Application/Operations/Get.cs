
using PFS.Perseistance.DBcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PFS.Perseistance.DBcontext;
using PFS.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace PFS.Application.Operations
{
    public  class Get
    {
        private readonly ApplicationDBContext _db;
        public  Get(ApplicationDBContext db)
        {
            _db = db;   
                
        }
        public  async Task<List<Student>> get1()
        {
            List<Student> stu = await _db.Students.ToListAsync();
            return stu;
        }

    }
}
