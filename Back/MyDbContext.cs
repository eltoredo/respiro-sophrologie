using Microsoft.EntityFrameworkCore;
using Respiro.Models;

namespace Respiro
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<MedicalSession> MedicalSessions { get; set; }
    }
}
