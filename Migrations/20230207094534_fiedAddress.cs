using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CallCenter.Migrations
{
    public partial class fiedAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "ClientApplication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "ClientApplication");
        }
    }
}
