using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadCliente.Migrations
{
    /// <inheritdoc />
    public partial class NovasColunas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomePai",
                table: "Cliente",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomePai",
                table: "Cliente");
        }
    }
}
