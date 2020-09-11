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
    public class TypesApiController : ControllerBase
    {
        private readonly IDataContext _data;
        public TypesApiController(IDataContext data)
        {
            _data = data;
        }
        // GET: api/<PeopleController>
        [HttpGet]
        public IEnumerable<PersonType> Get()
        {
            return _data.GetPersonTypes();
        }
    }
}
