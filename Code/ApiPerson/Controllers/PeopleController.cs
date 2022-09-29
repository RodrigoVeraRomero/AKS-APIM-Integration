using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPerson.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private List<Person> people = new List<Person>();

        private readonly ILogger<PeopleController> _logger;

        public PeopleController(ILogger<PeopleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            people.Add(new Person() { Id = 1, Name = "Liam", LastName = "Smith", Age = 31 });
            people.Add(new Person() { Id = 2, Name = "Noah", LastName = "Johnson", Age = 45 });
            people.Add(new Person() { Id = 3, Name = "Oliver", LastName = "Brown", Age = 62 });
            people.Add(new Person() { Id = 4, Name = "Emma", LastName = "Davis", Age = 23 });
            people.Add(new Person() { Id = 5, Name = "Elijah", LastName = "Miller", Age = 34 });
            people.Add(new Person() { Id = 6, Name = "Mia", LastName = "Anderson", Age = 89 });
            people.Add(new Person() { Id = 7, Name = "James", LastName = "Thomas", Age = 67 });
            people.Add(new Person() { Id = 8, Name = "William", LastName = "Taylor", Age = 11 });

            return people;

        }
    }
}
