using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroLivro.Migrations
{
    /// <inheritdoc />
    public partial class AddAnoPublicacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnoPublicacao",
                table: "Livros",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnoPublicacao",
                table: "Livros");
        }
    }
}
