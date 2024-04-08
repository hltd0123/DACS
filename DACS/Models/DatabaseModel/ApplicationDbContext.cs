using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DACS.Models.DatabaseModel
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        //Phone Data
        public DbSet<Phone> Phones { get; set; }
        public DbSet<PhoneImage> PhoneImages { get; set; }
        //Phone case data
        public DbSet<PhoneCase> PhoneCases { get; set; }
        
        public DbSet<PhoneCaseImage> PhoneCaseImages { get; set; }
    }
}
