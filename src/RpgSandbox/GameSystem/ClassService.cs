using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using RpgSandbox.Common;
using RpgSandbox.GameSystem.Dto;

namespace RpgSandbox.GameSystem;

public class ClassService : IClassService
{
    private readonly IMapper _mapper;
    private readonly RpgDataContext _context;
    
    public ClassService(RpgDataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public async Task<IResult> GetClassList() 
    {
        return Results.Ok(await _context.Classes
            .OrderBy(r => r.Name)
            .ProjectTo<ClassListingDto>(_mapper.ConfigurationProvider)
            .ToListAsync());
    }
    
    public async Task<IResult> GetClasses() 
    {
        return Results.Ok(await _context.Classes
            .OrderBy(r => r.Name)
            .ProjectTo<ClassDto>(_mapper.ConfigurationProvider)
            .ToListAsync());
    }
    
    public async Task<IResult> GetClass (int id) 
    {
        var result = await _context.Classes
            .ProjectTo<ClassDto>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(c => c.Id == id);

        return result != null ? Results.Ok(result) : Results.NotFound();
    }

    public async Task<IResult> GetRoles()
    {
        return Results.Ok(await _context.PartyRoles
            .OrderBy(r => r.Id)
            .ProjectTo<RoleDto>(_mapper.ConfigurationProvider)
            .ToListAsync());
    }
    
    public async Task<IResult> GetClassesByRole(int roleId) 
    {
        return Results.Ok(await _context.Classes
            .Where(c => c.PartyRoles.Any(r => r.Id == roleId))
            .OrderBy(r => r.Name)
            .ProjectTo<ClassListingDto>(_mapper.ConfigurationProvider)
            .ToListAsync());
    }
}