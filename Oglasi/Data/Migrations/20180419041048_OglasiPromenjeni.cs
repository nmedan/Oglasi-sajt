using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Oglasi.Data.Migrations
{
    public partial class OglasiPromenjeni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aktivan",
                table: "Oglasi");

            migrationBuilder.DropColumn(
                name: "TrajanjeOglasa",
                table: "Oglasi");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumIsteka",
                table: "Oglasi",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumObjave",
                table: "Oglasi",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatumIsteka",
                table: "Oglasi");

            migrationBuilder.DropColumn(
                name: "DatumObjave",
                table: "Oglasi");

            migrationBuilder.AddColumn<bool>(
                name: "Aktivan",
                table: "Oglasi",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TrajanjeOglasa",
                table: "Oglasi",
                nullable: false,
                defaultValue: 0);
        }
    }
}
