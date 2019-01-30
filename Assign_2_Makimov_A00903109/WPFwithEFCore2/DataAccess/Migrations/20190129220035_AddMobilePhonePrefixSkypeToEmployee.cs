using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddMobilePhonePrefixSkypeToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MobilePhone",
                table: "Empolyees",
                maxLength: 24,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prefix",
                table: "Empolyees",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Skype",
                table: "Empolyees",
                maxLength: 15,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MobilePhone",
                table: "Empolyees");

            migrationBuilder.DropColumn(
                name: "Prefix",
                table: "Empolyees");

            migrationBuilder.DropColumn(
                name: "Skype",
                table: "Empolyees");
        }
    }
}
