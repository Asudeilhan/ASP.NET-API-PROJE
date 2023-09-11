using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    

    // iki nokta ile controller baseden kalıtım yapılıyor
    public class DoorController : ControllerBase
    {

        //db service yapısıyla bağlantı kurmak için
        IDoorService _dbDoorService;
        public DoorController(IDoorService dbDoorService)
        {
            _dbDoorService = dbDoorService;
        }


 
        
        [HttpPost] //Ekleme işlemi için
        // ( ) iki parantezin iççine yazılanlar parametre(dışardan) olarak alınır
        public void Add ( Door kapı )
        {
            _dbDoorService.Add(kapı);

        }

        

        [HttpGet] 
        public List<Door> GetAll()
        {
            return _dbDoorService.GetAll();

        }


        [HttpGet("{id}")] 
        public Door GetOneDoor(int id)
        {
            return _dbDoorService.getOneDoor(id);

        }



        [HttpPut] 
        public void Update( Door güncelKapı )
        {
            _dbDoorService.Update(güncelKapı);
           
        }


        [HttpDelete("{dışardanId}")]  
        public void Delete(int dışardanId)
        {
            _dbDoorService.Delete(dışardanId);


        }

    }
}
