using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IOrder
    {
        string Id { get; set; }

        public string CustomerId { get; set; }

        public DateTime DateTime { get; set; }

        public decimal Summa { get; set; }
    }
}
