using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorbikeServices.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddQuyChuanXeNguoiDung : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuyChuanXeNguoiDungs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserXeId = table.Column<int>(type: "int", nullable: false),
                    QuyChuanBaoDuongId = table.Column<int>(type: "int", nullable: false),
                    NgayBaoDuongLanCuoi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyChuanXeNguoiDungs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuyChuanXeNguoiDungs_QuyChuanBaoDuongs_QuyChuanBaoDuongId",
                        column: x => x.QuyChuanBaoDuongId,
                        principalTable: "QuyChuanBaoDuongs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuyChuanXeNguoiDungs_UserXes_UserXeId",
                        column: x => x.UserXeId,
                        principalTable: "UserXes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuyChuanXeNguoiDungs_QuyChuanBaoDuongId",
                table: "QuyChuanXeNguoiDungs",
                column: "QuyChuanBaoDuongId");

            migrationBuilder.CreateIndex(
                name: "IX_QuyChuanXeNguoiDungs_UserXeId",
                table: "QuyChuanXeNguoiDungs",
                column: "UserXeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuyChuanXeNguoiDungs");
        }
    }
}
