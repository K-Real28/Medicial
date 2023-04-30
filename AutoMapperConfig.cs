using AutoMapper;
using Medicial.Dto.Cities;
using Medicial.Dto.Doctors;
using Medicial.Dto.Polyclinics;
using Medicial.Dto.Specializations;
using Medicial.Models;

namespace Medicial
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<City, CityDto>();             
            CreateMap<Doctor, DoctorDto>();             
            CreateMap<Polyclinic, PolyclinicDto>();             
            CreateMap<Specialization, SpecializationDto>();             
        }
    }
}
