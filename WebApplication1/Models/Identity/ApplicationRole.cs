using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models.Identity
{
    public class ApplicationRole : IdentityRole<int>
    {
        
        internal static string Administrator;

        internal static string Customer;
    }
}
