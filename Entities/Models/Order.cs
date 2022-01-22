using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Order : IOrder
    {
        public string Id {get; set;}
        public string CustomerId {get; set;}
        public DateTime DateTime { get; set; }
        public decimal Summa { get; set; }

        public Order(string id, string customerid, DateTime datetime, decimal summa) => (Id, CustomerId, DateTime, Summa) = (id, customerid, datetime, summa);
    }
}
