using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Identity
{
    public class ApplicationUser : IdentityUser<int>
    {
        [StringLength(250)]
        public string ProfileImageUrl { get; set; }
    }
}
