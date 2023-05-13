using AutoMapper;
using Medicial.Dto.Cities;
using Medicial.Dto.Specializations;
using Medicial.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medicial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecializationsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public SpecializationsController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: 
        [HttpGet]
        [Route("GetSpecialization")]
        public ActionResult<List<SpecializationDto>> GetSpecializations()
        {
            var specializations = _context.Specializations.ToList();
            var specializationDtos = _mapper.Map<List<SpecializationDto>>(specializations);
            return specializationDtos;
        }

        // GET: /specializations/5
        [HttpGet]
        [Route("GetSpecializationById/{id}")]
        public ActionResult<SpecializationDto> GetSpecializationById(int id)
        {
            var specialization = _context.Specializations.FirstOrDefault(c => c.Id == id);
            var specializationDto = _mapper.Map<SpecializationDto>(specialization);
            return specializationDto;
        }

        // POST: /specializations
        [HttpPost]
        [Route("CreateSpecialization")]
        public ActionResult<SpecializationDto> CreateSpecialization(SpecializationDto specializationDto)
        {
            var specialization = _mapper.Map<Specialization>(specializationDto);
            _context.Specializations.Add(specialization);
            _context.SaveChanges();
            return specializationDto;
        }

        // PUT: /specializations/5
        [HttpPut]
        [Route("UpdateSpecializationById/{id}")]
        public ActionResult<SpecializationDto> UpdateSpecializationById(int id, SpecializationDto specializationDto)
        {
            var specialization = _context.Specializations.FirstOrDefault(c => c.Id == id);
            _mapper.Map(specializationDto, specialization);
            _context.SaveChanges();
            return specializationDto;
        }

        // DELETE: /specializations/5
        [HttpDelete]
        [Route("DeleteSpecializationById/{id}")]
        public ActionResult DeleteSpecializationById(int id)
        {
            var specialization = _context.Specializations.FirstOrDefault(c => c.Id == id);
            _context.Specializations.Remove(specialization);
            _context.SaveChanges();
            return Ok();
        }

    }
}
