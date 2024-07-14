using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class migration1407242 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_meta",
                table: "meta");

            migrationBuilder.RenameTable(
                name: "meta",
                newName: "Metas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Metas",
                table: "Metas",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Metas",
                table: "Metas");

            migrationBuilder.RenameTable(
                name: "Metas",
                newName: "meta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_meta",
                table: "meta",
                column: "Id");
        }
    }
}
