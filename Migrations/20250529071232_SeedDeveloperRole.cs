using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_System.Migrations
{
    /// <inheritdoc />
    public partial class SeedDeveloperRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            // Insert Developer role if it doesn't already exist
            migrationBuilder.Sql(@"
        DO $$
        BEGIN
            IF NOT EXISTS (
                SELECT 1 FROM public.""roles""
                WHERE ""RoleId"" = 4 OR ""RoleName"" = 4
            ) THEN
                INSERT INTO public.""roles"" (""RoleId"", ""RoleName"")
                VALUES (4, 4);
            END IF;
        END
        $$;
    ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Optional: Delete Developer role
            migrationBuilder.Sql(@"
        DELETE FROM public.""roles""
        WHERE ""RoleId"" = 4 AND ""RoleName"" = 4;
    ");
        }
    }
}
