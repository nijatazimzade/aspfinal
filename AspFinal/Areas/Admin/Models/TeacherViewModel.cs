using AspFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Areas.Admin.Models
{
    public class TeacherViewModel : BaseEntity
    {
        public AppUser Teacher { get; set; }
        public List<Student> Students { get; set; }

    }
}
