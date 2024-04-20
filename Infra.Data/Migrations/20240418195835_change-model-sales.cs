using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class changemodelsales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description_status_NF",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Fecha_Fin",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Fecha_inicio",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "N_do_Ticket",
                table: "Sales");

            migrationBuilder.RenameColumn(
                name: "Status_NF",
                table: "Sales",
                newName: "Price_Sale");

            migrationBuilder.RenameColumn(
                name: "SLA",
                table: "Sales",
                newName: "Date_Sale");

            migrationBuilder.RenameColumn(
                name: "PDV",
                table: "Sales",
                newName: "Date_Inc");

            migrationBuilder.RenameColumn(
                name: "NumNf",
                table: "Sales",
                newName: "Date_Deliver");

            migrationBuilder.RenameColumn(
                name: "N_do_Ticket_PluSoft",
                table: "Sales",
                newName: "Cant");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductoId",
                table: "Sales",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "Sales");

            migrationBuilder.RenameColumn(
                name: "Price_Sale",
                table: "Sales",
                newName: "Status_NF");

            migrationBuilder.RenameColumn(
                name: "Date_Sale",
                table: "Sales",
                newName: "SLA");

            migrationBuilder.RenameColumn(
                name: "Date_Inc",
                table: "Sales",
                newName: "PDV");

            migrationBuilder.RenameColumn(
                name: "Date_Deliver",
                table: "Sales",
                newName: "NumNf");

            migrationBuilder.RenameColumn(
                name: "Cant",
                table: "Sales",
                newName: "N_do_Ticket_PluSoft");

            migrationBuilder.AddColumn<string>(
                name: "Description_status_NF",
                table: "Sales",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Fecha_Fin",
                table: "Sales",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Fecha_inicio",
                table: "Sales",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "N_do_Ticket",
                table: "Sales",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
