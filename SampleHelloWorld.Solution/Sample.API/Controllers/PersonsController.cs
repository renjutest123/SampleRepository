using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sample.API.Models;

namespace Sample.API.Controllers
{
    public class PersonsController : ApiController
    {
        //This can be read from a database if needed. 
        Person[] persons = new Person[]
        {
            new Person { ID = 1, FirstName = "Jane", LastName = "Doe" },
            new Person { ID = 1, FirstName = "John", LastName = "Smith" }            
        };

        public IHttpActionResult GetAllPersons()
        {
            return Ok(persons.AsEnumerable());            
        }

        public IHttpActionResult GetPerson(int ID)
        {
            var person = persons.FirstOrDefault(p => p.ID == ID);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }
    }
}
