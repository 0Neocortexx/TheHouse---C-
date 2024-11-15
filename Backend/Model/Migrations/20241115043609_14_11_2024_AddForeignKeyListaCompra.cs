using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class _14_11_2024_AddForeignKeyListaCompra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Compra");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "ListaCompra",
                newName: "Nome");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCriacao",
                table: "ListaCompra",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "ListaCompra",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ListaCompra_UsuarioId",
                table: "ListaCompra",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_ListaCompra_Usuario_UsuarioId",
                table: "ListaCompra",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListaCompra_Usuario_UsuarioId",
                table: "ListaCompra");

            migrationBuilder.DropIndex(
                name: "IX_ListaCompra_UsuarioId",
                table: "ListaCompra");

            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "ListaCompra");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "ListaCompra");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "ListaCompra",
                newName: "Descricao");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Compra",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
