using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharamaciaEntities.Migrations
{
    public partial class AddedPropUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserPassword",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserPassword",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserName_UserPassword",
                table: "Employees",
                columns: new[] { "UserName", "UserPassword" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserName_UserPassword",
                table: "Customers",
                columns: new[] { "UserName", "UserPassword" });

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Users_UserName_UserPassword",
                table: "Customers",
                columns: new[] { "UserName", "UserPassword" },
                principalTable: "Users",
                principalColumns: new[] { "UserName", "Password" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Users_UserName_UserPassword",
                table: "Employees",
                columns: new[] { "UserName", "UserPassword" },
                principalTable: "Users",
                principalColumns: new[] { "UserName", "Password" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Users_UserName_UserPassword",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Users_UserName_UserPassword",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_UserName_UserPassword",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Customers_UserName_UserPassword",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UserPassword",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UserPassword",
                table: "Customers");
        }
    }
}
