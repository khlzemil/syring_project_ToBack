using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace syring_project_toBack.Migrations
{
    public partial class AboutDepatmentsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AboutDoctors",
                table: "AboutDoctors");

            migrationBuilder.RenameTable(
                name: "AboutDoctors",
                newName: "AboutDoctor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AboutDoctor",
                table: "AboutDoctor",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "AboutDepartment",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutDepartment", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutDepartment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AboutDoctor",
                table: "AboutDoctor");

            migrationBuilder.RenameTable(
                name: "AboutDoctor",
                newName: "AboutDoctors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AboutDoctors",
                table: "AboutDoctors",
                column: "ID");
        }
    }
}
