using Microsoft.EntityFrameworkCore.Migrations;

namespace ShirlyStudio.Migrations
{
    public partial class added_duration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelectedCategory",
                table: "Workshop");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Workshop",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Duration",
                table: "Workshop",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Workshop");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Workshop",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "SelectedCategory",
                table: "Workshop",
                nullable: false,
                defaultValue: "");
        }
    }
}
