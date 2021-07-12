using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Models
{
    public class PurchasedTicket
    {
        public int ID { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public DateTime PurchaseDate { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Ticket Ticket { get; set; }
    }
}
