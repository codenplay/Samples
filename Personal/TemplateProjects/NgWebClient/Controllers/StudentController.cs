using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NgWebClient.Models;

namespace NgWebClient.Controllers
{
    public class StudentController : ApiController
    {
        // GET api/<controller>        // GET api/<controller>
        public ResponseModel Get()
        {
            return new ResponseModel() { IsSuccess = true, Data = GetStudents() };
        }

        private List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "Mr. Fox",
                    Address = "Beside river",
                    Phone = "1234"
                },
                new Student()
                {
                    Id = 2,
                    Name = "Mr. Croc",
                    Address = "In river",
                    Phone = "4567"
                }
            };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}