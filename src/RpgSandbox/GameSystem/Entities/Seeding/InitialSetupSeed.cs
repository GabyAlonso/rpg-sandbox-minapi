using Microsoft.EntityFrameworkCore;

namespace RpgSandbox.GameSystem.Entities.Seeding;

public static class InitialSetupSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var warrior = new Class
        {
            Id = 1,
            Name = "Warrior",
            Description = "A heavy hitting fighter",
            ImageUrl = "classes/warrior.png",
            InitialAttack = 6,
            InitialConstitution = 5,
            InitialIntellect = 2,
            InitialResilience = 3,
            InitialMaxHp = 30,
            InitialMaxMp = 10
        };

        var paladin = new Class
        {
            Id = 2,
            Name = "Paladin",
            Description = "A holy knight",
            ImageUrl = "classes/paladin.png",
            InitialAttack = 4,
            InitialConstitution = 5,
            InitialIntellect = 3,
            InitialResilience = 4,
            InitialMaxHp = 30,
            InitialMaxMp = 10
        };

        var swashbuckler = new Class
        {
            Id = 3,
            Name = "Swashbuckler",
            Description = "A versatile fighter",
            ImageUrl = "classes/swashbuckler.png",
            InitialAttack = 5,
            InitialConstitution = 4,
            InitialIntellect = 4,
            InitialResilience = 3,
            InitialMaxHp = 30,
            InitialMaxMp = 10
        };

        var ranger = new Class
        {
            Id = 4,
            Name = "Ranger",
            Description = "A hunter and tracker",
            ImageUrl = "classes/ranger.png",
            InitialAttack = 4,
            InitialConstitution = 4,
            InitialIntellect = 4,
            InitialResilience = 4,
            InitialMaxHp = 30,
            InitialMaxMp = 10
        };

        var sorcerer = new Class
        {
            Id = 5,
            Name = "Sorcerer",
            Description = "A powerful magician",
            ImageUrl = "classes/sorcerer.png",
            InitialAttack = 3,
            InitialConstitution = 3,
            InitialIntellect = 5,
            InitialResilience = 5,
            InitialMaxHp = 30,
            InitialMaxMp = 10
        };

        var druid = new Class
        {
            Id = 6,
            Name = "Druid",
            Description = "A nature mystic",
            ImageUrl = "classes/druid.png",
            InitialAttack = 3,
            InitialConstitution = 4,
            InitialIntellect = 4,
            InitialResilience = 5,
            InitialMaxHp = 30,
            InitialMaxMp = 10
        };

        modelBuilder.Entity<Class>().HasData(warrior, paladin, swashbuckler, ranger, sorcerer, druid);

        modelBuilder.Entity<Ability>().HasData(new Ability[]
        {
            new()
            {
                Id = 10,
                Name = "Shield Bash",
                Description = "Hits enemy with shield",
                BaseCost = 1,
                UnlockedAtLevel = 1,
                ClassId = warrior.Id
            },
            new()
            {
                Id = 11,
                Name = "Protect Ally",
                Description = "Takes damage in stead of ally",
                BaseCost = 3,
                UnlockedAtLevel = 2,
                ClassId = warrior.Id
            },
            new()
            {
                Id = 12,
                Name = "Steelstorm",
                Description = "Area attack",
                BaseCost = 5,
                UnlockedAtLevel = 3,
                ClassId = warrior.Id
            },
            new()
            {
                Id= 20,
                Name= "Holy Heal",
                Description= "Heals ally",
                BaseCost= 1,
                UnlockedAtLevel= 1,
                ClassId = paladin.Id
            }, 
            new()
            {
                Id= 21,
                Name= "Hammer of Justice",
                Description= "Sears enemy with holy light",
                BaseCost= 3,
                UnlockedAtLevel= 2,
                ClassId = paladin.Id
            }, 
            new (){
                Id= 22,
                Name= "Templar Flame",
                Description= "Sears all enemies in area",
                BaseCost= 5,
                UnlockedAtLevel= 3,
                ClassId = paladin.Id
            },
            new()
            {
                Id= 30,
                Name= "Rush",
                Description= "A quick attack",
                BaseCost= 1,
                UnlockedAtLevel= 1,
                ClassId = swashbuckler.Id
            }, 
            new()
            {
                Id= 31,
                Name= "Flourish",
                Description= "Strikes the enemy several times",
                BaseCost= 3,
                UnlockedAtLevel= 2,
                ClassId = swashbuckler.Id
            }, 
            new()
            {
                Id= 32,
                Name= "Lord of Scoundrels",
                Description= "Hits nearest 3 enemies",
                BaseCost= 5,
                UnlockedAtLevel= 3,
                ClassId = swashbuckler.Id
            },
            new()
            {
                Id= 40,
                Name= "Apply Salve",
                Description= "Heals a small amount and removes status ailments",
                BaseCost= 1,
                UnlockedAtLevel= 1,
                ClassId = ranger.Id
            }, 
            new()
            {
                Id= 41,
                Name= "Sidewinder",
                Description= "Shoots arrows at all enemies in an area",
                BaseCost= 3,
                UnlockedAtLevel= 2,
                ClassId = ranger.Id
            }, 
            new() 
            {
                Id= 42,
                Name= "Summon Companion",
                Description= "Summons animal companion",
                BaseCost= 5,
                UnlockedAtLevel= 3,
                ClassId = ranger.Id
            },
            new()
            {
                Id= 50,
                Name= "Lightning Strike",
                Description= "Attacks and stuns an enemy",
                BaseCost= 1,
                UnlockedAtLevel= 1,
                ClassId = sorcerer.Id
            }, 
            new()
            {
                Id= 51,
                Name= "Mirror Mirror",
                Description= "Reflects next spell cast on target",
                BaseCost= 3,
                UnlockedAtLevel= 2,
                ClassId = sorcerer.Id
            }, 
            new()
            {
                Id= 52,
                Name= "Bloodcrown",
                Description= "A devastating area attack",
                BaseCost= 5,
                UnlockedAtLevel= 3,
                ClassId = sorcerer.Id
            },
            new()
            {
                Id= 60,
                Name= "Innerforce",
                Description= "Heals and removes status ailments",
                BaseCost= 1,
                UnlockedAtLevel= 1,
                ClassId = druid.Id
            }, 
            new()
            {
                Id= 61,
                Name= "Flock of Ravens",
                Description= "Temporarily stuns an enemy",
                BaseCost= 3,
                UnlockedAtLevel= 2,
                ClassId = druid.Id
            }, 
            new()
            {
                Id= 62,
                Name= "Goddess Blessing",
                Description= "Heals all allies in an area",
                BaseCost= 5,
                UnlockedAtLevel= 3,
                ClassId = druid.Id
            }
        });

        var tank = new PartyRole { Id = 1, Name = "Tank" };
        var healer = new PartyRole { Id = 2, Name = "Healer" };
        var support = new PartyRole { Id = 3, Name = "Support" };
        var melee = new PartyRole { Id = 4, Name = "Melee DPS" };
        var range = new PartyRole { Id = 5, Name = "Range DPS" };
        
        modelBuilder.Entity<PartyRole>().HasData(tank, healer, support, melee, range);

        var partyRoleId = "PartyRolesId";
        var classId = "ClassesId";
        modelBuilder.Entity("ClassPartyRole").HasData(
            new Dictionary<string, object>
            {
                [partyRoleId] = tank.Id,
                [classId] = 1
            },
            new Dictionary<string, object>
            {
                [partyRoleId] = melee.Id,
                [classId] = 1
            },
            new Dictionary<string, object>
            {
                [partyRoleId] = tank.Id,
                [classId] = 2
            },
            new Dictionary<string, object>
            {
                [partyRoleId] = healer.Id,
                [classId] = 2
            },
            new Dictionary<string, object>
            {
                [partyRoleId] = melee.Id,
                [classId] = 2
            },
            new Dictionary<string, object>
            {
                [partyRoleId] = range.Id,
                [classId] = 3
            },
            new Dictionary<string, object>
            {
                [partyRoleId] = melee.Id,
                [classId] = 3
            },
            new Dictionary<string, object>
            {
                [partyRoleId] = support.Id,
                [classId] = 4
            },
            new Dictionary<string, object>
            {
                [partyRoleId] = range.Id,
                [classId] = 4
            },
            new Dictionary<string, object>
            {
                [partyRoleId] = melee.Id,
                [classId] = 4
            },
            new Dictionary<string, object>
            {
                [partyRoleId] = support.Id,
                [classId] = 5
            },
            new Dictionary<string, object>
            {
                [partyRoleId] = range.Id,
                [classId] = 5
            },
            new Dictionary<string, object>
            {
                [partyRoleId] = healer.Id,
                [classId] = 6
            },
            new Dictionary<string, object>
            {
                [partyRoleId] = support.Id,
                [classId] = 6
            },
            new Dictionary<string, object>
            {
                [partyRoleId] = range.Id,
                [classId] = 6
            }
        );
    }
}