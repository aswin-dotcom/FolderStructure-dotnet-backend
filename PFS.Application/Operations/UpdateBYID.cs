using AutoMapper;
using PFS.Application.Models;
using PFS.Perseistance.DBcontext;
using PFS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PFS.Application.Operations
{
    public  class UpdateBYID
    {
        private readonly ApplicationDBContext _db;
        private readonly IMapper _mapper;
        public UpdateBYID(ApplicationDBContext db,IMapper map)
        {
            _db = db;
            _mapper = map;
             
        }
        public void postid(ADDStudentDTO student)
        {
            _db.Students.Add(_mapper.Map<Student>(student));
            _db.SaveChanges();
        }
    }
}
