using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorbikeServices.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddHangXeDongXe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HangXes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHang = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuocGia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangXes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DongXes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HangXeId = table.Column<int>(type: "int", nullable: false),
                    TenDongXe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DongXes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DongXes_HangXes_HangXeId",
                        column: x => x.HangXeId,
                        principalTable: "HangXes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DongXes_HangXeId",
                table: "DongXes",
                column: "HangXeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DongXes");

            migrationBuilder.DropTable(
                name: "HangXes");
        }
    }
}
