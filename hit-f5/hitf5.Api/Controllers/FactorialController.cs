using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace hitf5.Api.Controllers
{
    
    public class FactorialController : ApiController
    {
        private readonly int minimum = 1;

        public int Get(int value)
        {
            return this.Calculate(value);
        }

        private int Calculate(int value)
        {
            if (value <= minimum)
            {
                return minimum;
            }
            else
            {
                return value * this.Calculate(value - minimum);
            }
        }
    }
}
