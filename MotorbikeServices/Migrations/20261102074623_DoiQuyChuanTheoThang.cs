using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorbikeServices.DAL.Migrations
{
    /// <inheritdoc />
    public partial class DoiQuyChuanTheoThang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChiPhi",
                table: "QuyChuanBaoDuongs");

            migrationBuilder.DropColumn(
                name: "SoKm",
                table: "QuyChuanBaoDuongs");

            migrationBuilder.AddColumn<int>(
                name: "SoThang",
                table: "QuyChuanBaoDuongs",
                type: "int",
                nullable: false,
                defaultValue: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoThang",
                table: "QuyChuanBaoDuongs");

            migrationBuilder.AddColumn<int>(
                name: "SoKm",
                table: "QuyChuanBaoDuongs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "ChiPhi",
                table: "QuyChuanBaoDuongs",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);
        }
    }
}
