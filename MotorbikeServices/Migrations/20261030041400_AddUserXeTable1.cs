using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorbikeServices.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddUserXeTable1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserXes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DongXeId = table.Column<int>(type: "int", nullable: false),
                    BienSoXe = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NgayMuaXe = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserXes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserXes_DongXes_DongXeId",
                        column: x => x.DongXeId,
                        principalTable: "DongXes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserXes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserXes_DongXeId",
                table: "UserXes",
                column: "DongXeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserXes_UserId",
                table: "UserXes",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserXes");
        }
    }
}
