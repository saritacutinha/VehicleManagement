using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleManagement.Migrations
{
    public partial class SeedDatabase_VehicleType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO VehicleTypes (Name) VALUES ('Car')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes");
        }
    }
}
