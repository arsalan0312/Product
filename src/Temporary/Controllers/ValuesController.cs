using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Temporary.Dto;
using Temporary.Repo;
using Temporary.Models;

namespace Temporary.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IProductRepo _productRepo;
        public ValuesController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Product value)
        {
            return Ok(_productRepo.add(value));
        }
    }
}
