using AutoMapper;
using Store.DAL.Models;
using Store.PL.Areas.Dashboard.ViewModels;

namespace Store.PL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {

            CreateMap<ServicesFormVm, Services>().ReverseMap();
            CreateMap<Services, ServicesVm>();
            CreateMap<Services, ServiceDetailsVm>();


        }
    }
}
