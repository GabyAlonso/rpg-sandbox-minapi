using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgSandbox.Migrations
{
    public partial class PartyRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PartyRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClassPartyRole",
                columns: table => new
                {
                    ClassesId = table.Column<int>(type: "INTEGER", nullable: false),
                    PartyRolesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassPartyRole", x => new { x.ClassesId, x.PartyRolesId });
                    table.ForeignKey(
                        name: "FK_ClassPartyRole_Classes_ClassesId",
                        column: x => x.ClassesId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassPartyRole_PartyRoles_PartyRolesId",
                        column: x => x.PartyRolesId,
                        principalTable: "PartyRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassPartyRole_PartyRolesId",
                table: "ClassPartyRole",
                column: "PartyRolesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassPartyRole");

            migrationBuilder.DropTable(
                name: "PartyRoles");
        }
    }
}
