using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace K_Smart_IMS.Models
{
    /* Honestly, this is super silly since we could just use IdentityUser since it has most of the functionality we need but I hate typing IdentityUser so many times
     * Contributed by Cody
     */
    public class User : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        [NotMapped]
        public IList<string> RoleNames { get; set; }

    }
}
