using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("Extended IdentityRole")]
    public class ApplicationRole : IdentityRole<Guid>
    {
        [MaxLength(ApplicationRoleConstants.BulgarianNameMaxLength)]
        [Comment("Name of role in bulgarian")]
        public string? BulgarianName { get; set; } = string.Empty;
    }
}
