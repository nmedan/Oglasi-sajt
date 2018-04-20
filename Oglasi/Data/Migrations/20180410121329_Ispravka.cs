using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Oglasi.Data.Migrations
{
    public partial class Ispravka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oglasi_AspNetUsers_AutorId1",
                table: "Oglasi");

            migrationBuilder.DropIndex(
                name: "IX_Oglasi_AutorId1",
                table: "Oglasi");

            migrationBuilder.DropColumn(
                name: "AutorId1",
                table: "Oglasi");

            migrationBuilder.AlterColumn<string>(
                name: "AutorId",
                table: "Oglasi",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Oglasi_AutorId",
                table: "Oglasi",
                column: "AutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Oglasi_AspNetUsers_AutorId",
                table: "Oglasi",
                column: "AutorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oglasi_AspNetUsers_AutorId",
                table: "Oglasi");

            migrationBuilder.DropIndex(
                name: "IX_Oglasi_AutorId",
                table: "Oglasi");

            migrationBuilder.AlterColumn<int>(
                name: "AutorId",
                table: "Oglasi",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AutorId1",
                table: "Oglasi",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Oglasi_AutorId1",
                table: "Oglasi",
                column: "AutorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Oglasi_AspNetUsers_AutorId1",
                table: "Oglasi",
                column: "AutorId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
