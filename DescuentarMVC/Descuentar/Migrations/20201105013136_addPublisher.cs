using Microsoft.EntityFrameworkCore.Migrations;

namespace Descuentar.Migrations
{
    public partial class addPublisher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "companyName",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "users");

            migrationBuilder.CreateTable(
                name: "publishers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: false),
                    companyName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publishers", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "publishers");

            migrationBuilder.AddColumn<string>(
                name: "companyName",
                table: "users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
