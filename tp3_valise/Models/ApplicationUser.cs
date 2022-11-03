using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace tp3_valise.Models
{
    public class ApplicationUser : IdentityUser
    {
      

        public List<Voyage> Voyages { get; set; }

    }
}
