using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MuseMeiV2.Models
{
    public abstract class FashionProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        [MaxLength(50)]
        public string Origin { get; set; }
        [MaxLength(225)]
        public string Material { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [MaxLength(225)]
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
