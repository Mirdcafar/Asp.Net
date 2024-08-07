using Microsoft.EntityFrameworkCore;
using Shop.Models.Configuration;
using System.Reflection.Emit;

namespace Shop.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
            
        }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Hotels> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<HotelComment> HotelComments { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.ApplyConfiguration(new HotelCommentConfiguration());
            model.ApplyConfiguration(new CountryConfiguration());
            model.ApplyConfiguration(new HotelConfiguration());
            model.ApplyConfiguration(new CommentConfiguration());
            base.OnModelCreating(model);
        }
    }
}
