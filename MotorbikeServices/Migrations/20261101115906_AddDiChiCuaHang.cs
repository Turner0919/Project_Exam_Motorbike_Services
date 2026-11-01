using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorbikeServices.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddDiChiCuaHang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaChis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TinhTP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhuongXa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaChis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVienUses",
                columns: table => new
                {
                    NhanVienId = table.Column<int>(type: "int", nullable: false),
                    TenCuaHang = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DiaChiId = table.Column<int>(type: "int", nullable: true),
                    TenDuong = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    SoCuaHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVienUses", x => x.NhanVienId);
                    table.ForeignKey(
                        name: "FK_NhanVienUses_DiaChis_DiaChiId",
                        column: x => x.DiaChiId,
                        principalTable: "DiaChis",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NhanVienUses_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NhanVienUses_DiaChiId",
                table: "NhanVienUses",
                column: "DiaChiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhanVienUses");

            migrationBuilder.DropTable(
                name: "DiaChis");
        }
    }
}
