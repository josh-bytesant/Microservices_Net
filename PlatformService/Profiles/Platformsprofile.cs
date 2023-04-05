using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class Platformsprofile : Profile
    {
        public Platformsprofile()
        {
            //Source --> Target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}