using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class migration_08092024_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValorFinal",
                table: "Metas",
                newName: "ValorTotalMeta");

            migrationBuilder.RenameColumn(
                name: "ValorAtual",
                table: "Metas",
                newName: "ValorAdquirido");

            migrationBuilder.RenameColumn(
                name: "DataMeta",
                table: "Metas",
                newName: "DataObjetivo");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Metas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Metas_UsuarioId",
                table: "Metas",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Metas_Usuario_UsuarioId",
                table: "Metas",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Metas_Usuario_UsuarioId",
                table: "Metas");

            migrationBuilder.DropIndex(
                name: "IX_Metas_UsuarioId",
                table: "Metas");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Metas");

            migrationBuilder.RenameColumn(
                name: "ValorTotalMeta",
                table: "Metas",
                newName: "ValorFinal");

            migrationBuilder.RenameColumn(
                name: "ValorAdquirido",
                table: "Metas",
                newName: "ValorAtual");

            migrationBuilder.RenameColumn(
                name: "DataObjetivo",
                table: "Metas",
                newName: "DataMeta");
        }
    }
}
