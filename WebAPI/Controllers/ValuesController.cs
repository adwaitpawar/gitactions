using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]

        public ActionResult<IEnumerable<string>> Get()

        {

         List<string> items = new List<string>

        {

            "Phone",

            "Laptop",

            "Camera"

        };

            return items;
        }

    }
}
