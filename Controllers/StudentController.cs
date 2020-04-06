
using Microsoft.AspNetCore.Cors;
using StudentApp.Domain;
using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentApp.Controllers
{

    
    public class StudentController : ApiController
    {
        StudentDomain studentDomain;
        
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            
           /* var db = new EFContext();
            var students = db.Students.ToList();*/
            return Ok(studentDomain.GetAll());
        }

        [HttpPost]
        public IHttpActionResult Post(Student student)
        {
            
            studentDomain.AddStudent(student);
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult GetBy(int id)
        {

            return Ok(studentDomain.GetById(id));
        }
        [HttpPut]
        public IHttpActionResult Put(int id,Student student)
        {
            studentDomain.UpdateStudent(id, student);
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            studentDomain.deleteStudent(id);
            return Ok();
        }
        public StudentController()
        {
            studentDomain = new StudentDomain();
        }
    }
}
