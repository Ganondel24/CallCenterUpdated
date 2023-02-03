using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CallCenter.Migrations
{
    public partial class RemoveAge_AddUniqueConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "BenefitNumber",
                table: "Customers",
                type: "nvarchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_BenefitNumber",
                table: "Customers",
                column: "BenefitNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customers_BenefitNumber",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "BenefitNumber",
                table: "Customers",
                type: "nvarchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
