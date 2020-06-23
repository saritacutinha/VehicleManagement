using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleManagement.Migrations
{
    public partial class SeedDatabase_VehicleTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("INSERT INTO VehicleTypes (Name) VALUES ('Car')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM VehicleTypes");
        }
    }
}
