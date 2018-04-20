using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Oglasi.Data.Migrations
{
    public partial class PromeniAtribut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oglasi_Gradovi_GradId",
                table: "Oglasi");

            migrationBuilder.RenameColumn(
                name: "GradId",
                table: "Oglasi",
                newName: "GradoviId");

            migrationBuilder.RenameIndex(
                name: "IX_Oglasi_GradId",
                table: "Oglasi",
                newName: "IX_Oglasi_GradoviId");

            migrationBuilder.AddForeignKey(
                name: "FK_Oglasi_Gradovi_GradoviId",
                table: "Oglasi",
                column: "GradoviId",
                principalTable: "Gradovi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oglasi_Gradovi_GradoviId",
                table: "Oglasi");

            migrationBuilder.RenameColumn(
                name: "GradoviId",
                table: "Oglasi",
                newName: "GradId");

            migrationBuilder.RenameIndex(
                name: "IX_Oglasi_GradoviId",
                table: "Oglasi",
                newName: "IX_Oglasi_GradId");

            migrationBuilder.AddForeignKey(
                name: "FK_Oglasi_Gradovi_GradId",
                table: "Oglasi",
                column: "GradId",
                principalTable: "Gradovi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
