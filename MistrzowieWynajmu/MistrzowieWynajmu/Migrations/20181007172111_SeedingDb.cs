using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MistrzowieWynajmu.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Owners (Name, Surname, Phone) VALUES ('Tomasz', 'Kempa', '123456789')");
            migrationBuilder.Sql("INSERT INTO Owners (Name, Surname, Phone) VALUES ('Jerzy', 'Kluska', '564789123')");
            migrationBuilder.Sql("INSERT INTO Owners (Name, Surname, Phone) VALUES ('Franek', 'Gowin', '124578452')");

            migrationBuilder.Sql("INSERT INTO Addresses (Street, City) VALUES ('Katowice', 'Kościuszki')");
            migrationBuilder.Sql("INSERT INTO Addresses (Street, City) VALUES ('Gliwice', 'Bojkowska')");
            migrationBuilder.Sql("INSERT INTO Addresses (Street, City) VALUES ('Gdańsk', 'Sopocka')");

            migrationBuilder.Sql("INSERT INTO Properties (Type, Description, Rooms, Area, Washer, Refrigerator, Iron, AddressId, OwnerId) VALUES (0, 'Opis 01', 7, 170, 1, 1, 1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO Properties (Type, Description, Rooms, Area, Washer, Refrigerator, Iron, AddressId, OwnerId) VALUES (0, 'Opis 02', 5, 120, 1, 0, 1, 2, 2)");
            migrationBuilder.Sql("INSERT INTO Properties (Type, Description, Rooms, Area, Washer, Refrigerator, Iron, AddressId, OwnerId) VALUES (1, 'Opis 03', 2, 50, 1, 1, 0, 3, 3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE Owners");
            migrationBuilder.Sql("DELETE Addresses");
            migrationBuilder.Sql("DELETE Properties");
        }
    }
}
