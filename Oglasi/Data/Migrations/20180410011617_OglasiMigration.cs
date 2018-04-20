using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Oglasi.Data.Migrations
{
    public partial class OglasiMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImeGrada = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategorije",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivKategorije = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorije", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KategorijeProdavnice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivKategorije = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategorijeProdavnice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Poruke",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naslov = table.Column<string>(nullable: true),
                    PosiljalacId = table.Column<string>(nullable: true),
                    PrimalacId = table.Column<string>(nullable: true),
                    TekstPoruke = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poruke", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Poruke_AspNetUsers_PosiljalacId",
                        column: x => x.PosiljalacId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Poruke_AspNetUsers_PrimalacId",
                        column: x => x.PrimalacId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Oglasi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Aktivan = table.Column<bool>(nullable: false),
                    AutorId = table.Column<int>(nullable: false),
                    AutorId1 = table.Column<string>(nullable: true),
                    BrojPregleda = table.Column<int>(nullable: false),
                    Cena = table.Column<int>(nullable: false),
                    GradId = table.Column<int>(nullable: false),
                    Objavljen = table.Column<bool>(nullable: false),
                    Obnoviti = table.Column<int>(nullable: false),
                    OsobaZaKontakt = table.Column<string>(nullable: true),
                    TekstOglasa = table.Column<string>(nullable: false),
                    Telefon = table.Column<string>(nullable: true),
                    TrajanjeOglasa = table.Column<int>(nullable: false),
                    VrstaOglasa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oglasi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oglasi_AspNetUsers_AutorId1",
                        column: x => x.AutorId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Oglasi_Gradovi_GradId",
                        column: x => x.GradId,
                        principalTable: "Gradovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Potkategorije",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KategorijeId = table.Column<int>(nullable: false),
                    NazivPotkategorije = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Potkategorije", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Potkategorije_Kategorije_KategorijeId",
                        column: x => x.KategorijeId,
                        principalTable: "Kategorije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prodavnice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KategorijeProdavniceId = table.Column<int>(nullable: false),
                    NazivProdavnice = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prodavnice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prodavnice_KategorijeProdavnice_KategorijeProdavniceId",
                        column: x => x.KategorijeProdavniceId,
                        principalTable: "KategorijeProdavnice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OglasiPotkategorije",
                columns: table => new
                {
                    OglasiId = table.Column<int>(nullable: false),
                    PotkategorijeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OglasiPotkategorije", x => new { x.OglasiId, x.PotkategorijeId });
                    table.ForeignKey(
                        name: "FK_OglasiPotkategorije_Oglasi_OglasiId",
                        column: x => x.OglasiId,
                        principalTable: "Oglasi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OglasiPotkategorije_Potkategorije_PotkategorijeId",
                        column: x => x.PotkategorijeId,
                        principalTable: "Potkategorije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proizvodi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cena = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    ProdavniceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvodi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proizvodi_Prodavnice_ProdavniceId",
                        column: x => x.ProdavniceId,
                        principalTable: "Prodavnice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fotografije",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OglasId = table.Column<int>(nullable: true),
                    PodaciOSlici = table.Column<byte[]>(nullable: true),
                    ProizvodId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotografije", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fotografije_Oglasi_OglasId",
                        column: x => x.OglasId,
                        principalTable: "Oglasi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fotografije_Proizvodi_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvodi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fotografije_OglasId",
                table: "Fotografije",
                column: "OglasId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotografije_ProizvodId",
                table: "Fotografije",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Oglasi_AutorId1",
                table: "Oglasi",
                column: "AutorId1");

            migrationBuilder.CreateIndex(
                name: "IX_Oglasi_GradId",
                table: "Oglasi",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_OglasiPotkategorije_PotkategorijeId",
                table: "OglasiPotkategorije",
                column: "PotkategorijeId");

            migrationBuilder.CreateIndex(
                name: "IX_Poruke_PosiljalacId",
                table: "Poruke",
                column: "PosiljalacId");

            migrationBuilder.CreateIndex(
                name: "IX_Poruke_PrimalacId",
                table: "Poruke",
                column: "PrimalacId");

            migrationBuilder.CreateIndex(
                name: "IX_Potkategorije_KategorijeId",
                table: "Potkategorije",
                column: "KategorijeId");

            migrationBuilder.CreateIndex(
                name: "IX_Prodavnice_KategorijeProdavniceId",
                table: "Prodavnice",
                column: "KategorijeProdavniceId");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvodi_ProdavniceId",
                table: "Proizvodi",
                column: "ProdavniceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fotografije");

            migrationBuilder.DropTable(
                name: "OglasiPotkategorije");

            migrationBuilder.DropTable(
                name: "Poruke");

            migrationBuilder.DropTable(
                name: "Proizvodi");

            migrationBuilder.DropTable(
                name: "Oglasi");

            migrationBuilder.DropTable(
                name: "Potkategorije");

            migrationBuilder.DropTable(
                name: "Prodavnice");

            migrationBuilder.DropTable(
                name: "Gradovi");

            migrationBuilder.DropTable(
                name: "Kategorije");

            migrationBuilder.DropTable(
                name: "KategorijeProdavnice");
        }
    }
}
