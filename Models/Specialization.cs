using Medicial.Models.BaseModels;

namespace Medicial.Models
{
    public class Specialization : NamedBaseEnity
    {
        public List<SpecializationDoctor> SpecializationDoctors { get; set; } = new();
    }
}
