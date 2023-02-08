using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CallCenter.Migrations
{
    public partial class d : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FatherName",
                table: "ClientApplication");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FatherName",
                table: "ClientApplication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
