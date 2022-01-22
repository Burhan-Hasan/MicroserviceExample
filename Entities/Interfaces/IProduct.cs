using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IProduct
    {
        int Id { get; set; }

        string Name { get; set; }

        decimal Price { get; set; }
    }
}
