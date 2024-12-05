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
                name: "EstadoCivil",
                table: "Cliente",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Logradouro",
                table: "Cliente",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Cliente",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Cliente",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Cliente",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UF",
                table: "Cliente",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "BR");

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Cliente",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RG",
                table: "Cliente",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomePai",
                table: "Cliente",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeMae",
                table: "Cliente",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNasc",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "EstadoCivil", table: "Cliente");
            migrationBuilder.DropColumn(name: "Logradouro", table: "Cliente");
            migrationBuilder.DropColumn(name: "Numero", table: "Cliente");
            migrationBuilder.DropColumn(name: "Bairro", table: "Cliente");
            migrationBuilder.DropColumn(name: "Cidade", table: "Cliente");
            migrationBuilder.DropColumn(name: "UF", table: "Cliente");
            migrationBuilder.DropColumn(name: "Pais", table: "Cliente");
            migrationBuilder.DropColumn(name: "CEP", table: "Cliente");
            migrationBuilder.DropColumn(name: "RG", table: "Cliente");
            migrationBuilder.DropColumn(name: "NomePai", table: "Cliente");
            migrationBuilder.DropColumn(name: "NomeMae", table: "Cliente");
            migrationBuilder.DropColumn(name: "DataNasc", table: "Cliente");
        }
    }
}
