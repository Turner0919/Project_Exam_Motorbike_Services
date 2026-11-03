using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorbikeServices.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddSanPhamCuaHang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhanVienId = table.Column<int>(type: "int", nullable: false),
                    MaSP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SanPhams_NhanVienUses_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanVienUses",
                        principalColumn: "NhanVienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_NhanVienId",
                table: "SanPhams",
                column: "NhanVienId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SanPhams");
        }
    }
}
