using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_System.Migrations
{
    /// <inheritdoc />
    public partial class RoleTypeDeveloperAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TYPE \"RoleType\" ADD VALUE IF NOT EXISTS 'Developer';");

            // Seed the new role into the roles table
            migrationBuilder.Sql(@"
        DO $$
        BEGIN
            IF NOT EXISTS (
                SELECT 1 FROM public.""roles""
                WHERE ""RoleId"" = 4 OR ""RoleName"" = 'Developer'
            ) THEN
                INSERT INTO public.""roles"" (""RoleId"", ""RoleName"")
                VALUES (4, 'Developer');
            END IF;
        END
        $$;
    ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
