using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hitf5.Factorial;
using Microsoft.AspNetCore.Mvc;

namespace hitf5.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactorialController : ControllerBase
    {
        public FactorialController(IFactorialCalculator calculator)
        {
            Calculator = calculator;
        }

        public IFactorialCalculator Calculator { get; }

        // GET api/factorial/5
        [HttpGet("{value}")]
        public ActionResult<int> Get([FromRoute]int value)
        {
            return Calculator.Calculate(value);
        }
    }
}
