using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Baza_PraktykiStudenckie.Migrations
{
    /// <inheritdoc />
    public partial class PraktykiMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Firmy",
                columns: table => new
                {
                    ID_Firmy = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NIP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NrTelefonu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmy", x => x.ID_Firmy);
                });

            migrationBuilder.CreateTable(
                name: "Opiekunowie",
                columns: table => new
                {
                    ID_Opiekuna = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imię = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opiekunowie", x => x.ID_Opiekuna);
                });

            migrationBuilder.CreateTable(
                name: "Adresy",
                columns: table => new
                {
                    ID_Firmy = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Miejscowość = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KodPocztowy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ulica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NrBudynku = table.Column<int>(type: "int", nullable: true),
                    NrLokalu = table.Column<int>(type: "int", nullable: true),
                    FirmaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresy", x => x.ID_Firmy);
                    table.ForeignKey(
                        name: "FK_Adresy_Firmy_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmy",
                        principalColumn: "ID_Firmy",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Praktyki",
                columns: table => new
                {
                    ID_Firmy = table.Column<int>(type: "int", nullable: false),
                    ID_Studenta = table.Column<int>(type: "int", nullable: false),
                    Początek = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Koniec = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ZakresObowiązków = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Praktyki", x => new { x.ID_Firmy, x.ID_Studenta });
                    table.ForeignKey(
                        name: "FK_Praktyki_Firmy_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmy",
                        principalColumn: "ID_Firmy");
                });

            migrationBuilder.CreateTable(
                name: "OpiekunowieUczelnia",
                columns: table => new
                {
                    ID_Opiekuna = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Katedra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wydział = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpiekunId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpiekunowieUczelnia", x => x.ID_Opiekuna);
                    table.ForeignKey(
                        name: "FK_OpiekunowieUczelnia_Opiekunowie_OpiekunId",
                        column: x => x.OpiekunId,
                        principalTable: "Opiekunowie",
                        principalColumn: "ID_Opiekuna",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OpiekunowieZakładPracy",
                columns: table => new
                {
                    ID_Opiekuna = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Firmy = table.Column<int>(type: "int", nullable: false),
                    Stanowsisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NrTelefonu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpiekunId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpiekunowieZakładPracy", x => x.ID_Opiekuna);
                    table.ForeignKey(
                        name: "FK_OpiekunowieZakładPracy_Opiekunowie_OpiekunId",
                        column: x => x.OpiekunId,
                        principalTable: "Opiekunowie",
                        principalColumn: "ID_Opiekuna",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Studenci",
                columns: table => new
                {
                    ID_Studenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imię = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NrAlbumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RokStudiów = table.Column<int>(type: "int", nullable: false),
                    PraktykaIdFirmy = table.Column<int>(type: "int", nullable: false),
                    PraktykaIdStudenta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studenci", x => x.ID_Studenta);
                    table.ForeignKey(
                        name: "FK_Studenci_Praktyki_PraktykaIdFirmy_PraktykaIdStudenta",
                        columns: x => new { x.PraktykaIdFirmy, x.PraktykaIdStudenta },
                        principalTable: "Praktyki",
                        principalColumns: new[] { "ID_Firmy", "ID_Studenta" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OpiekunStudent",
                columns: table => new
                {
                    OpiekunowieId = table.Column<int>(type: "int", nullable: false),
                    StudenciPodOpiekąId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpiekunStudent", x => new { x.OpiekunowieId, x.StudenciPodOpiekąId });
                    table.ForeignKey(
                        name: "FK_OpiekunStudent_Opiekunowie_OpiekunowieId",
                        column: x => x.OpiekunowieId,
                        principalTable: "Opiekunowie",
                        principalColumn: "ID_Opiekuna",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OpiekunStudent_Studenci_StudenciPodOpiekąId",
                        column: x => x.StudenciPodOpiekąId,
                        principalTable: "Studenci",
                        principalColumn: "ID_Studenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adresy_FirmaId",
                table: "Adresy",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_OpiekunowieUczelnia_OpiekunId",
                table: "OpiekunowieUczelnia",
                column: "OpiekunId");

            migrationBuilder.CreateIndex(
                name: "IX_OpiekunowieZakładPracy_OpiekunId",
                table: "OpiekunowieZakładPracy",
                column: "OpiekunId");

            migrationBuilder.CreateIndex(
                name: "IX_OpiekunStudent_StudenciPodOpiekąId",
                table: "OpiekunStudent",
                column: "StudenciPodOpiekąId");

            migrationBuilder.CreateIndex(
                name: "IX_Praktyki_FirmaId",
                table: "Praktyki",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Studenci_PraktykaIdFirmy_PraktykaIdStudenta",
                table: "Studenci",
                columns: new[] { "PraktykaIdFirmy", "PraktykaIdStudenta" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adresy");

            migrationBuilder.DropTable(
                name: "OpiekunowieUczelnia");

            migrationBuilder.DropTable(
                name: "OpiekunowieZakładPracy");

            migrationBuilder.DropTable(
                name: "OpiekunStudent");

            migrationBuilder.DropTable(
                name: "Opiekunowie");

            migrationBuilder.DropTable(
                name: "Studenci");

            migrationBuilder.DropTable(
                name: "Praktyki");

            migrationBuilder.DropTable(
                name: "Firmy");
        }
    }
}
