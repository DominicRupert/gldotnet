using System;
using System.ComponentModel.DataAnnotations;


namespace gldotnet.Models
{
    public class Car
    {
     

        public int Id { get; set; }
        [Required]

        public string Make { get; set; }

        public int? Price { get; set; }
        public int? Year { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public Profile Creator { get; set; }
    }
}