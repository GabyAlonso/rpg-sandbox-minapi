using AutoMapper;
using RpgSandbox.Auth.Dto;
using RpgSandbox.Auth.Entities;

namespace RpgSandbox.Auth;

public class AutomapperProfiles : Profile
{
    public AutomapperProfiles()
    {
        CreateMap<User, LoginResponseDto>();
        CreateMap<SignUpDto, User>();
        CreateMap<LoginDto, User>();
    }
}