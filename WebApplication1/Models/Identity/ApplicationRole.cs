using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models.Identity
{
    public class ApplicationRole : IdentityRole<int>
    {
        
        internal static readonly string Administrator = nameof(Administrator);

        internal static readonly string Customer = nameof(Customer);
    }
}
