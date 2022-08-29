using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsumerMicroservice.Migrations
{
    public partial class createtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuisnessMaster",
                columns: table => new
                {
                    BuisnessMasterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuisnessValue = table.Column<int>(type: "int", nullable: false),
                    BuisnessTurnOver = table.Column<int>(type: "int", nullable: false),
                    CapitalInvest = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuisnessMaster", x => x.BuisnessMasterId);
                });

            migrationBuilder.CreateTable(
                name: "Consumer",
                columns: table => new
                {
                    ConsumerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsumerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PanNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumer", x => x.ConsumerId);
                });

            migrationBuilder.CreateTable(
                name: "PropertyMaster",
                columns: table => new
                {
                    PropertyMasterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CostOfAssest = table.Column<int>(type: "int", nullable: false),
                    SalvageValue = table.Column<int>(type: "int", nullable: false),
                    UsefulLifeOfAssest = table.Column<int>(type: "int", nullable: false),
                    PropertyValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyMaster", x => x.PropertyMasterId);
                });

            migrationBuilder.CreateTable(
                name: "Buisness",
                columns: table => new
                {
                    BuisnessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuisnessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuisnessType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalEmployees = table.Column<int>(type: "int", nullable: false),
                    BuisnessMasterId = table.Column<int>(type: "int", nullable: false),
                    ConsumerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buisness", x => x.BuisnessId);
                    table.ForeignKey(
                        name: "FK_Buisness_BuisnessMaster_BuisnessMasterId",
                        column: x => x.BuisnessMasterId,
                        principalTable: "BuisnessMaster",
                        principalColumn: "BuisnessMasterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuildingStoreys = table.Column<int>(type: "int", nullable: false),
                    BuildingAge = table.Column<int>(type: "int", nullable: false),
                    BuisnessId = table.Column<int>(type: "int", nullable: false),
                    PropertyMasterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.PropertyId);
                    table.ForeignKey(
                        name: "FK_Property_PropertyMaster_PropertyMasterId",
                        column: x => x.PropertyMasterId,
                        principalTable: "PropertyMaster",
                        principalColumn: "PropertyMasterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buisness_BuisnessMasterId",
                table: "Buisness",
                column: "BuisnessMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_PropertyMasterId",
                table: "Property",
                column: "PropertyMasterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buisness");

            migrationBuilder.DropTable(
                name: "Consumer");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "BuisnessMaster");

            migrationBuilder.DropTable(
                name: "PropertyMaster");
        }
    }
}
