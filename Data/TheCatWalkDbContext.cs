using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TheCatWalk.Models;
using Microsoft.AspNetCore.Identity;

namespace TheCatWalk.Data;

public class TheCatWalkDbContext : IdentityDbContext<IdentityUser>
{
    private readonly IConfiguration _configuration;
    public DbSet<Post> Posts { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<UserFavorite> UserFavorites { get; set; }
    public DbSet<Comment> Comments { get; set; }

    public TheCatWalkDbContext(DbContextOptions<TheCatWalkDbContext> context, IConfiguration config) : base(context)
    {
        _configuration = config;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = "498b88c7-42f0-42ae-b3c5-6d76431948ca",
            Name = "Admin",
            NormalizedName = "admin"
        });

        modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser[]
        {
            new IdentityUser
           {
            Id = "fe41d529-2033-41ca-9b59-b886ebe208ce",
            UserName = "ZavierHopson",
            Email = "thecreator@fake.com",
            PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, _configuration["AdminPassword"])
           },
           new IdentityUser
           {
            Id = "29f25e30-ae14-46d5-be7a-b332b5e7caca",
            UserName = "KelgrimReaper",
            Email = "thedestroyer@fake.com",
            PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, _configuration["AdminPassword"])
           }
        });

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>[]
        {
            new IdentityUserRole<string>
            {
                UserId = "fe41d529-2033-41ca-9b59-b886ebe208ce",
                RoleId = "498b88c7-42f0-42ae-b3c5-6d76431948ca"
            },
            new IdentityUserRole<string>
            {
                UserId = "29f25e30-ae14-46d5-be7a-b332b5e7caca",
                RoleId ="498b88c7-42f0-42ae-b3c5-6d76431948ca"
            }
        });

        modelBuilder.Entity<UserProfile>().HasData(new UserProfile[]
        {
            new UserProfile
            {
                Id = 1,
                FirstName = "Zavier",
                LastName = "Hopson",
                IdentityUserId = "fe41d529-2033-41ca-9b59-b886ebe208ce",
                IsAdmin = true
            },
            new UserProfile
            {
                Id = 2,
                FirstName = "Zachary",
                LastName = "Joubert",
                IdentityUserId = "29f25e30-ae14-46d5-be7a-b332b5e7caca",
                IsAdmin = true
            }
        });

        modelBuilder.Entity<Tag>().HasData(new Tag[]
        {
            new Tag
            {
                Id = 1,
                TagName = "Fluffy"
            },
            new Tag
            {
                Id = 2,
                TagName = "Long-Haired"
            },
            new Tag
            {
                Id = 3,
                TagName = "Short-Haired"
            },
            new Tag
            {
                Id = 4,
                TagName = "Exotic"
            },
            new Tag
            {
                Id = 5,
                TagName = "Pure Bred"
            },
            new Tag
            {
                Id = 6,
                TagName = "Street Cat"
            }
        });
    }
}