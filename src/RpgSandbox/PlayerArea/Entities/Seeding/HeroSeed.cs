using Microsoft.EntityFrameworkCore;
using RpgSandbox.GameSystem.Entities;

namespace RpgSandbox.PlayerArea.Entities.Seeding;

public static class HeroSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        // hardcoded ids because I want some user data
        var warrior = new Class {Id = 1};
        var paladin = new Class {Id = 2};
        var swashbuckler = new Class {Id = 3};
        var ranger = new Class {Id = 4};
        var sorcerer = new Class {Id = 5};
        var druid = new Class {Id = 6};

        var userId = 1;
            
        modelBuilder.Entity<Hero>().HasData(new Hero[]
        {
            new()
            {
                Id= 1,
                Name= "Pipo the Mighty",
                Level= 2,
                MaxHp= 50,
                MaxMp= 20,
                ImageUrl= "portraits/portrait05.jpg",
                ClassId= paladin.Id,
                Attack= 4,
                Constitution= 6,
                Intellect= 4,
                Resilience= 4,
                UserId = userId
            },
            new()
            {
                Id= 2,
                Name= "Ada Blackmore",
                Level= 1,
                MaxHp= 30,
                MaxMp= 10,
                ImageUrl= "portraits/portrait38.jpg",
                ClassId= swashbuckler.Id,
                Attack= 5,
                Constitution= 4,
                Intellect= 4,
                Resilience= 3,
                UserId = userId
            },
            new()
            {
                Id= 3,
                Name= "Hector Larsson",
                Level= 3,
                MaxHp= 70,
                MaxMp= 30,
                ImageUrl= "portraits/portrait01.jpg",
                ClassId= warrior.Id,
                Attack= 8,
                Constitution= 7,
                Intellect= 2,
                Resilience= 4,
                UserId = userId
            },
            new()
            {
                Id= 4,
                Name= "Weylyn",
                Level= 1,
                MaxHp= 30,
                MaxMp= 10,
                ImageUrl= "portraits/portrait13.jpg",
                ClassId= ranger.Id,
                Attack= 4,
                Constitution= 4,
                Intellect= 4,
                Resilience= 4,
                UserId = userId
            },
            new()
            {
                Id= 5,
                Name= "Myrelle of the Green",
                Level= 3,
                MaxHp= 70,
                MaxMp= 30,
                ImageUrl= "portraits/portrait14.jpg",
                ClassId= druid.Id,
                Attack= 3,
                Constitution= 5,
                Intellect= 6,
                Resilience= 7,
                UserId = userId
            },
            new()
            {
                Id= 6,
                Name= "Livia the Bloodbound",
                Level= 4,
                MaxHp= 100,
                MaxMp= 50,
                ImageUrl= "portraits/portrait18.jpg",
                ClassId= sorcerer.Id,
                Attack= 3,
                Constitution= 4,
                Intellect= 10,
                Resilience= 8,
                UserId = userId
            },
            new()
            {
                Id= 7,
                Name= "Puul the Prophet",
                Level= 2,
                MaxHp= 50,
                MaxMp= 20,
                ImageUrl= "portraits/portrait32.jpg",
                ClassId= sorcerer.Id,
                Attack= 3,
                Constitution= 3,
                Intellect= 6,
                Resilience= 6,
                UserId = userId
            },
            new()
            {
                Id= 8,
                Name= "Huld of Dalhalla",
                Level= 4,
                MaxHp= 100,
                MaxMp= 50,
                ImageUrl= "portraits/portrait10.jpg",
                ClassId= paladin.Id,
                Attack= 7,
                Constitution= 8,
                Intellect= 6,
                Resilience= 4,
                UserId = userId
            },
            new()
            {
                Id= 9,
                Name= "Roan",
                Level= 3,
                MaxHp= 70,
                MaxMp= 30,
                ImageUrl= "portraits/portrait34.jpg",
                ClassId= ranger.Id,
                Attack= 5,
                Constitution= 6,
                Intellect= 4,
                Resilience= 6,
                UserId = userId
            },
            new()
            {
                Id= 10,
                Name= "Lady Mar",
                Level= 2,
                MaxHp= 50,
                MaxMp= 20,
                ImageUrl= "portraits/portrait30.jpg",
                ClassId= warrior.Id,
                Attack= 7,
                Constitution= 6,
                Intellect= 2,
                Resilience= 3,
                UserId = userId
            }
        });
    }
}