﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capy.Models
{
    [Table("Order")]
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public DateTime CreatedDate { get; set; }  = DateTime.UtcNow;
        [Required]
        public int OrderStatusId { get; set; }
        public bool IsDeleted { get; set; }
        [Required]
        [MaxLength(30)]
        public string? Name { get; set; }
        public string? Email { get; set; }
        [Required]
        public string? MobileNumber { get; set; }
        [Required]
        [MaxLength(200)]
        public string? Address { get; set; }
        [Required]
        [MaxLength(30)]
        public string? PaymentMethod { get; set; }
        public bool IsPaid { get; set; }

        public OrderStatus OrderStatus { get; set; }
        public List<OrderDetails> OrderDetail { get; set; }


    }
}
