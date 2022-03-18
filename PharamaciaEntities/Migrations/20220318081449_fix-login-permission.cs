using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharamaciaEntities.Migrations
{
    public partial class fixloginpermission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccessType",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Password", "UserName", "AccessType" },
                values: new object[,]
                {
                    { "db123", "dirBoss", "director" },
                    { "mmm111", "man1", "manager" },
                    { "mmm222", "man2", "manager" },
                    { "mmm333", "man3", "manager" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "Password", "UserName" },
                keyValues: new object[] { "db123", "dirBoss" });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "Password", "UserName" },
                keyValues: new object[] { "mmm111", "man1" });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "Password", "UserName" },
                keyValues: new object[] { "mmm222", "man2" });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumns: new[] { "Password", "UserName" },
                keyValues: new object[] { "mmm333", "man3" });

            migrationBuilder.DropColumn(
                name: "AccessType",
                table: "Users");
        }
    }
}
