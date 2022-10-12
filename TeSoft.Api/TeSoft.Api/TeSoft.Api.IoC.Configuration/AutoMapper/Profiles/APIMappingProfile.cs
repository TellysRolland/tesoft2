using AutoMapper;
using DC = TeSoft.Api.API.DataContracts;
using S = TeSoft.Api.Services.Model;

namespace TeSoft.Api.IoC.Configuration.AutoMapper.Profiles
{
    public class APIMappingProfile : Profile
    {
        public APIMappingProfile()
        {
            CreateMap<DC.User, S.User>().ReverseMap();
            CreateMap<DC.Address, S.Address>().ReverseMap();
        }
    }
}
