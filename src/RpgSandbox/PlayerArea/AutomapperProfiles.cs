using AutoMapper;
using RpgSandbox.PlayerArea.Dto;
using RpgSandbox.PlayerArea.Entities;

namespace RpgSandbox.PlayerArea;

public class AutomapperProfiles: Profile
{
    public AutomapperProfiles()
    {
        CreateMap<HeroCreateDto, Hero>();
        CreateMap<HeroUpdateDto, Hero>();

        CreateMap<Hero, HeroListDto>()
            .ForMember(l => l.Class, ent => ent
                .MapFrom(h => h.Class.Name)
            )
            .ForMember(l => l.ClassImageUrl, ent => ent
                .MapFrom(h => h.Class.ImageUrl)
            );
        
        CreateMap<Hero, HeroViewDto>()
            .ForMember(v => v.Class, ent => ent
                .MapFrom(v => v.Class.Name)
            )
            .ForMember(v => v.ClassImageUrl, ent => ent
                .MapFrom(v => v.Class.ImageUrl)
            )
            .ForMember(v => v.Stats, ent => ent
                .MapFrom(c => new HeroStatsDto
                {
                    Attack = c.Attack,
                    Resilience = c.Resilience,
                    Constitution = c.Constitution,
                    Intellect = c.Intellect,
                    MaxHp = c.MaxHp,
                    MaxMp = c.MaxMp
                })
            );
    }
}