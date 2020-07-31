using Microsoft.EntityFrameworkCore.Migrations;

namespace ShitCheats.Server.Migrations
{
    public partial class AddCreatorName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatorName",
                table: "Commands",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatorName",
                table: "Commands");
        }
    }
}
