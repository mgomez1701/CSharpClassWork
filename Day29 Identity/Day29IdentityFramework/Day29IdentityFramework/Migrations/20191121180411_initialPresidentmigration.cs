using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Day29IdentityFramework.Migrations
{
    public partial class initialPresidentmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Presidents",
                columns: table => new
                {
                    PresidentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Terms = table.Column<int>(nullable: false),
                    InaugurationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presidents", x => x.PresidentId);
                });

            migrationBuilder.InsertData(
                table: "Presidents",
                columns: new[] { "PresidentId", "InaugurationDate", "Name", "Terms" },
                values: new object[,]
                {
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barak Obama", 2 },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grover Cleveland", 1 },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grover Cleveland", 1 },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gerald Ford", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Presidents");
        }
    }
}
