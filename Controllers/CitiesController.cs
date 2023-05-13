using AutoMapper;
using Medicial.Dto.Cities;
using Medicial.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Medicial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public CitiesController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //GET: 
        [HttpGet]
        [Route("GetCity")]
        public ActionResult<List<CityDto>> GetCities()
        {
            var cities = _context.Cities.ToList();
            var cityDtos = _mapper.Map<List<CityDto>>(cities);
            return cityDtos;
        }

        // GET: /cities/5
        [HttpGet]
        [Route("GetCityById/{id}")]
        public ActionResult<CityDto> GetCityById(int id)
        {
            var city = _context.Cities.FirstOrDefault(c => c.Id == id);
            var cityDto = _mapper.Map<CityDto>(city);
            return cityDto;
        }

        // POST: /cities
        [HttpPost]
        [Route("CreateCity")]
        public ActionResult<CityDto> CreateCity(CityDto cityDto)
        {
            var city = _mapper.Map<City>(cityDto);
            _context.Cities.Add(city);
            _context.SaveChanges();
            return cityDto;
        }

        // PUT: /cities/5
        [HttpPut]
        [Route("UpdateCityById/{id}")]
        public ActionResult<CityDto> UpdateCityById(int id, CityDto cityDto)
        {
            var city = _context.Cities.FirstOrDefault(c => c.Id == id);
            _mapper.Map(cityDto, city);
            _context.SaveChanges();
            return cityDto;
        }

        // DELETE: /cities/5
        [HttpDelete]
        [Route("DeleteCityById/{id}")]
        public ActionResult DeleteCityById(int id)
        {
            var city = _context.Cities.FirstOrDefault(c => c.Id == id);
            _context.Cities.Remove(city);
            _context.SaveChanges();
            return Ok();
        }
    }
}
