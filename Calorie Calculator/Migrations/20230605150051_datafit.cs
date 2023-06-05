using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calorie_Calculator.Migrations
{
    /// <inheritdoc />
    public partial class datafit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Steps_Ds",
                columns: table => new
                {
                    Hist = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Steps = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steps_Ds", x => x.Hist);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Steps_Ds");
        }
    }
}
