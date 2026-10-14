using Microsoft.EntityFrameworkCore;

namespace WebApp_Tolmas.Models {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<School> Schools { get; set; }
    }
}