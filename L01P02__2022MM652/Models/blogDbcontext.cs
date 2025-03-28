using Microsoft.EntityFrameworkCore;
namespace L01P02__2022MM652.Models
{
    public class blogDbcontext : DbContext
    {
        public blogDbcontext(DbContextOptions options) : base(options) 
        {

        }  
        public DbSet<roles> roles { get; set; }
        public DbSet<usuarios> usuarios { get; set; }
        public DbSet<publicaciones> publicaciones { get; set; }
        public DbSet<comentarios> comentarios { get; set; }
        public DbSet<calificaciones> calificaciones { get; set; }
    }
}
