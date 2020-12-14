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
    public class TransactionController : ControllerBase
    {
        private static readonly string[] Addresses = new[]
        {
            "3 Horseshoe Dr.", "205 Turnberry Dr.", "122 Oakmont Dr.", "11 Greenleaf Ct.", "7 Marion Ct.", "3 Marion Ct.", "3 Doral Ct."
        };
        private static readonly string[] Owners = new[]
        {
            "Malcom Reynolds", "Inara Serra", "River Tam", "Kaylee Frye", "Zoe Washburne", "Jayne Cobb", "Hoban Washburne", "Shepherd Book", "Simon Tam", "Saffron"
        };

        private readonly ILogger<TransactionController> _logger;

        public TransactionController(ILogger<TransactionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Transaction> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Transaction
            {
                Date = DateTime.Now.AddDays(-2),
                Amount = new decimal(4.0)
            })
            .ToArray();
        }
    }
}
