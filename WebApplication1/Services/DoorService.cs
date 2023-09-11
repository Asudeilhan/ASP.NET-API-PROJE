using WebApplication1.models;

namespace WebApplication1.Services 
{
    //bellek kullanımı için
    public class DoorService : IDoorService
    {
        //door listesi oluşturuluyor 
        //Model ile bağlantı kurmak için
        private static readonly List<Door> _door = new List<Door>();// bu kodun amacı bellekte bir liste oluşturmak ve bu listeye erişmek için bir referans oluşturmak 



        public void Add(Door kapı)
        {
            // .Add() ile listeye ekleme yapılıyor
            _door.Add(new Door()
            {

                // eşittirin solundakiler new dooor() ile oluşturulan nesnenin özellikleri
                // eşittirin sağındakiler ise dışardan gelen parametreler   
                X = kapı.X,
                Y = kapı.Y,

            });

        }

        public List<Door> GetAll()
        {
            return _door;
        }

        public Door getOneDoor(int id)
        {
            // .FirstOrDefault() ile listeden istenilen elemanı getirme işlemi yapılıyor
            Door arananKapı = _door.FirstOrDefault(door => door.Id == id);


            return arananKapı;
        }

        public void Update(Door güncelKapı)
        {
            // .FirstOrDefault() ile listeden istenilen elemanı getirme işlemi yapılıyor
            Door güncellencekKapı = _door.FirstOrDefault(door => door.Id == güncelKapı.Id);

            // eşittirin solundakiler new dooor() ile oluşturulan nesnenin özellikleri
            // eşittirin sağındakiler ise dışardan gelen parametreler
            güncellencekKapı.X = güncelKapı.X;
            güncellencekKapı.Y = güncelKapı.Y;
            // Diğer özellikleri de güncellemek isterseniz burada güncelleyebilirsiniz.
        }


        public void Delete(int dışardanId)
        {

            // .FirstOrDefault() ile listeden istenilen elemanı getirme işlemi yapılıyor
            Door silinecekKapı = _door.FirstOrDefault(door => door.Id == dışardanId);

            // .Remove() ile listeden silme işlemi yapılıyor
            _door.Remove(silinecekKapı);
        }


    }
}
