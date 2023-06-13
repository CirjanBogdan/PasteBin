using Microsoft.EntityFrameworkCore;
using PasteBinTest.Models;

namespace PasteBinTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<TextModel> TextFragmentsDb { get; set; }
    }
}
