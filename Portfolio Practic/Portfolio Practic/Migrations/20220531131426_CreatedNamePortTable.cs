using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Practic.Migrations
{
    public partial class CreatedNamePortTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MyProperty",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "MyProperty");
        }
    }
}
