using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Basket
    {
        [Key]
        public int BasketId { get; set; }
        public int ProductCount { get; set; }
        public float TotalPrice { get; set; }
        public bool BasketStatus { get; set; }
        public int ProductId { get; set; }
        public Product products { get; set; }

    }
}
