using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Models
{
    public class Event
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public Location Location { get; set; }
        [Required]
        public User Organizer { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
