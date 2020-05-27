using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentThings.Models;

namespace RentThings.Interfaces
{
    public interface IRentService
    {
        Product[] GetAllProducts();
    }
}
