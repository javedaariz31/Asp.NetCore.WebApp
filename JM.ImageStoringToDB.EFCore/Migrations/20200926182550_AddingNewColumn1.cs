using Microsoft.EntityFrameworkCore.Migrations;

namespace JM.ImageStoringToDB.EFCore.Data.Migrations
{
    public partial class AddingNewColumn1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ocassion",
                table: "Photos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ocassion",
                table: "Photos");
        }
    }
}
