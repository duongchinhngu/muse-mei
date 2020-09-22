using System;

namespace MuseMeiV2.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
    }
}
