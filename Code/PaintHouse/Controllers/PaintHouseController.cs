using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Authorization;

namespace PaintHouse.Controllers
{

    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class PaintHouseController : ControllerBase
    {
        
        private List<Entities.PaintHouse> paintHouses = new List<Entities.PaintHouse>();

        private readonly ILogger<PaintHouseController> _logger;

        public PaintHouseController(ILogger<PaintHouseController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Entities.PaintHouse> Get()
        {
            paintHouses.Add(new Entities.PaintHouse() { PersonId = 8, ExteriorPaintMeters= 300,  InteriorPaintMeters = 450, StateInteriorPaint = 40, StateExteriorPaint = 80 });
            paintHouses.Add(new Entities.PaintHouse() { PersonId = 7, ExteriorPaintMeters = 230, InteriorPaintMeters = 320, StateInteriorPaint = 80, StateExteriorPaint = 90 });
            paintHouses.Add(new Entities.PaintHouse() { PersonId = 1, ExteriorPaintMeters = 190, InteriorPaintMeters = 211, StateInteriorPaint = 77, StateExteriorPaint = 10 });
            paintHouses.Add(new Entities.PaintHouse() { PersonId = 2, ExteriorPaintMeters = 643, InteriorPaintMeters = 543, StateInteriorPaint = 10, StateExteriorPaint = 20 });
            paintHouses.Add(new Entities.PaintHouse() { PersonId = 6, ExteriorPaintMeters = 756, InteriorPaintMeters = 750, StateInteriorPaint = 20, StateExteriorPaint = 40 });
            paintHouses.Add(new Entities.PaintHouse() { PersonId = 3, ExteriorPaintMeters = 124, InteriorPaintMeters = 100, StateInteriorPaint = 100, StateExteriorPaint = 50 });
            paintHouses.Add(new Entities.PaintHouse() { PersonId = 4, ExteriorPaintMeters = 898, InteriorPaintMeters = 300, StateInteriorPaint = 30, StateExteriorPaint = 60 });
            paintHouses.Add(new Entities.PaintHouse() { PersonId = 5, ExteriorPaintMeters = 432, InteriorPaintMeters = 112, StateInteriorPaint = 70, StateExteriorPaint = 90 });

            return paintHouses;

        }
    }
}
