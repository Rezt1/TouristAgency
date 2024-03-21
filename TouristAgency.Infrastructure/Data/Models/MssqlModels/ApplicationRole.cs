using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace TouristAgency.Infrastructure.Data.Models.MssqlModels
{
    [Comment("Extended IdentityRole")]
    public class ApplicationRole : IdentityRole<Guid>
    {
    }
}
