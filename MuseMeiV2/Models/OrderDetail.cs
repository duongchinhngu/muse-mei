using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MuseMeiV2.Models
{
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        [ForeignKey("Cloth")]
        public int ClothId { get; set; }
        public virtual Cloth Cloth { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
    }
}
