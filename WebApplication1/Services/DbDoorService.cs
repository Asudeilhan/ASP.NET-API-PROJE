using WebApplication1.models;

namespace WebApplication1.Services
{
    //database kullanımı için dbdoor service oluşturuluyor IdoorService arayüzünden kalıtım alıyor
    public class DbDoorService : IDoorService
    {

        //database ile bağlantı kurmak için
        private readonly ApplicationDbContext _dbContext;
        public DbDoorService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        //fonksiyonların iskeleti oluşturuluyor
        public void Add(Door kapı)
        {
            //ekleme işlemi yapılıyor
            _dbContext.Add(kapı);
            //değişiklikleri kaydetme işlemi yapılıyor
            _dbContext.SaveChanges();

        }

        public void Delete(int dışardanId)
        {
            _dbContext.Remove(dışardanId);
            _dbContext.SaveChanges();
        }

        public List<Door> GetAll()
        {
            return _dbContext.Doors.ToList();
        }

        public Door getOneDoor(int id)
        {
            return _dbContext.Doors.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Door güncelKapı)
        {
            _dbContext.Update(güncelKapı);
        }
    }
}
