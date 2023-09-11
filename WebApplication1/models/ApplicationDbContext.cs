namespace WebApplication1.models
{
    using Microsoft.EntityFrameworkCore;

    //database ile bağlantı kurmak için oluşturlan sınıf
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        //hangi sınıfın tablosu oluşcaksa buraya yazıyoruz
        public DbSet<Door> Doors { get; set; }



    }
}
