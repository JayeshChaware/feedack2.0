using Feedback.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Feedback2._0.Data
{
    public class Feedback2_0Context : IdentityDbContext<IdentityUser>
    {
        public Feedback2_0Context(DbContextOptions<Feedback2_0Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<FeedbackUser> Users { get; set; }
        public DbSet<FeedbackRating> Feedbacks { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
