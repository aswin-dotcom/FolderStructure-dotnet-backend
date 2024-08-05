using Microsoft.EntityFrameworkCore.Metadata;
using PFS.Perseistance.DBcontext;
using PFS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PFS.Application.Operations
{
    public  class DeleteById
    {
        private readonly ApplicationDBContext _db;
        public DeleteById(ApplicationDBContext db)
        {
            _db = db;
                
        }
        public Student delByID(int id)
        {
            var student = _db.Students.Find(id);
            _db.Students.Remove(student);
            _db.SaveChanges();
            return student;

        }
    }
}
