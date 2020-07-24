using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArtShop.Core.Models
{
    class ProductCategory
    {
        public string Id { get; set; }
        public string Category { get; set; }


        public ProductCategory()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
