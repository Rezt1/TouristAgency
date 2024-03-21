using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TouristAgency.Infrastructure.Data.ValidationConstants;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("Extended IdentityUser")]
    public class ApplicationUser : IdentityUser<Guid>
    {
        [MaxLength(ApplicationUserConstants.FirstNameMaxLength)]
        [Comment("First name of user")]
        public string? FirstName { get; set; }

        [MaxLength(ApplicationUserConstants.LastNameMaxLength)]
        [Comment("Last name of user")]
        public string? LastName { get; set; }
    }
}
