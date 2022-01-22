using Entities.Interfaces;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrdersService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private List<IOrder> _orders;
        // GET: api/<ProductsController>

        public OrdersController()
        {
            _orders = new List<IOrder>()
            {
                new Order("njdEQ2d122","qwe",DateTime.Now.AddHours(-1), 155.58m),
                new Order("njqwdsa13","asd", DateTime.Now.AddHours(-2), 458.65m),
                new Order("njfegr22","zxc", DateTime.Now.AddHours(-3), 1520.25m),
                new Order("sdahdrfr2","bvb", DateTime.Now.AddHours(-4), 478.54m)
            };
        }

        [HttpGet]
        public IEnumerable<IOrder> Get()
        {
            return _orders;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public IOrder Get(string id)
        {
            return _orders.FirstOrDefault(x => x.Id == id);
        }
    }
}
