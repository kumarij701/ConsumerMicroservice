using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsumerMicroservice.Migrations
{
    public partial class changedBuisToBusi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buisness");

            migrationBuilder.DropTable(
                name: "BuisnessMaster");

            migrationBuilder.RenameColumn(
                name: "BuisnessId",
                table: "Property",
                newName: "BusinessId");

            migrationBuilder.CreateTable(
                name: "BusinessMaster",
                columns: table => new
                {
                    BusinessMasterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessValue = table.Column<int>(type: "int", nullable: false),
                    BusinessTurnOver = table.Column<int>(type: "int", nullable: false),
                    CapitalInvest = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessMaster", x => x.BusinessMasterId);
                });

            migrationBuilder.CreateTable(
                name: "Business",
                columns: table => new
                {
                    BusinessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalEmployees = table.Column<int>(type: "int", nullable: false),
                    BusinessMasterId = table.Column<int>(type: "int", nullable: false),
                    ConsumerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business", x => x.BusinessId);
                    table.ForeignKey(
                        name: "FK_Business_BusinessMaster_BusinessMasterId",
                        column: x => x.BusinessMasterId,
                        principalTable: "BusinessMaster",
                        principalColumn: "BusinessMasterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Business_BusinessMasterId",
                table: "Business",
                column: "BusinessMasterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Business");

            migrationBuilder.DropTable(
                name: "BusinessMaster");

            migrationBuilder.RenameColumn(
                name: "BusinessId",
                table: "Property",
                newName: "BuisnessId");

            migrationBuilder.CreateTable(
                name: "BuisnessMaster",
                columns: table => new
                {
                    BuisnessMasterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuisnessTurnOver = table.Column<int>(type: "int", nullable: false),
                    BuisnessValue = table.Column<int>(type: "int", nullable: false),
                    CapitalInvest = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuisnessMaster", x => x.BuisnessMasterId);
                });

            migrationBuilder.CreateTable(
                name: "Buisness",
                columns: table => new
                {
                    BuisnessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuisnessMasterId = table.Column<int>(type: "int", nullable: false),
                    BuisnessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuisnessType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsumerId = table.Column<int>(type: "int", nullable: false),
                    TotalEmployees = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Buisness_BuisnessMasterId",
                table: "Buisness",
                column: "BuisnessMasterId");
        }
    }
}
