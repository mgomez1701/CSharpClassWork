using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDAy28Ex1.Migrations
{
    public partial class intitalmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Location = table.Column<string>(maxLength: 50, nullable: false),
                    Type = table.Column<string>(maxLength: 50, nullable: true),
                    Budget = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "Budget", "Location", "Name", "Type" },
                values: new object[] { 1, 0.29999999999999999, "East Wing", "Accounting", "Finance" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "Budget", "Location", "Name", "Type" },
                values: new object[] { 2, 5000000.0, "West Wing", "Marketing", "Advertising" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "Budget", "Location", "Name", "Type" },
                values: new object[] { 3, 16.0, "Sales Floor", "Sales", "Peons" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DepartmentId", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 2, 1, "YTannen@McFly.co", "Biff", "Tannen" },
                    { 5, 1, "Emmet@Brown.co", "Emmett", "Brown" },
                    { 4, 2, "Jennifer@McFly.co", "Jennifer", "Parker" },
                    { 6, 2, "Clara@Brown.co", "Clara", "Clayton" },
                    { 1, 3, "Marty@McFly.co", "Marty", "McFly" },
                    { 3, 3, "George@McFly.co", "George", "McFly" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
