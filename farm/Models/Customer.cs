using System;
using System.ComponentModel.DataAnnotations;

namespace farm.Models
{
    public class Customer
    {

        public int ID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Name of the product can not be longer than 100 chars")]
        public String Name { get; set; }

        [Required]
        public int Phone { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Name of the product can not be longer than 100 chars")]
        public String Address { get; set; }

    }
}
