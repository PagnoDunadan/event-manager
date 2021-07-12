using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }
        [Required]
        public int Availability { get; set; }
        [Required]
        public Event Event { get; set; }
    }
}
