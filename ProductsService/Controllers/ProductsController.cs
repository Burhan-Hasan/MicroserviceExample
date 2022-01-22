using Entities.Interfaces;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductsService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private List<IProduct> _products;
        // GET: api/<ProductsController>

        public ProductsController()
        {
            _products = new List<IProduct>()
            {
                new Product(1, "Apple", 3.50m),
                new Product(2, "Orange", 5.00m),
                new Product(4, "Strawberry", 8.00m),
                new Product(3, "Banana", 1.50m)
            };
        }

        [HttpGet]
        public IEnumerable<IProduct> Get()
        {
            return _products;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public IProduct Get(int id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }

        //// POST api/<ProductsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ProductsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ProductsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
