using Microsoft.AspNetCore.Identity;

namespace Vlog.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string? firstname { get; set; }
        public string? lastname { get; set;}
        // Relacion
        public List<Posts>? Posts { get; set; }
    }
}
