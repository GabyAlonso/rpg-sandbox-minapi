using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgSandbox.Migrations
{
    public partial class ClassAbiolitySeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Description", "ImageUrl", "InitialAttack", "InitialConstitution", "InitialIntellect", "InitialMaxHp", "InitialMaxMp", "InitialResilience", "Name" },
                values: new object[] { 1, "A heavy hitting fighter", "classes/warrior.png", 6, 5, 2, 30, 10, 3, "Warrior" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Description", "ImageUrl", "InitialAttack", "InitialConstitution", "InitialIntellect", "InitialMaxHp", "InitialMaxMp", "InitialResilience", "Name" },
                values: new object[] { 2, "A holy knight", "classes/paladin.png", 4, 5, 3, 30, 10, 4, "Paladin" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Description", "ImageUrl", "InitialAttack", "InitialConstitution", "InitialIntellect", "InitialMaxHp", "InitialMaxMp", "InitialResilience", "Name" },
                values: new object[] { 3, "A versatile fighter", "classes/swashbuckler.png", 5, 4, 4, 30, 10, 3, "Swashbuckler" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Description", "ImageUrl", "InitialAttack", "InitialConstitution", "InitialIntellect", "InitialMaxHp", "InitialMaxMp", "InitialResilience", "Name" },
                values: new object[] { 4, "A hunter and tracker", "classes/ranger.png", 4, 4, 4, 30, 10, 4, "Ranger" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Description", "ImageUrl", "InitialAttack", "InitialConstitution", "InitialIntellect", "InitialMaxHp", "InitialMaxMp", "InitialResilience", "Name" },
                values: new object[] { 5, "A powerful magician", "classes/sorcerer.png", 3, 3, 5, 30, 10, 5, "Sorcerer" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Description", "ImageUrl", "InitialAttack", "InitialConstitution", "InitialIntellect", "InitialMaxHp", "InitialMaxMp", "InitialResilience", "Name" },
                values: new object[] { 6, "A nature mystic", "classes/druid.png", 3, 4, 4, 30, 10, 5, "Druid" });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "BaseCost", "ClassId", "Description", "Name", "UnlockedAtLevel" },
                values: new object[] { 10, 1, 1, "Hits enemy with shield", "Shield Bash", 1 });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "BaseCost", "ClassId", "Description", "Name", "UnlockedAtLevel" },
                values: new object[] { 11, 3, 1, "Takes damage in stead of ally", "Protect Ally", 2 });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "BaseCost", "ClassId", "Description", "Name", "UnlockedAtLevel" },
                values: new object[] { 12, 5, 1, "Area attack", "Steelstorm", 3 });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "BaseCost", "ClassId", "Description", "Name", "UnlockedAtLevel" },
                values: new object[] { 20, 1, 2, "Heals ally", "Holy Heal", 1 });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "BaseCost", "ClassId", "Description", "Name", "UnlockedAtLevel" },
                values: new object[] { 21, 3, 2, "Sears enemy with holy light", "Hammer of Justice", 2 });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "BaseCost", "ClassId", "Description", "Name", "UnlockedAtLevel" },
                values: new object[] { 22, 5, 2, "Sears all enemies in area", "Templar Flame", 3 });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "BaseCost", "ClassId", "Description", "Name", "UnlockedAtLevel" },
                values: new object[] { 30, 1, 3, "A quick attack", "Rush", 1 });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "BaseCost", "ClassId", "Description", "Name", "UnlockedAtLevel" },
                values: new object[] { 31, 3, 3, "Strikes the enemy several times", "Flourish", 2 });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "BaseCost", "ClassId", "Description", "Name", "UnlockedAtLevel" },
                values: new object[] { 32, 5, 3, "Hits nearest 3 enemies", "Lord of Scoundrels", 3 });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "BaseCost", "ClassId", "Description", "Name", "UnlockedAtLevel" },
                values: new object[] { 40, 1, 4, "Heals a small amount and removes status ailments", "Apply Salve", 1 });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "BaseCost", "ClassId", "Description", "Name", "UnlockedAtLevel" },
                values: new object[] { 41, 3, 4, "Shoots arrows at all enemies in an area", "Sidewinder", 2 });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "BaseCost", "ClassId", "Description", "Name", "UnlockedAtLevel" },
                values: new object[] { 42, 5, 4, "Summons animal companion", "Summon Companion", 3 });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "BaseCost", "ClassId", "Description", "Name", "UnlockedAtLevel" },
                values: new object[] { 50, 1, 5, "Attacks and stuns an enemy", "Lightning Strike", 1 });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "BaseCost", "ClassId", "Description", "Name", "UnlockedAtLevel" },
                values: new object[] { 51, 3, 5, "Reflects next spell cast on target", "Mirror Mirror", 2 });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "BaseCost", "ClassId", "Description", "Name", "UnlockedAtLevel" },
                values: new object[] { 52, 5, 5, "A devastating area attack", "Bloodcrown", 3 });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "BaseCost", "ClassId", "Description", "Name", "UnlockedAtLevel" },
                values: new object[] { 60, 1, 6, "Heals and removes status ailments", "Innerforce", 1 });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "BaseCost", "ClassId", "Description", "Name", "UnlockedAtLevel" },
                values: new object[] { 61, 3, 6, "Temporarily stuns an enemy", "Flock of Ravens", 2 });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "BaseCost", "ClassId", "Description", "Name", "UnlockedAtLevel" },
                values: new object[] { 62, 5, 6, "Heals all allies in an area", "Goddess Blessing", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
