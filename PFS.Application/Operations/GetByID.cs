using PFS.Perseistance.DBcontext;
using PFS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFS.Application.Operations
{
    public  class GetByID
    {
        private readonly ApplicationDBContext _db;
        public GetByID(ApplicationDBContext db)
        {
            _db = db;
        }
        public async Task<Student> GetByID1(int id)
        {
            Student student = await _db.Students.FindAsync(id);
            return student;
        }

    }
}
