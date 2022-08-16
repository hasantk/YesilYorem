using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductThumbnailImage { get; set; }
        public string ImageUrl { get; set; }
        public float Price { get; set; }
        public int ProductStok { get; set; }
        public DateTime ProductCreateTime { get; set; }
        public bool ProductStatus { get; set; }
        public List<Comment> comment { get; set; }
        public int UserId { get; set; }
        public User users { get; set; }
        public int CategoryId { get; set; }
        public Category categories { get; set; }

    }
}
