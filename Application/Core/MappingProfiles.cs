using AutoMapper;
using Domain;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Dietitian, Dietitian>();
            CreateMap<Comment, Comment>();
            CreateMap<Patient, Patient>();
            CreateMap<Visit, Visit>();
        }
    }
}