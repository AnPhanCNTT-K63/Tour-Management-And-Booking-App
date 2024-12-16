using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelWebBackEndCore.Migrations
{
    /// <inheritdoc />
    public partial class new_check : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voucher_TourPackage_TourPackageId",
                table: "Voucher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Voucher",
                table: "Voucher");

            migrationBuilder.RenameTable(
                name: "Voucher",
                newName: "Vouchers");

            migrationBuilder.RenameIndex(
                name: "IX_Voucher_TourPackageId",
                table: "Vouchers",
                newName: "IX_Vouchers_TourPackageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vouchers",
                table: "Vouchers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vouchers_TourPackage_TourPackageId",
                table: "Vouchers",
                column: "TourPackageId",
                principalTable: "TourPackage",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vouchers_TourPackage_TourPackageId",
                table: "Vouchers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vouchers",
                table: "Vouchers");

            migrationBuilder.RenameTable(
                name: "Vouchers",
                newName: "Voucher");

            migrationBuilder.RenameIndex(
                name: "IX_Vouchers_TourPackageId",
                table: "Voucher",
                newName: "IX_Voucher_TourPackageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Voucher",
                table: "Voucher",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Voucher_TourPackage_TourPackageId",
                table: "Voucher",
                column: "TourPackageId",
                principalTable: "TourPackage",
                principalColumn: "Id");
        }
    }
}
