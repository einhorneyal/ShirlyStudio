using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShirlyStudio.Migrations
{
    public partial class InitailNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Workshop_WorkshopId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Workshop_Teacher_TeacherId",
                table: "Workshop");

            migrationBuilder.DropIndex(
                name: "IX_Category_WorkshopId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Customer_name",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "Workshop_name",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "WorkshopId",
                table: "Category");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Workshop",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Workshop",
                newName: "FullData");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Workshop",
                newName: "TransactionIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Workshop_TeacherId",
                table: "Workshop",
                newName: "IX_Workshop_TransactionIdId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Customer",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Customer",
                newName: "PhoneNumber");

            migrationBuilder.AddColumn<int>(
                name: "TeacherIdId",
                table: "Workshop",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerIdId",
                table: "Transaction",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WorkshopCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    WorkshopId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkshopCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkshopCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkshopCategory_Workshop_WorkshopId",
                        column: x => x.WorkshopId,
                        principalTable: "Workshop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workshop_TeacherIdId",
                table: "Workshop",
                column: "TeacherIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CustomerIdId",
                table: "Transaction",
                column: "CustomerIdId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkshopCategory_CategoryId",
                table: "WorkshopCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkshopCategory_WorkshopId",
                table: "WorkshopCategory",
                column: "WorkshopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Customer_CustomerIdId",
                table: "Transaction",
                column: "CustomerIdId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workshop_Teacher_TeacherIdId",
                table: "Workshop",
                column: "TeacherIdId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workshop_Transaction_TransactionIdId",
                table: "Workshop",
                column: "TransactionIdId",
                principalTable: "Transaction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Customer_CustomerIdId",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Workshop_Teacher_TeacherIdId",
                table: "Workshop");

            migrationBuilder.DropForeignKey(
                name: "FK_Workshop_Transaction_TransactionIdId",
                table: "Workshop");

            migrationBuilder.DropTable(
                name: "WorkshopCategory");

            migrationBuilder.DropIndex(
                name: "IX_Workshop_TeacherIdId",
                table: "Workshop");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_CustomerIdId",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "TeacherIdId",
                table: "Workshop");

            migrationBuilder.DropColumn(
                name: "CustomerIdId",
                table: "Transaction");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Workshop",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "TransactionIdId",
                table: "Workshop",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "FullData",
                table: "Workshop",
                newName: "Time");

            migrationBuilder.RenameIndex(
                name: "IX_Workshop_TransactionIdId",
                table: "Workshop",
                newName: "IX_Workshop_TeacherId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Customer",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Customer",
                newName: "Phone");

            migrationBuilder.AddColumn<string>(
                name: "Customer_name",
                table: "Transaction",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Transaction",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Workshop_name",
                table: "Transaction",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkshopId",
                table: "Category",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_WorkshopId",
                table: "Category",
                column: "WorkshopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Workshop_WorkshopId",
                table: "Category",
                column: "WorkshopId",
                principalTable: "Workshop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workshop_Teacher_TeacherId",
                table: "Workshop",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
