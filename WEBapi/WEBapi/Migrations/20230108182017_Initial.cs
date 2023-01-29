using Microsoft.EntityFrameworkCore.Migrations;
using WEBapi.Models;

#nullable disable

namespace WEBapi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Userms",
                columns: table => new
                {
                    UsermId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsermName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsermRole = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userms", x => x.UsermId);
                });
            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    DeviceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsermId = table.Column<string>(type: "int", nullable: false),
                    DeviceDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceMaxHEnergyConsumption = table.Column<string>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.DeviceId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Userms"); 
            migrationBuilder.DropTable(
                name: "Devices");
        }
    }
}
