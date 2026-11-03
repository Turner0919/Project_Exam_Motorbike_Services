using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorbikeServices.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddQuyChuanBaoDuong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuyChuanBaoDuongs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiXe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenQuyChuan = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SoKm = table.Column<int>(type: "int", nullable: false),
                    ChiPhi = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyChuanBaoDuongs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuyChuanBaoDuongs");
        }
    }
}
