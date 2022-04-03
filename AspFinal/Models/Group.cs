using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Models
{
    public class Group : BaseEntity
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public string Teacher { get; set; }
        [Required, Range(0,50, ErrorMessage = "Student Count must be between 0-50!")]
        public int StudCount { get; set; }
        [Required]
        public int FieldId { get; set; }
        public Field Field { get; set; }
        public List<Student> Students { get; set; }

    }
}
