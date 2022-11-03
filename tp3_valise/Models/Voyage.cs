using System.Collections.Generic;

namespace tp3_valise.Models
{
    public class Voyage
    {
        public int Id { get; set; }

        public string VoyageName { get; set; }

        public List<ApplicationUser> Users { get; set;}



    }
}
