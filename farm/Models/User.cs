using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace farm.Models
{
    public class User
    {
        [Required]
        [StringLength(100, ErrorMessage = "Name of the product can not be longer than 100 chars")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Name of the product can not be longer than 100 chars")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Name of the product can not be longer than 100 chars")]
        public string Password { get; set; }
    }
}
