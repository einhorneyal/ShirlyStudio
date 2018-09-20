using Microsoft.EntityFrameworkCore.Migrations;

namespace ShirlyStudio.Migrations
{
    public partial class add_dropdown : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SelectedCategory",
                table: "Workshop",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelectedCategory",
                table: "Workshop");
        }
    }
}
