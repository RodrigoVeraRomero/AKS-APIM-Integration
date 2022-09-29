using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAdress.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class AdressController : ControllerBase
    {
        private List<Adress> adresses = new List<Adress>();

        private readonly ILogger<AdressController> _logger;

        public AdressController(ILogger<AdressController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Adress> Get()
        {
            adresses.Add(new Adress() { Id = 1, PersonId = 4, Street = "Lake Floyd Circle", Number = 3869, City = "Newark, Delaware(DE)", ZipCode = "19711" });
            adresses.Add(new Adress() { Id = 2, PersonId = 3, Street = "Monroe Street", Number = 123, City = "Houston, Texas(TX)", ZipCode = "77002" });
            adresses.Add(new Adress() { Id = 3, PersonId = 2, Street = "Thompson Drive", Number = 775, City = "Oakland, California(CA)", ZipCode = "94612" });
            adresses.Add(new Adress() { Id = 4, PersonId = 5, Street = "Cherry Camp Road", Number = 2978, City = "Chicago, Illinois(IL)", ZipCode = "60605" });
            adresses.Add(new Adress() { Id = 5, PersonId = 1, Street = "Cunningham Court", Number = 3181, City = "Glen Burnie, Maryland(MD)", ZipCode = "21061" });
            adresses.Add(new Adress() { Id = 6, PersonId = 6, Street = "Woodhill Avenue", Number = 1198, City = "Troy, Michigan(MI)", ZipCode = "48084" });
            adresses.Add(new Adress() { Id = 7, PersonId = 8, Street = "Patterson Street", Number = 1290, City = "Farmington Hills, Michigan(MI)", ZipCode = "48335" });
            adresses.Add(new Adress() { Id = 8, PersonId = 7, Street = "Maxwell Farm Road", Number = 3692, City = "Jacksonville, Florida(FL)", ZipCode = "32217" });

            return adresses;
        }
    }
}
