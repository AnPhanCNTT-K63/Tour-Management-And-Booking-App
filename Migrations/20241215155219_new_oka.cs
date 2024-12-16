using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelWebBackEndCore.Migrations
{
    /// <inheritdoc />
    public partial class new_oka : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "Payment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TransactionId",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
