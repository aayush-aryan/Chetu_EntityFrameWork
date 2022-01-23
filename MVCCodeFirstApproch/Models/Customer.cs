using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCodeFirstApproch.Models
{
    public class Customer
    {
        // id should not be null
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        
        // Location table decleare as foregin key
        public Location Location { get; set; }
    }
}
