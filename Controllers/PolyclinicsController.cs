using Medicial.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medicial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolyclinicsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public PolyclinicsController(AppDbContext context)
        {
            _context = context;
        }
        // GET: 
        [HttpGet]
        [Route("GetPolyclinic")]
        public ActionResult<List<Polyclinic>> GetPolyclinics()
        {
            return _context.Polyclinics.ToList();
        }
    }
}
