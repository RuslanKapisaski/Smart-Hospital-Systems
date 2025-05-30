using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_System.Migrations
{
    /// <inheritdoc />
    public partial class UserIdAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_roles_RoleId",
                schema: "public",
                table: "users");

            migrationBuilder.DropColumn(
                name: "RoleName",
                schema: "public",
                table: "roles");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                schema: "public",
                table: "users",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_users_roles_RoleId",
                schema: "public",
                table: "users",
                column: "RoleId",
                principalSchema: "public",
                principalTable: "roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_roles_RoleId",
                schema: "public",
                table: "users");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                schema: "public",
                table: "users",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "RoleName",
                schema: "public",
                table: "roles",
                type: "integer",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_users_roles_RoleId",
                schema: "public",
                table: "users",
                column: "RoleId",
                principalSchema: "public",
                principalTable: "roles",
                principalColumn: "RoleId");
        }
    }
}
