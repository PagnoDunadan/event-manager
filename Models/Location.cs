using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Models
{
    public class Location
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public int PostalCode { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string HomeNumberOrName { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
