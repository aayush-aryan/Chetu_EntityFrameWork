using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCodeFirstApproch.Models
{
    public class Location
    {
        //declearing as primary key
        [Key] 
      public int Id { get; set; }

        [Required]
        public string Name { get; set; }
          

    }
}
