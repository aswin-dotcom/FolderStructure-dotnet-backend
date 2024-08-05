using PFS.Application.Models;
using PFS.Perseistance.DBcontext;
using PFS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace PFS.Application.Operations
{
    public  class PatchBYID
    {
        private readonly ApplicationDBContext _db;
        private readonly IMapper _map;
       public PatchBYID(ApplicationDBContext db, IMapper map)
        {
            _db = db;
            _map = map;
        }
        public void upId(int id,UPDATEStudentDTO student)
        {
            Student stu = _db.Students.Find(id);
            Student stus = _map.Map(student,stu);
            _db.Students.Update(stus);
            _db.SaveChanges();

            
        }
    }
}
