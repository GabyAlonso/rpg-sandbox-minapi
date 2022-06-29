using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgSandbox.Migrations
{
    public partial class PartyRolesSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PartyRoles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Tank" });

            migrationBuilder.InsertData(
                table: "PartyRoles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Healer" });

            migrationBuilder.InsertData(
                table: "PartyRoles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Support" });

            migrationBuilder.InsertData(
                table: "PartyRoles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Melee DPS" });

            migrationBuilder.InsertData(
                table: "PartyRoles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Range DPS" });

            migrationBuilder.InsertData(
                table: "ClassPartyRole",
                columns: new[] { "ClassesId", "PartyRolesId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ClassPartyRole",
                columns: new[] { "ClassesId", "PartyRolesId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "ClassPartyRole",
                columns: new[] { "ClassesId", "PartyRolesId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "ClassPartyRole",
                columns: new[] { "ClassesId", "PartyRolesId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "ClassPartyRole",
                columns: new[] { "ClassesId", "PartyRolesId" },
                values: new object[] { 2, 4 });

            migrationBuilder.InsertData(
                table: "ClassPartyRole",
                columns: new[] { "ClassesId", "PartyRolesId" },
                values: new object[] { 3, 4 });

            migrationBuilder.InsertData(
                table: "ClassPartyRole",
                columns: new[] { "ClassesId", "PartyRolesId" },
                values: new object[] { 3, 5 });

            migrationBuilder.InsertData(
                table: "ClassPartyRole",
                columns: new[] { "ClassesId", "PartyRolesId" },
                values: new object[] { 4, 3 });

            migrationBuilder.InsertData(
                table: "ClassPartyRole",
                columns: new[] { "ClassesId", "PartyRolesId" },
                values: new object[] { 4, 4 });

            migrationBuilder.InsertData(
                table: "ClassPartyRole",
                columns: new[] { "ClassesId", "PartyRolesId" },
                values: new object[] { 4, 5 });

            migrationBuilder.InsertData(
                table: "ClassPartyRole",
                columns: new[] { "ClassesId", "PartyRolesId" },
                values: new object[] { 5, 3 });

            migrationBuilder.InsertData(
                table: "ClassPartyRole",
                columns: new[] { "ClassesId", "PartyRolesId" },
                values: new object[] { 5, 5 });

            migrationBuilder.InsertData(
                table: "ClassPartyRole",
                columns: new[] { "ClassesId", "PartyRolesId" },
                values: new object[] { 6, 2 });

            migrationBuilder.InsertData(
                table: "ClassPartyRole",
                columns: new[] { "ClassesId", "PartyRolesId" },
                values: new object[] { 6, 3 });

            migrationBuilder.InsertData(
                table: "ClassPartyRole",
                columns: new[] { "ClassesId", "PartyRolesId" },
                values: new object[] { 6, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassPartyRole",
                keyColumns: new[] { "ClassesId", "PartyRolesId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ClassPartyRole",
                keyColumns: new[] { "ClassesId", "PartyRolesId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ClassPartyRole",
                keyColumns: new[] { "ClassesId", "PartyRolesId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ClassPartyRole",
                keyColumns: new[] { "ClassesId", "PartyRolesId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ClassPartyRole",
                keyColumns: new[] { "ClassesId", "PartyRolesId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ClassPartyRole",
                keyColumns: new[] { "ClassesId", "PartyRolesId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ClassPartyRole",
                keyColumns: new[] { "ClassesId", "PartyRolesId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ClassPartyRole",
                keyColumns: new[] { "ClassesId", "PartyRolesId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "ClassPartyRole",
                keyColumns: new[] { "ClassesId", "PartyRolesId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ClassPartyRole",
                keyColumns: new[] { "ClassesId", "PartyRolesId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "ClassPartyRole",
                keyColumns: new[] { "ClassesId", "PartyRolesId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "ClassPartyRole",
                keyColumns: new[] { "ClassesId", "PartyRolesId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "ClassPartyRole",
                keyColumns: new[] { "ClassesId", "PartyRolesId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ClassPartyRole",
                keyColumns: new[] { "ClassesId", "PartyRolesId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "ClassPartyRole",
                keyColumns: new[] { "ClassesId", "PartyRolesId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "PartyRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PartyRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PartyRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PartyRoles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PartyRoles",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
