using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleManagement.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('BMW')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Mercedes-Benz')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Ford')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Audi')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Holden')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Nissan')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Toyota')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Mazda')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Hyundai')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Land Rover')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('3 Series',(SELECT ID FROM Makes WHERE NAME = 'BMW'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('5 Series',(SELECT ID FROM Makes WHERE NAME = 'BMW'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('7 Series',(SELECT ID FROM Makes WHERE NAME = 'BMW'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('G-Class',(SELECT ID FROM Makes WHERE NAME = 'Mercedes-Benz'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('S-Class',(SELECT ID FROM Makes WHERE NAME = 'Mercedes-Benz'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Mustang',(SELECT ID FROM Makes WHERE NAME = 'Ford'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Fiesta',(SELECT ID FROM Makes WHERE NAME = 'Ford'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('A4',(SELECT ID FROM Makes WHERE NAME = 'Audi'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('A6', (SELECT ID FROM Makes WHERE NAME = 'Audi'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Commodore', (SELECT ID FROM Makes WHERE NAME = 'Holden'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Astra', (SELECT ID FROM Makes WHERE NAME = 'Holden'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Pathfinder', (SELECT ID FROM Makes WHERE NAME = 'Nissan'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('X-Trail', (SELECT ID FROM Makes WHERE NAME = 'Nissan'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Corolla', (SELECT ID FROM Makes WHERE NAME = 'Toyota'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Rav4', (SELECT ID FROM Makes WHERE NAME = 'Toyota'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('6', (SELECT ID FROM Makes WHERE NAME = 'Mazda'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('3', (SELECT ID FROM Makes WHERE NAME = 'Mazda'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('i10', (SELECT ID FROM Makes WHERE NAME = 'Hyundai'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('i30', (SELECT ID FROM Makes WHERE NAME = 'Hyundai'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Range Rover', (SELECT ID FROM Makes WHERE NAME = 'Land Rover'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Defender', (SELECT ID FROM Makes WHERE NAME = 'Land Rover'))");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes");
          

        }
    }
}
