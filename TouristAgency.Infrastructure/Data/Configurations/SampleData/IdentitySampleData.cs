using System.Security.Cryptography;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations.SampleData
{
    internal class IdentitySampleData
    {
        private static ApplicationRole administratorRole = new ApplicationRole()
        {
            Id = Guid.NewGuid(),
            Name = "Administrator",
            NormalizedName = "ADMINISTRATOR",
            BulgarianName = "Администратор"
        };

        private static ApplicationRole specialGuestRole = new ApplicationRole()
        {
            Id = Guid.NewGuid(),
            Name = "Special guest",
            NormalizedName = "SPEICAL GUEST",
            BulgarianName = "Специален гост",
        };

        private static ApplicationUser administrator = new ApplicationUser()
        {
            Id = Guid.NewGuid(),
            UserName = "ivaylo20044@gmail.com",
            NormalizedUserName = "IVAYLO20044@GMAIL.COM",
            Email = "ivaylo20044@gmail.com",
            NormalizedEmail = "IVAYLO20044@GMAIL.COM",
            PasswordHash = Crypto.HashPassword("tupoto22"),
            FirstName = "Ivaylo",
            LastName = "Hristov",
            PhoneNumber = "0877814910",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            TwoFactorEnabled = false,
            AccessFailedCount = 0,
            LockoutEnabled = false,
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            SecurityStamp = Guid.NewGuid().ToString("D")
        };

        public IdentitySampleData()
        {
            AdministratorRole = administratorRole;
            SpecialGuestRole = specialGuestRole;
            Administrator = administrator;
        }

        public ApplicationRole AdministratorRole { get; init; } = null!;
        public ApplicationRole SpecialGuestRole { get; init; } = null!;
        public ApplicationUser Administrator { get; init; } = null!;

        private static class Crypto
        {
            private const int PBKDF2IterCount = 1000;
            private const int PBKDF2SubkeyLength = 256 / 8;
            private const int SaltSize = 128 / 8;

            public static string HashPassword(string password)
            {
                if (password == null)
                {
                    throw new ArgumentNullException("password");
                }

                byte[] salt;
                byte[] subkey;
                using (var deriveBytes = new Rfc2898DeriveBytes(password, SaltSize, PBKDF2IterCount))
                {
                    salt = deriveBytes.Salt;
                    subkey = deriveBytes.GetBytes(PBKDF2SubkeyLength);
                }

                var outputBytes = new byte[1 + SaltSize + PBKDF2SubkeyLength];
                Buffer.BlockCopy(salt, 0, outputBytes, 1, SaltSize);
                Buffer.BlockCopy(subkey, 0, outputBytes, 1 + SaltSize, PBKDF2SubkeyLength);
                return Convert.ToBase64String(outputBytes);
            }
        }
    }
}
