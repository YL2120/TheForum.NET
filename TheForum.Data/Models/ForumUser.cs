using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheForum.Data.Models
{
    public class ForumUser : IdentityUser
    {
        [Column(TypeName = "nvarchar(150)")]
        public string FirstName { get; set; } = null!;

        [Column(TypeName = "nvarchar(150)")]
        public string LastName { get; set; } = null!;

        public byte[] ProfilePicture { get; set; } = null!;

        [Column(TypeName = "nvarchar(100)")]
        public string Signature { get; set; } = null!;
    }
}
