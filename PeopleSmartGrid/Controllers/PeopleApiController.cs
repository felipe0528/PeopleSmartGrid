using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PeopleSmartGrid.Interfaces;
using PeopleSmartGrid.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PeopleSmartGrid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleApiController : ControllerBase
    {
        private readonly IDataContext _data;
        public PeopleApiController(IDataContext data)
        {
            _data = data;
        }
        // GET: api/<PeopleController>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _data.GetPeople();
        }

        // GET api/<PeopleController>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return _data.GetPerson(id);
        }

        // POST api/<PeopleController>
        [HttpPost]
        public Person Post([FromBody] Person person)
        {
            return _data.AddPerson(person);
        }

        // PUT api/<PeopleController>/5
        [HttpPut]
        public Person Put([FromBody] Person person)
        {
            return _data.EditPerson(person);
        }

        // DELETE api/<PeopleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            bool result = _data.DeletePerson(id);
        }
    }
}
