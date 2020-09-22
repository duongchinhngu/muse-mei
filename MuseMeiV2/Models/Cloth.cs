using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MuseMeiV2.Models
{
    public class Cloth : FashionProduct
    {
        public int Size { get; set; }
        [MaxLength(20)]
        public string Color { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
