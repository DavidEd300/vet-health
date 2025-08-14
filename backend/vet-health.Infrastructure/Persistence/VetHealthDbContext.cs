using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using vet_health.Infrastructure.Identity;
using VetHealth.Domain.Entities;


namespace vet_health.Infrastructure.Persistence 
{
    public class VetHealthDbContext
        : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public VetHealthDbContext(DbContextOptions<VetHealthDbContext> options)
            : base(options) { }

        public DbSet<Pet> Pets => Set<Pet>();
        public DbSet<Post> Posts => Set<Post>();
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<PostLike> PostLikes => Set<PostLike>();
        public DbSet<VeterinarianProfile> VeterinarianProfiles => Set<VeterinarianProfile>();
        public DbSet<Question> Questions => Set<Question>();
        public DbSet<Answer> Answers => Set<Answer>();

        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b);
            
        }
    }
}
