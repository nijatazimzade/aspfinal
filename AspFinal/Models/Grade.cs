using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Models
{
    public class Grade : BaseEntity
    {
        [Range(0,100)]
        public int Value { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
