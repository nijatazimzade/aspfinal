using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Models
{
    public class Student : BaseEntity
    {
        [Required, MaxLength(50)]
        public string FullName { get; set; }
        [Required, MaxLength(50)]
        public string Email { get; set; }
        [Required]
        public int GroupId { get; set; }
        public Group Group { get; set; }
        [Required, Range(0, 100, ErrorMessage = "CAP must be between 0-100!")]
        public int CAP { get; set; }
        public int PhoneNumber { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
