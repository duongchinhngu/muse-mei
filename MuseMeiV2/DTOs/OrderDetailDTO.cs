﻿

namespace MuseMeiV2.DTOs
{
    public class OrderDetailDTO
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ClothId { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
    }
}
