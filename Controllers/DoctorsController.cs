using Medicial.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medicial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public DoctorsController(AppDbContext context)
        {
            _context = context;
        }
        // GET: 
        [HttpGet]
        [Route("GetDoctor")]
        public ActionResult<List<Doctor>> GetDoctors()
        {
            return _context.Doctors.ToList();
        }
    }
}
