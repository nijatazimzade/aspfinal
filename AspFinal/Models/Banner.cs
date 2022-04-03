using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Models
{
    public class Banner : BaseEntity
    {
        [Required, MaxLength(100)]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public string BgColor { get; set; }
    }
}
