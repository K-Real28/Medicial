using AutoMapper;
using Medicial.Dto.Cities;
using Medicial.Dto.Polyclinics;
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
        private readonly IMapper _mapper;
        public PolyclinicsController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: 
        [HttpGet]
        [Route("GetPolyclinic")]
        public ActionResult<List<PolyclinicDto>> GetPolyclinics()
        {
            var polyclinics = _context.Polyclinics.ToList();
            var PolyclinicDtos = _mapper.Map<List<PolyclinicDto>>(polyclinics);
            return PolyclinicDtos;
        }
    }
}
