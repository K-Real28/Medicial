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
    }
}
