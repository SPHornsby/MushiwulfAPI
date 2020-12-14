using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MushiwulfApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResidenceController : ControllerBase
    {
        private static readonly string[] Addresses = new[]
        {
            "3 Horseshoe Dr.", "205 Turnberry Dr.", "122 Oakmont Dr.", "11 Greenleaf Ct.", "7 Marion Ct.", "3 Marion Ct.", "3 Doral Ct."
        };
        private static readonly string[] Owners = new[]
        {
            "Malcom Reynolds", "Inara Serra", "River Tam", "Kaylee Frye", "Zoe Washburne", "Jayne Cobb", "Hoban Washburne", "Shepherd Book", "Simon Tam", "Saffron"
        };

        private readonly ILogger<ResidenceController> _logger;

        public ResidenceController(ILogger<ResidenceController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Residence> Get()
        {
            var rng = new Random();

            return Enumerable.Range(1, 5).Select(index => new Residence
            {
                Address = Addresses[rng.Next(Addresses.Length)],
                Balance = rng.Next(-20, 55),
                Owner = Owners[rng.Next(Owners.Length)],
            })
            .ToArray();
        }
    }
}
