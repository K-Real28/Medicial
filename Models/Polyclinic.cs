using System.ComponentModel.DataAnnotations.Schema;
using Medicial.Models.BaseModels;

namespace Medicial.Models
{
    public class Polyclinic : NamedBaseEnity
    {
        public int? CityId { get; set; }
        [ForeignKey("CityId")]
        public City? City { get; set; }

        public string? Address { get; set; }
        public uint? PhoneNumber { get; set; }
        public string? Photo { get; set; }

        public List<PolyclinicDoctor> PolyclinicDoctors { get; set; } = new();
        public List<SpecializationDoctor> SpecializationDoctors { get; set; } = new();
    }
}
