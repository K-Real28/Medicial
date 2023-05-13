using AutoMapper;
using Medicial.Dto.Cities;
using Medicial.Dto.Doctors;
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
        private readonly IMapper _mapper;
        public DoctorsController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]

        //GET: 
        [HttpGet]
        [Route("GetDoctor")]
        public ActionResult<List<DoctorDto>> GetDoctors()
        {
            var doctors = _context.Doctors.ToList();
            var doctorDtos = _mapper.Map<List<DoctorDto>>(doctors);
            return doctorDtos;
        }
    }
}
