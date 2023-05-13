using AutoMapper;
using Medicial.Dto.Cities;
using Medicial.Dto.Doctors;
using Medicial.Dto.Specializations;
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
        // GET: /doctors/5
        [HttpGet]
        [Route("GetDoctorById/{id}")]
        public ActionResult<DoctorDto> GetDoctorById(int id)
        {
            var doctor = _context.Doctors.FirstOrDefault(c => c.Id == id);
            var doctorDto = _mapper.Map<DoctorDto>(doctor);
            return doctorDto;
        }

        // POST: /doctors
        [HttpPost]
        [Route("CreateDoctor")]
        public ActionResult<DoctorDto> CreateDoctor(DoctorDto doctorDto)
        {
            var doctor = _mapper.Map<Doctor>(doctorDto);
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
            return doctorDto;
        }

        // PUT: /doctors/5
        [HttpPut]
        [Route("UpdateDoctorById/{id}")]
        public ActionResult<DoctorDto> UpdateDoctorById(int id, DoctorDto doctorDto)
        {
            var doctor = _context.Doctors.FirstOrDefault(c => c.Id == id);
            _mapper.Map(doctorDto, doctor);
            _context.SaveChanges();
            return doctorDto;
        }

        // DELETE: /doctors/5
        [HttpDelete]
        [Route("DeleteDoctorById/{id}")]
        public ActionResult DeleteDoctorById(int id)
        {
            var doctor = _context.Doctors.FirstOrDefault(c => c.Id == id);
            _context.Doctors.Remove(doctor);
            _context.SaveChanges();
            return Ok();
        }
    }
}
