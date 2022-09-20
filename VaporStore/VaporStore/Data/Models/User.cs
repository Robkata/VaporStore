using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VaporStore.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
