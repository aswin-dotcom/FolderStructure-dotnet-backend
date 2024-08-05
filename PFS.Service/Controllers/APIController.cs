using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PFS.Application.Models;
using PFS.Application.Operations;
using PFS.Domain.Entities;
using PFS.Application.Operations;
namespace PFS.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        private readonly IMapper _map;
        private readonly Get _get;
        private readonly GetByID _get1;
        private readonly DeleteById _Dele1; 
        private readonly UpdateBYID _upid;
        private readonly PatchBYID _pd;
        public APIController(IMapper map,Get get,GetByID get1, DeleteById dele1,UpdateBYID upid,PatchBYID Pd)
        {
            _map = map;
            _get = get;
            _get1 = get1;   
            _Dele1= dele1;
            _upid = upid;
            _pd= Pd;    
        }
        //[Route("api/[controller]")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> getAll()
        {

            List<Student> student =await _get.get1();

            return Ok(_map.Map<List<ADDStudentDTO>>(student));

               


        }
        [HttpGet("id")]
        public async Task<ActionResult<ADDStudentDTO>> getId(int id)
        {
            Student student = await _get1.GetByID1(id);
            return Ok(_map.Map<ADDStudentDTO>(student));
        }
        [HttpDelete("id")]  
        public ActionResult Delete(int id)
        {
            _Dele1.delByID(id);
            return Ok();
        }
        [HttpPost]
        public ActionResult post( [FromBody] ADDStudentDTO student)
            
        {
             _upid.postid( student);
             return Ok("success");

        }
        [HttpPut("id")]
        public ActionResult put(int id, [FromBody] UPDATEStudentDTO students)

        {
            _pd.upId(id, students);
            return Ok("success");
        }


    }
}
