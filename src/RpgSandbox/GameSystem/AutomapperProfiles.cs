using AutoMapper;
using RpgSandbox.GameSystem.Dto;
using RpgSandbox.GameSystem.Entities;

namespace RpgSandbox.GameSystem;

public class AutomapperProfiles : Profile
{
    public AutomapperProfiles()
    {
        CreateMap<Ability, AbilityDto>();

        CreateMap<Class, ClassDto>()
            .ForMember(m => m.InitialStats, ent => ent
                .MapFrom(c => new StatsDto
                {
                    Attack = c.InitialAttack,
                    Resilience = c.InitialResilience,
                    Constitution = c.InitialConstitution,
                    Intellect = c.InitialIntellect,
                    MaxHp = c.InitialMaxHp,
                    MaxMp = c.InitialMaxMp
                }))
            .ForMember(m => m.Roles, ent => ent
                .MapFrom(c => c.PartyRoles.OrderBy(r=>r.Id).Select(r=>r.Name)));

        CreateMap<Class, ClassListingDto>();
        
        CreateMap<PartyRole, RoleDto>();
    }
}