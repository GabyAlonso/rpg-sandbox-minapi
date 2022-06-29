using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgSandbox.Migrations
{
    public partial class Heroes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Attack = table.Column<int>(type: "INTEGER", nullable: false),
                    Constitution = table.Column<int>(type: "INTEGER", nullable: false),
                    Intellect = table.Column<int>(type: "INTEGER", nullable: false),
                    Resilience = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxHp = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxMp = table.Column<int>(type: "INTEGER", nullable: false),
                    ClassId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Heroes_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Heroes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Attack", "ClassId", "Constitution", "ImageUrl", "Intellect", "Level", "MaxHp", "MaxMp", "Name", "Resilience", "UserId" },
                values: new object[] { 1, 4, 2, 6, "portraits/portrait05.jpg", 4, 2, 50, 20, "Pipo the Mighty", 4, 1 });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Attack", "ClassId", "Constitution", "ImageUrl", "Intellect", "Level", "MaxHp", "MaxMp", "Name", "Resilience", "UserId" },
                values: new object[] { 2, 5, 3, 4, "portraits/portrait38.jpg", 4, 1, 30, 10, "Ada Blackmore", 3, 1 });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Attack", "ClassId", "Constitution", "ImageUrl", "Intellect", "Level", "MaxHp", "MaxMp", "Name", "Resilience", "UserId" },
                values: new object[] { 3, 8, 1, 7, "portraits/portrait01.jpg", 2, 3, 70, 30, "Hector Larsson", 4, 1 });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Attack", "ClassId", "Constitution", "ImageUrl", "Intellect", "Level", "MaxHp", "MaxMp", "Name", "Resilience", "UserId" },
                values: new object[] { 4, 4, 4, 4, "portraits/portrait13.jpg", 4, 1, 30, 10, "Weylyn", 4, 1 });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Attack", "ClassId", "Constitution", "ImageUrl", "Intellect", "Level", "MaxHp", "MaxMp", "Name", "Resilience", "UserId" },
                values: new object[] { 5, 3, 6, 5, "portraits/portrait14.jpg", 6, 3, 70, 30, "Myrelle of the Green", 7, 1 });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Attack", "ClassId", "Constitution", "ImageUrl", "Intellect", "Level", "MaxHp", "MaxMp", "Name", "Resilience", "UserId" },
                values: new object[] { 6, 3, 5, 4, "portraits/portrait18.jpg", 10, 4, 100, 50, "Livia the Bloodbound", 8, 1 });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Attack", "ClassId", "Constitution", "ImageUrl", "Intellect", "Level", "MaxHp", "MaxMp", "Name", "Resilience", "UserId" },
                values: new object[] { 7, 3, 5, 3, "portraits/portrait32.jpg", 6, 2, 50, 20, "Puul the Prophet", 6, 1 });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Attack", "ClassId", "Constitution", "ImageUrl", "Intellect", "Level", "MaxHp", "MaxMp", "Name", "Resilience", "UserId" },
                values: new object[] { 8, 7, 2, 8, "portraits/portrait10.jpg", 6, 4, 100, 50, "Huld of Dalhalla", 4, 1 });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Attack", "ClassId", "Constitution", "ImageUrl", "Intellect", "Level", "MaxHp", "MaxMp", "Name", "Resilience", "UserId" },
                values: new object[] { 9, 5, 4, 6, "portraits/portrait34.jpg", 4, 3, 70, 30, "Roan", 6, 1 });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Attack", "ClassId", "Constitution", "ImageUrl", "Intellect", "Level", "MaxHp", "MaxMp", "Name", "Resilience", "UserId" },
                values: new object[] { 10, 7, 1, 6, "portraits/portrait30.jpg", 2, 2, 50, 20, "Lady Mar", 3, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_ClassId",
                table: "Heroes",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_UserId",
                table: "Heroes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heroes");
        }
    }
}
