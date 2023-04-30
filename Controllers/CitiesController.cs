using AutoMapper;
using Medicial.Dto.Cities;
using Medicial.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Medicial.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CitiesController(AppDbContext context)
        {
            _context = context;
        }

        private readonly IMapper _mapper;
        public CitiesController(IMapper mapper)
        {
            _mapper = mapper;
        }

        // GET: 
        [HttpGet]
        [Route("GetCity")]
        public ActionResult<List<City>> GetCities()
        {
            //return Ok(Cities.Select(City => _mapper.Map<CityDto>(City)); 
            return _context.Cities.ToList();
        }

        //[HttpGet]
        //[Route("GetCity")]
        //public IEnumerable<string> GetCities()
        //{
        //    var cities = _context.Cities.Select(c => c.Name).ToList();
        //       return Ok(cities);
        //}
    }
}
