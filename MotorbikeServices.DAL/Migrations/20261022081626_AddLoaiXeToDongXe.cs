using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorbikeServices.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddLoaiXeToDongXe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LoaiXe",
                table: "DongXes",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "Xe số");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoaiXe",
                table: "DongXes");
        }
    }
}
