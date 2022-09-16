using AutoMapper;
using Task.Data.Models;
using Task.DTOs.Cirtifcation;
using Task.DTOs.User;

namespace Task.AutomapperProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
           
            CreateMap<User, UserReadDTO>();
            CreateMap<Certification, CertificationChildReadDTO>();
        
        }
    }

}
