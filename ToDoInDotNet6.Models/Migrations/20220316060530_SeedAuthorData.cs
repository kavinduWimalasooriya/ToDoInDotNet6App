using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoInDotNet6.Models.Migrations
{
    public partial class SeedAuthorData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Address", "City", "Name", "Streat" },
                values: new object[,]
                {
                    { 100, "no 250", "polgasowita", "kavindu", "1 st streat" },
                    { 101, "no 253", "siyabalagoda", "mihiranga", "2 nd streat" },
                    { 102, "no 545", "piliyandala", "wimalasooriya", " 1 st lane" },
                    { 103, "no 463", "polgasowita", "yasara", "2 nd lane" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 103);
        }
    }
}
