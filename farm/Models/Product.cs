using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace farm.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Name of the product can not be longer than 100 chars")]
        public String Name { get; set; }

        public String Photo { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Description can not be longer than 200 chars")]
        public String Description { get; set; }
    }
}
