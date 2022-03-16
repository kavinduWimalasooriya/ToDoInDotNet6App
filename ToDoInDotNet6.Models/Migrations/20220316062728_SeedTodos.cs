using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoInDotNet6.Models.Migrations
{
    public partial class SeedTodos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "CreatedDate", "Description", "DueDate", "Status", "Title" },
                values: new object[,]
                {
                    { 100, 100, new DateTime(2022, 3, 16, 11, 57, 27, 999, DateTimeKind.Local).AddTicks(5224), "this is the descreption", new DateTime(2022, 3, 23, 11, 57, 27, 999, DateTimeKind.Local).AddTicks(5225), 0, "go to work" },
                    { 101, 100, new DateTime(2022, 3, 16, 11, 57, 27, 999, DateTimeKind.Local).AddTicks(5230), "this is the descreption", new DateTime(2022, 3, 23, 11, 57, 27, 999, DateTimeKind.Local).AddTicks(5231), 1, "second task" },
                    { 102, 103, new DateTime(2022, 3, 16, 11, 57, 27, 999, DateTimeKind.Local).AddTicks(5232), "this is the descreption", new DateTime(2022, 3, 23, 11, 57, 27, 999, DateTimeKind.Local).AddTicks(5233), 0, "new task" },
                    { 103, 102, new DateTime(2022, 3, 16, 11, 57, 27, 999, DateTimeKind.Local).AddTicks(5234), "this is the descreption", new DateTime(2022, 3, 23, 11, 57, 27, 999, DateTimeKind.Local).AddTicks(5235), 0, "another task" },
                    { 104, 101, new DateTime(2022, 3, 16, 11, 57, 27, 999, DateTimeKind.Local).AddTicks(5243), "this is the descreption", new DateTime(2022, 3, 23, 11, 57, 27, 999, DateTimeKind.Local).AddTicks(5244), 0, "another task 101" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 104);
        }
    }
}
