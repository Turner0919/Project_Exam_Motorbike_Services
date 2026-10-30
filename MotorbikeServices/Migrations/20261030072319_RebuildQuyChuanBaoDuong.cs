using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorbikeServices.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RebuildQuyChuanBaoDuong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoaiXe",
                table: "QuyChuanBaoDuongs");

            migrationBuilder.AddColumn<int>(
                name: "DongXeId",
                table: "QuyChuanBaoDuongs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_QuyChuanBaoDuongs_DongXeId",
                table: "QuyChuanBaoDuongs",
                column: "DongXeId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuyChuanBaoDuongs_DongXes_DongXeId",
                table: "QuyChuanBaoDuongs",
                column: "DongXeId",
                principalTable: "DongXes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuyChuanBaoDuongs_DongXes_DongXeId",
                table: "QuyChuanBaoDuongs");

            migrationBuilder.DropIndex(
                name: "IX_QuyChuanBaoDuongs_DongXeId",
                table: "QuyChuanBaoDuongs");

            migrationBuilder.DropColumn(
                name: "DongXeId",
                table: "QuyChuanBaoDuongs");

            migrationBuilder.AddColumn<string>(
                name: "LoaiXe",
                table: "QuyChuanBaoDuongs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
