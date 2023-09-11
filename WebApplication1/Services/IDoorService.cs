using WebApplication1.models;

namespace WebApplication1.Services
{

    //service arayüzü oluşturuluyor
  

    public interface IDoorService
    {


        //fonksiyonların iskeleti oluşturuluyor
        void Add(Door kapı);

        List<Door> GetAll();

        Door getOneDoor(int id);

        void Update(Door güncelKapı);

        void Delete(int dışardanId);


    }
}
