using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Temporary.Dto;
using Temporary.Repo;
using Temporary.Models;
using System.Linq;
using Temporary.Service.ServiceImplimentation;
using Temporary.Service.Interface;

namespace Temporary.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IProductRepo _productRepo;
        private readonly IProductService _productService;
        public ValuesController(IProductRepo productRepo, IProductService productService)
        {
            _productService = productService;
            _productRepo = productRepo;
        }
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]AddUpdateProductRequestDto value)
        {
            if(ModelState.IsValid)
                return Ok(_productService.AddProduct(value));
            return BadRequest(ModelState);
        }
        //PUT api/values
        [HttpPut("id/{id}")]
        public IActionResult Update([FromRoute]long id, [FromBody]Product  value)
        {
            if (value == null || value.ProductId == null)
            {
                return BadRequest();
            }

            var proID = _productRepo.Find(id);
         
            if (proID == null)
            {
                return NotFound();
            }
            //  proID.isComplete = proID.isComplete;

            _productRepo.Update(value);
            return new NoContentResult();

        }

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
          return  _productRepo.GetAll();
        }
        [HttpGet("id", Name = "ProductName")]
        public IActionResult GetById([FromQuery]long id)
        {
            var productId = _productRepo.Find(id);
            if(productId==null)
            {
                return NotFound();
            }
            return new ObjectResult(productId);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var productname = _productRepo.Find(id);
            if (productname == null)
            {
                return NotFound();
            }
            _productRepo.Remove(id);
            return new NoContentResult();
        }


    }
}
