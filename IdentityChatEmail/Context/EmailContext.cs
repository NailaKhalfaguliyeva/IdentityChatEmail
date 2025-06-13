using IdentityChatEmail.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityChatEmail.Context
{
    public class EmailContext : IdentityDbContext<AppUser>
    {
        public EmailContext(DbContextOptions<EmailContext> options) : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }
    }
}

