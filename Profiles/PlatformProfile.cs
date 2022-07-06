using AutoMapper;
using PlatformService.Models;
using PlatformService.ViewModels;

namespace PlatformService.Profiles

{
    public class PlatformProfile : Profile
    {
       public PlatformProfile()
       {
            CreateMap<CreatePlatformViewModel, Platform>();
       }
    }
}