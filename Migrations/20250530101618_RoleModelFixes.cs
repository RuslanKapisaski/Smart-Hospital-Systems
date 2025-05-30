using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_System.Migrations
{
    /// <inheritdoc />
    public partial class RoleModelFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_role_requests_roles_RoleId",
                schema: "public",
                table: "role_requests");

            migrationBuilder.DropIndex(
                name: "IX_role_requests_RoleId",
                schema: "public",
                table: "role_requests");

            migrationBuilder.DropColumn(
                name: "RoleId",
                schema: "public",
                table: "role_requests");

            migrationBuilder.AddColumn<int>(
                name: "RequestedRoleId",
                schema: "public",
                table: "role_requests",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_role_requests_RequestedRoleId",
                schema: "public",
                table: "role_requests",
                column: "RequestedRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_role_requests_roles_RequestedRoleId",
                schema: "public",
                table: "role_requests",
                column: "RequestedRoleId",
                principalSchema: "public",
                principalTable: "roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_role_requests_roles_RequestedRoleId",
                schema: "public",
                table: "role_requests");

            migrationBuilder.DropIndex(
                name: "IX_role_requests_RequestedRoleId",
                schema: "public",
                table: "role_requests");

            migrationBuilder.DropColumn(
                name: "RequestedRoleId",
                schema: "public",
                table: "role_requests");

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                schema: "public",
                table: "role_requests",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_role_requests_RoleId",
                schema: "public",
                table: "role_requests",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_role_requests_roles_RoleId",
                schema: "public",
                table: "role_requests",
                column: "RoleId",
                principalSchema: "public",
                principalTable: "roles",
                principalColumn: "RoleId");
        }
    }
}
