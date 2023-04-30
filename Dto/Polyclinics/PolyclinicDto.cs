using Medicial.Dto.Cities;
using Medicial.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicial.Dto.Polyclinics
{
    public class PolyclinicDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public CityDto? City { get; set; }

        public string? Address { get; set; }
        public uint? PhoneNumber { get; set; }
        public string? Photo { get; set; }

        //public List<PolyclinicDoctor> PolyclinicDoctors { get; set; } = new();
        //public List<SpecializationDoctor> SpecializationDoctors { get; set; } = new();
    }
}
