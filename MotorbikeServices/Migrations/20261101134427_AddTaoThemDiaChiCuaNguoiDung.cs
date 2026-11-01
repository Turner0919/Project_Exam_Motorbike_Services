using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorbikeServices.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddTaoThemDiaChiCuaNguoiDung : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiaChiId",
                table: "UserUses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SoNha",
                table: "UserUses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenDuong",
                table: "UserUses",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserUses_DiaChiId",
                table: "UserUses",
                column: "DiaChiId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserUses_DiaChis_DiaChiId",
                table: "UserUses",
                column: "DiaChiId",
                principalTable: "DiaChis",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserUses_DiaChis_DiaChiId",
                table: "UserUses");

            migrationBuilder.DropIndex(
                name: "IX_UserUses_DiaChiId",
                table: "UserUses");

            migrationBuilder.DropColumn(
                name: "DiaChiId",
                table: "UserUses");

            migrationBuilder.DropColumn(
                name: "SoNha",
                table: "UserUses");

            migrationBuilder.DropColumn(
                name: "TenDuong",
                table: "UserUses");
        }
    }
}
