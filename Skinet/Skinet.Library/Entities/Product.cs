using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skinet.Library.Entities
{
    public class Product : BaseEntity
    {
    
        public string Name { get; set; }

        public string Description { get; set; }
        
        public string ProductUrl { get; set; }

        public decimal Prise { get; set; }

        public ProductBrand ProductBrand { get; set; }
        
        public int ProductBrandId { get; set; }
        
        public ProductType ProductType { get; set; }
        
        public int ProductTypeId { get; set; }
    }
}
