using Microsoft.EntityFrameworkCore;

namespace Segundo_Parcial.Models
{
    public class MySQLDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;user=admin_tutorias;password=321;dbname=uadeo_tutorias;port=3306");
            base.OnConfiguring(optionsBuilder);
        }
    }
}