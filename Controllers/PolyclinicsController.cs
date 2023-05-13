﻿using AutoMapper;
using Medicial.Dto.Cities;
using Medicial.Dto.Polyclinics;
using Medicial.Dto.Specializations;
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

        // GET: /polyclinics/5
        [HttpGet]
        [Route("GetPolyclinicById/{id}")]
        public ActionResult<PolyclinicDto> GetPolyclinicById(int id)
        {
            var polyclinic = _context.Polyclinics.FirstOrDefault(c => c.Id == id);
            var PolyclinicDto = _mapper.Map<PolyclinicDto>(polyclinic);
            return PolyclinicDto;
        }

        // POST: /polyclinics
        [HttpPost]
        [Route("CreatePolyclinic")]
        public ActionResult<PolyclinicDto> CreatePolyclinic(PolyclinicDto polyclinicDto)
        {
            var polyclinic = _mapper.Map<Polyclinic>(polyclinicDto);
            _context.Polyclinics.Add(polyclinic);
            _context.SaveChanges();
            return polyclinicDto;
        }

        // PUT: /polyclinics/5
        [HttpPut]
        [Route("UpdatePolyclinicById/{id}")]
        public ActionResult<PolyclinicDto> UpdatePolyclinicById(int id, PolyclinicDto polyclinicDto)
        {
            var polyclinic = _context.Polyclinics.FirstOrDefault(c => c.Id == id);
            _mapper.Map(polyclinicDto, polyclinic);
            _context.SaveChanges();
            return polyclinicDto;
        }

        // DELETE: /polyclinics/5
        [HttpDelete]
        [Route("DeletePolyclinicById/{id}")]
        public ActionResult DeletePolyclinicById(int id)
        {
            var polyclinic = _context.Polyclinics.FirstOrDefault(c => c.Id == id);
            _context.Polyclinics.Remove(polyclinic);
            _context.SaveChanges();
            return Ok();
        }
    }
}
