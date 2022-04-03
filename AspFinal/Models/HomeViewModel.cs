using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Models
{
    public class HomeViewModel
    {
        public List<Banner> Banners { get; set; }
        public List<AppUser> Users { get; set; }
        public List<Field> Fields { get; set; }
        public List<Feature> Features { get; set; }
        public List<Group> Groups { get; set; }


    }
}
