using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelWebBackEndCore.Migrations
{
    /// <inheritdoc />
    public partial class new_aatra_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Voucher");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Voucher");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Voucher",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Voucher",
                type: "datetime2",
                nullable: true);
        }
    }
}
