using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Apifortest.Migrations
{
    public partial class InitialCreate_edit_stucture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_members",
                table: "members");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "members");

            migrationBuilder.DropColumn(
                name: "username",
                table: "members");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "members",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "members",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "brithday",
                table: "members",
                newName: "Brithday");

            migrationBuilder.AddColumn<int>(
                name: "Mid",
                table: "members",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "members",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_members",
                table: "members",
                column: "Mid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_members",
                table: "members");

            migrationBuilder.DropColumn(
                name: "Mid",
                table: "members");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "members");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "members",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "members",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Brithday",
                table: "members",
                newName: "brithday");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "members",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "members",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_members",
                table: "members",
                column: "UserId");
        }
    }
}
