using Microsoft.EntityFrameworkCore.Migrations;

namespace Supermarket_system_with_ASP.NET_Core.Migrations
{
    public partial class AltarTableSaida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estoque_Produtos_ProdutoId",
                table: "Estoque");

            migrationBuilder.AddColumn<float>(
                name: "Quantidade",
                table: "Saidas",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "VendaId",
                table: "Saidas",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "Estoque",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Saidas_VendaId",
                table: "Saidas",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estoque_Produtos_ProdutoId",
                table: "Estoque",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Saidas_Vendas_VendaId",
                table: "Saidas",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estoque_Produtos_ProdutoId",
                table: "Estoque");

            migrationBuilder.DropForeignKey(
                name: "FK_Saidas_Vendas_VendaId",
                table: "Saidas");

            migrationBuilder.DropIndex(
                name: "IX_Saidas_VendaId",
                table: "Saidas");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Saidas");

            migrationBuilder.DropColumn(
                name: "VendaId",
                table: "Saidas");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "Estoque",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Estoque_Produtos_ProdutoId",
                table: "Estoque",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
