using Medicial.Models.BaseModels;

namespace Medicial.Models
{
    public class City : NamedBaseEnity
    {
        public List<Polyclinic> Polyclinics { get; set; } = new();
    }
}
