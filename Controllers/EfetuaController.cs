using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BD_VOLVO.Models;

namespace BD_VOLVO{

    [Route("api/[controller]")]
    [ApiController]
    public class EfetuaController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Efetua efetua)
        {
            using (var _context = new HotelContext())
            {
                _context.Efetua.Add(efetua);
                _context.SaveChanges();
            }
        }
 
        [HttpGet]
        public List<Efetua> Get()
        {
            using (var _context = new HotelContext())
            {
                return _context.Efetua.ToList();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Efetua.FirstOrDefault(t => t.fkClienteContaIdConta == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }        
       
    }
}