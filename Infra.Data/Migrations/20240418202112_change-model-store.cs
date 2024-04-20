using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class changemodelstore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description_status_NF",
                table: "Store");

            migrationBuilder.RenameColumn(
                name: "Status_NF",
                table: "Store",
                newName: "Product");

            migrationBuilder.RenameColumn(
                name: "SLA",
                table: "Store",
                newName: "Price_Sale");

            migrationBuilder.RenameColumn(
                name: "PDV",
                table: "Store",
                newName: "Price_Purchase");

            migrationBuilder.RenameColumn(
                name: "NumNf",
                table: "Store",
                newName: "Num_Bill");

            migrationBuilder.RenameColumn(
                name: "N_do_Ticket_PluSoft",
                table: "Store",
                newName: "Image_Dir");

            migrationBuilder.RenameColumn(
                name: "N_do_Ticket",
                table: "Store",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Horario_entrada",
                table: "Store",
                newName: "Date_In");

            migrationBuilder.RenameColumn(
                name: "Fecha_inicio",
                table: "Store",
                newName: "Date_End");

            migrationBuilder.RenameColumn(
                name: "Fecha_Fin",
                table: "Store",
                newName: "Cant");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Product",
                table: "Store",
                newName: "Status_NF");

            migrationBuilder.RenameColumn(
                name: "Price_Sale",
                table: "Store",
                newName: "SLA");

            migrationBuilder.RenameColumn(
                name: "Price_Purchase",
                table: "Store",
                newName: "PDV");

            migrationBuilder.RenameColumn(
                name: "Num_Bill",
                table: "Store",
                newName: "NumNf");

            migrationBuilder.RenameColumn(
                name: "Image_Dir",
                table: "Store",
                newName: "N_do_Ticket_PluSoft");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Store",
                newName: "N_do_Ticket");

            migrationBuilder.RenameColumn(
                name: "Date_In",
                table: "Store",
                newName: "Horario_entrada");

            migrationBuilder.RenameColumn(
                name: "Date_End",
                table: "Store",
                newName: "Fecha_inicio");

            migrationBuilder.RenameColumn(
                name: "Cant",
                table: "Store",
                newName: "Fecha_Fin");

            migrationBuilder.AddColumn<string>(
                name: "Description_status_NF",
                table: "Store",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
