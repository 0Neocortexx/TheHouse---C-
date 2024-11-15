using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class _14_11_2024_vinculoFracoCompras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_ListaCompra_ListaCompraId",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Mercado_MercadoId",
                table: "Compra");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_ListaCompra_ListaCompraId",
                table: "Compra",
                column: "ListaCompraId",
                principalTable: "ListaCompra",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Mercado_MercadoId",
                table: "Compra",
                column: "MercadoId",
                principalTable: "Mercado",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_ListaCompra_ListaCompraId",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Mercado_MercadoId",
                table: "Compra");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_ListaCompra_ListaCompraId",
                table: "Compra",
                column: "ListaCompraId",
                principalTable: "ListaCompra",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Mercado_MercadoId",
                table: "Compra",
                column: "MercadoId",
                principalTable: "Mercado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
