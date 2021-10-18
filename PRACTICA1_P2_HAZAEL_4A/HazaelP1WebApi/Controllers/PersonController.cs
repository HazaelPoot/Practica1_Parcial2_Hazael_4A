using System.Collections;
using Microsoft.AspNetCore.Mvc;
using HazaelP1WebApi.Repositories;
using HazaelP1WebApi.Domain;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        } 
    }
}