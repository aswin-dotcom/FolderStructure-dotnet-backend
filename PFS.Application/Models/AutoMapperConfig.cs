using AutoMapper;
using PFS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFS.Application.Models
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
                CreateMap<Student, ADDStudentDTO > ().ReverseMap();
                CreateMap<Student, UPDATEStudentDTO>().ReverseMap();

        }

    }
}
