using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using RpgSandbox.Common;
using RpgSandbox.PlayerArea.Dto;

namespace RpgSandbox.PlayerArea;

public interface IHeroService
{
    Task<IResult> GetHeroes(int userId, int pageNum, int pageSize, int? classId, string name);
    Task<IResult> GetByRole(int userId, int pageNum, int pageSize, int roleId);
    Task<IResult> GetHero(int id);
    Task<IResult> CreateHero(int userId, HeroCreateDto heroCreate);
    Task<IResult> UpdateHero(int userId, HeroUpdateDto heroCreate);
    Task<IResult> DeleteHero(int userId, int id);
    
}

public class HeroService : IHeroService
{
    private readonly IMapper _mapper;
    private readonly RpgDataContext _context;
    
    public HeroService(RpgDataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IResult> GetHeroes(int userId, int pageNum, int pageSize, int? classId, string name)
    {
        var query = _context.Heroes
            .Where(h => h.UserId == userId);
        if (classId.HasValue)
        {
            query = query.Where(h => h.ClassId == classId);
        }
        if (!string.IsNullOrWhiteSpace(name))
        {
            query = query.Where(h => name.Contains(h.Name));
        }

        return Results.Ok(await query
            .OrderBy(h => h.Name)
            .Paginate(pageNum, pageSize)
            .ProjectTo<HeroListDto>(_mapper.ConfigurationProvider)
            .ToListAsync()
        );
    }

    public async Task<IResult> GetByRole(int userId, int pageNum, int pageSize, int roleId)
    {
        return Results.Ok(await _context.Heroes
            .Where(h => h.UserId == userId && h.Class.PartyRoles.Any(p => p.Id == roleId))
            .OrderBy(h => h.Name)
            .Paginate(pageNum, pageSize)
            .ProjectTo<HeroListDto>(_mapper.ConfigurationProvider)
            .ToListAsync()
        );
    }

    public async Task<IResult> GetHero(int id)
    {
        var hero = await _context.Heroes
            .ProjectTo<HeroListDto>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(h => h.Id == id);

        return hero != null ? Results.Ok(hero) : Results.NotFound();
    }

    public Task<IResult> CreateHero(int userId, HeroCreateDto heroCreate)
    {
        throw new NotImplementedException();
    }

    public Task<IResult> UpdateHero(int userId, HeroUpdateDto heroCreate)
    {
        throw new NotImplementedException();
    }

    public Task<IResult> DeleteHero(int userId, int id)
    {
        throw new NotImplementedException();
    }
}