using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_System.Migrations
{
    /// <inheritdoc />
    public partial class AddedRoleTypeEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Step 1: Add temporary int column
            migrationBuilder.AddColumn<int>(
                name: "RoleTemp",
                schema: "public",
                table: "roles",
                nullable: false,
                defaultValue: 0); // Default to User

            // Step 2: Migrate string values to enum ints
            migrationBuilder.Sql(@"
        UPDATE public.""roles""
        SET ""RoleTemp"" = CASE
            WHEN ""RoleName"" = 'User' THEN 0
            WHEN ""RoleName"" = 'Patient' THEN 1
            WHEN ""RoleName"" = 'Doctor' THEN 2
            WHEN ""RoleName"" = 'Admin' THEN 3
            ELSE 0
        END");

            // Step 3: Drop old string column
            migrationBuilder.DropColumn(
                name: "RoleName",
                schema: "public",
                table: "roles");

            // Step 4: Rename temporary column to RoleName
            migrationBuilder.RenameColumn(
                name: "RoleTemp",
                schema: "public",
                table: "roles",
                newName: "RoleName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Step 1: Add back RoleName as string
            migrationBuilder.AddColumn<string>(
                name: "RoleTemp",
                schema: "public",
                table: "roles",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "User");

            // Step 2: Convert enum ints back to strings
            //    migrationBuilder.Sql(@"
            //UPDATE public.""roles""
            //SET ""RoleTemp"" = CASE
            //    WHEN ""RoleName"" = 0 THEN 'User'
            //    WHEN ""RoleName"" = 1 THEN 'Patient'
            //    WHEN ""RoleName"" = 2 THEN 'Doctor'
            //    WHEN ""RoleName"" = 3 THEN 'Admin'
            //    ELSE 'User'
            //END");
            migrationBuilder.Sql(@"
    UPDATE public.""roles""
    SET ""RoleTemp"" = CASE
        WHEN LOWER(""RoleName"") = 'user' THEN 0
        WHEN LOWER(""RoleName"") = 'patient' THEN 1
        WHEN LOWER(""RoleName"") = 'doctor' THEN 2
        WHEN LOWER(""RoleName"") = 'admin' THEN 3
        ELSE 0 -- Default to User
    END");



            // Step 3: Drop the int column
            migrationBuilder.DropColumn(
                name: "RoleName",
                schema: "public",
                table: "roles");

            // Step 4: Rename RoleTemp back to RoleName
            migrationBuilder.RenameColumn(
                name: "RoleTemp",
                schema: "public",
                table: "roles",
                newName: "RoleName");
        }

    }
}
