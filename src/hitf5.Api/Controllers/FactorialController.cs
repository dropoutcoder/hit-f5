using hitf5.Factorial;

using Microsoft.AspNetCore.Mvc;

namespace hitf5.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactorialController : ControllerBase
    {
        private readonly IFactorialCalculator _calculator;

        public FactorialController(IFactorialCalculator calculator)
        {
            _calculator = calculator;
        }

        // GET api/factorial/5
        [HttpGet("{value}")]
        public ActionResult<int> Get(int value)
        {
            return _calculator
                .Calculate(value);
        }
    }
}
