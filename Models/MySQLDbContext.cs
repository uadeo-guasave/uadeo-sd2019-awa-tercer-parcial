using Microsoft.EntityFrameworkCore;

namespace Segundo_Parcial.Models
{
    public class MySQLDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;user=root;password=123;dbname=uadeo_tutorias;port=3306");
            base.OnConfiguring(optionsBuilder);
        }
    }
}