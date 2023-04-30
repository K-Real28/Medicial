using Medicial.Dto.Polyclinics;
using Medicial.Models;

namespace Medicial.Dto.Cities
{
    public class CityDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }

        public List<PolyclinicDto> Polyclinics { get; set; } = new();

    }
}
