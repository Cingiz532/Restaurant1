using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public short ProductPrice { get; set; }
        public string ProductDescription { get; set; } = string.Empty;
        public int ProductCount { get; set; }
    }
}
