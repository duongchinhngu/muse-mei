
namespace MuseMeiV2.DTOs
{
    public abstract class FashionProductDTO
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public int CategoryId { get; set; }
        public string Origin { get; set; }
        public string Material { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
