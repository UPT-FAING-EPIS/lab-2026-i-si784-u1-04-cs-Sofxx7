using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Shorten.Areas.Identity.Data;

public class ShortenIdentityDbContext : IdentityDbContext<IdentityUser>
{
    public ShortenIdentityDbContext(DbContextOptions<ShortenIdentityDbContext> options)
        : base(options)
    {
    }

}
