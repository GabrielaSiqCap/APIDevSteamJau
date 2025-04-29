using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIDevSteamJau.Migrations
{
    /// <inheritdoc />
    public partial class CupomCarrinho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LimiteUso",
                table: "Cupom",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CupomCarrinho",
                columns: table => new
                {
                    CupomCarrinhoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarrinhoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CupomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DataAplicacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CupomCarrinho", x => x.CupomCarrinhoId);
                    table.ForeignKey(
                        name: "FK_CupomCarrinho_Carrinhos_CarrinhoId",
                        column: x => x.CarrinhoId,
                        principalTable: "Carrinhos",
                        principalColumn: "CarrinhoId");
                    table.ForeignKey(
                        name: "FK_CupomCarrinho_Cupom_CupomId",
                        column: x => x.CupomId,
                        principalTable: "Cupom",
                        principalColumn: "CupomId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CupomCarrinho_CarrinhoId",
                table: "CupomCarrinho",
                column: "CarrinhoId");

            migrationBuilder.CreateIndex(
                name: "IX_CupomCarrinho_CupomId",
                table: "CupomCarrinho",
                column: "CupomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CupomCarrinho");

            migrationBuilder.DropColumn(
                name: "LimiteUso",
                table: "Cupom");
        }
    }
}
