using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.models
{
    //sınıfımızın özelliklerini tanımlıyoruz
    public class Door
    {
     // postgre sql bağlantı
     
        
        //constructor(kurucu fonksiyon)  oluşturuluyor
        //kurucu fonksiyon her nesne oluştuğunda otomatik çağırılır
        public Door()

        {
            
            // random sayı üretmek için
            Random rnd = new Random();
            Id = rnd.Next(1, 1000);

        }


        
        
        
        public int Id { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

    }
}
