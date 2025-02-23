﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Booker.Migrations
{
    /// <inheritdoc />
    public partial class ModelAndSeedFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookGrades",
                keyColumns: new[] { "BookId", "GradeId" },
                keyValues: new object[] { 36, 3 });

            migrationBuilder.DeleteData(
                table: "BookGrades",
                keyColumns: new[] { "BookId", "GradeId" },
                keyValues: new object[] { 37, 4 });

            migrationBuilder.DeleteData(
                table: "BookGrades",
                keyColumns: new[] { "BookId", "GradeId" },
                keyValues: new object[] { 59, 3 });

            migrationBuilder.DeleteData(
                table: "BookGrades",
                keyColumns: new[] { "BookId", "GradeId" },
                keyValues: new object[] { 60, 4 });

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "87f941fd-4d94-4bd4-9b4e-42270bcb8247");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "46860185-1c3f-46e5-85e4-d7a948b40548");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "117bfcc9-a3e4-472e-9389-8355745d1aa5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "0f8b0533-e839-4fff-a7a4-68ae0ccd84ce");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "b1c20dc7-1a3b-4cf0-b61c-2fb26cf988dc");

            migrationBuilder.InsertData(
                table: "BookGrades",
                columns: new[] { "BookId", "GradeId" },
                values: new object[,]
                {
                    { 36, 1 },
                    { 37, 2 },
                    { 59, 1 },
                    { 60, 2 },
                    { 79, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { true, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { true, 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { true, 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { true, 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 5 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 5 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { true, 5 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { true, 5 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 6 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { true, 7 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { true, 7 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { true, 7 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { true, 7 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 7 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 7 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 7 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 7 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 8 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 8 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 8 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 8 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 9 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 9 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 9 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 9 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 10 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 10 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 11 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 11 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { true, 11 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { true, 11 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 12 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 12 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 12 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 12 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { true, 12 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { true, 12 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { true, 12 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { true, 12 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 13 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 14 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 14 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 15 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 16 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 16 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { true, 17 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { true, 17 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { true, 17 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { false, 17 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Level", "SubjectId" },
                values: new object[] { true, 11 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 20, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(728), 64.714285714285714285714285714m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 40, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(772), 70.142857142857142857142857143m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 15, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(776), 43.857142857142857142857142857m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateTime", "Price" },
                values: new object[] { new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(884), 85.14285714285714285714285714m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 78, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(889), 49.142857142857142857142857143m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 23, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(892), 36.142857142857142857142857143m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 65, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(896), 29.857142857142857142857142857m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 37, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(898), 55m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 35, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(903), 44.714285714285714285714285714m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 17, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(906), 80.42857142857142857142857143m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 10, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(909), 70.571428571428571428571428571m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 17, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(914), 45.285714285714285714285714286m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 28, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(917), 81.42857142857142857142857143m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 51, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(919), 70m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 5, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(922), 82.57142857142857142857142857m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 17, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(925), 22m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 23, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(928), 36.571428571428571428571428571m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 22, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(977), 58.714285714285714285714285714m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 13, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(979), 33m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 35, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(982), 46.571428571428571428571428571m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 55, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(986), 48.714285714285714285714285714m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 45, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(989), 79.85714285714285714285714286m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 66, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(993), 69.428571428571428571428571429m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 40, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(996), 22.571428571428571428571428571m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 46, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1000), 49.571428571428571428571428571m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 77, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1003), 67.571428571428571428571428571m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 4, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1006), 37.857142857142857142857142857m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 73, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1009), 48.857142857142857142857142857m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 24, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1012), 49m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 51, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1016), 44.857142857142857142857142857m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 58, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1019), 82m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 61, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1022), 49.571428571428571428571428571m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 67, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1025), 67.142857142857142857142857143m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 10, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1029), 27.142857142857142857142857143m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 11, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1033), 73.571428571428571428571428571m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 33, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1036), 39.857142857142857142857142857m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 20, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1039), 45.714285714285714285714285714m });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "BookId", "DateTime", "Description", "Photo", "Price", "State", "UserId" },
                values: new object[,]
                {
                    { 38, 37, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1042), "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", 34m, "bardzo dobry", 3 },
                    { 39, 55, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1045), "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", 41.571428571428571428571428571m, "bardzo dobry", 4 },
                    { 40, 44, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1048), "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", 41.142857142857142857142857143m, "bardzo dobry", 5 },
                    { 41, 10, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1052), "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", 63.142857142857142857142857143m, "bardzo dobry", 1 },
                    { 42, 13, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1056), "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", 30.714285714285714285714285714m, "bardzo dobry", 2 },
                    { 43, 23, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1059), "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", 76.285714285714285714285714286m, "bardzo dobry", 3 },
                    { 44, 37, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1063), "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", 47.714285714285714285714285714m, "bardzo dobry", 4 },
                    { 45, 12, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1066), "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", 34.285714285714285714285714286m, "bardzo dobry", 5 },
                    { 46, 69, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1069), "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", 42.428571428571428571428571429m, "bardzo dobry", 1 },
                    { 47, 2, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1072), "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", 54.857142857142857142857142857m, "bardzo dobry", 2 },
                    { 48, 65, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1075), "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", 20m, "bardzo dobry", 3 },
                    { 49, 39, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1078), "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", 39.857142857142857142857142857m, "bardzo dobry", 4 },
                    { 50, 24, new DateTime(2025, 2, 23, 23, 18, 45, 130, DateTimeKind.Local).AddTicks(1081), "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", 35.714285714285714285714285714m, "bardzo dobry", 5 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Język polski" },
                    { 2, "Język angielski" },
                    { 3, "Język niemiecki" },
                    { 4, "Biologia" },
                    { 5, "Chemia" },
                    { 6, "EDB" },
                    { 7, "Fizyka" },
                    { 8, "Geografia" },
                    { 9, "Historia" },
                    { 10, "HiT" },
                    { 11, "Informatyka" },
                    { 12, "Matematyka" },
                    { 13, "Podstawy przedsiębiorczości" },
                    { 14, "Biznes i zarządzanie" },
                    { 15, "Plastyka" },
                    { 16, "WOS" },
                    { 17, "Angielski zawodowy" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_SubjectId",
                table: "Books",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Subjects_SubjectId",
                table: "Books",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Subjects_SubjectId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Books_SubjectId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "BookGrades",
                keyColumns: new[] { "BookId", "GradeId" },
                keyValues: new object[] { 36, 1 });

            migrationBuilder.DeleteData(
                table: "BookGrades",
                keyColumns: new[] { "BookId", "GradeId" },
                keyValues: new object[] { 37, 2 });

            migrationBuilder.DeleteData(
                table: "BookGrades",
                keyColumns: new[] { "BookId", "GradeId" },
                keyValues: new object[] { 59, 1 });

            migrationBuilder.DeleteData(
                table: "BookGrades",
                keyColumns: new[] { "BookId", "GradeId" },
                keyValues: new object[] { 60, 2 });

            migrationBuilder.DeleteData(
                table: "BookGrades",
                keyColumns: new[] { "BookId", "GradeId" },
                keyValues: new object[] { 79, 3 });

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "174cdadd-9313-4490-bfe8-ec5e8ed021a2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "cdf967bd-0141-4684-a610-3c73585598df");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "adcdc119-b8b4-4b72-8a19-e72647499b02");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "121fcf76-a889-4322-82d6-5293236cb093");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "22d2ade9-2628-4abb-a13a-030368b4d716");

            migrationBuilder.InsertData(
                table: "BookGrades",
                columns: new[] { "BookId", "GradeId" },
                values: new object[,]
                {
                    { 36, 3 },
                    { 37, 4 },
                    { 59, 3 },
                    { 60, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Polski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Polski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Polski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Polski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Polski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Polski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Polski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Język angielski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Język angielski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Język angielski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Język angielski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Język angielski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Język angielski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Język angielski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Język angielski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Język angielski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Język angielski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Level", "Subject" },
                values: new object[] { false, "Język angielski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Język angielski" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Język Niemiecki" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Język Niemiecki" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Język Niemiecki" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Język Niemiecki" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Język Niemiecki" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Język Niemiecki" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Język Niemiecki" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Język Niemiecki" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Biologia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Biologia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Biologia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Level", "Subject" },
                values: new object[] { false, "Biologia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Level", "Subject" },
                values: new object[] { false, "Biologia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Level", "Subject" },
                values: new object[] { false, "Biologia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Chemia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Chemia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Level", "Subject" },
                values: new object[] { false, "Chemia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Level", "Subject" },
                values: new object[] { false, "Chemia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "EDB" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Level", "Subject" },
                values: new object[] { false, "Fizyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Level", "Subject" },
                values: new object[] { false, "Fizyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Level", "Subject" },
                values: new object[] { false, "Fizyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Level", "Subject" },
                values: new object[] { false, "Fizyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Fizyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Fizyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Fizyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Fizyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Geografia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Geografia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Geografia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Geografia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Historia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Historia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Historia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Historia" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "HiT" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "HiT" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Informatyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Informatyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Level", "Subject" },
                values: new object[] { false, "Informatyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Level", "Subject" },
                values: new object[] { false, "Informatyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Matematyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Matematyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Matematyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Matematyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Level", "Subject" },
                values: new object[] { false, "Matematyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Level", "Subject" },
                values: new object[] { false, "Matematyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Level", "Subject" },
                values: new object[] { false, "Matematyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Level", "Subject" },
                values: new object[] { false, "Matematyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Podstawy przedsiębiorczości" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Biznes i zarządzanie" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Biznes i zarządzanie" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Plastyka" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "WOS" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "WOS" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Level", "Subject" },
                values: new object[] { false, "Angielski zawodowy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Level", "Subject" },
                values: new object[] { false, "Angielski zawodowy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Level", "Subject" },
                values: new object[] { false, "Angielski zawodowy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Level", "Subject" },
                values: new object[] { true, "Angielski zawodowy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Level", "Subject" },
                values: new object[] { false, "Informatyka" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 3, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(1974), 73.571428571428571428571428571m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 74, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2035), 79.28571428571428571428571429m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 3, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2042), 64.428571428571428571428571429m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateTime", "Price" },
                values: new object[] { new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2048), 31.142857142857142857142857143m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 46, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2054), 36.571428571428571428571428571m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 11, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2060), 68.571428571428571428571428571m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 76, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2065), 76.428571428571428571428571429m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 29, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2071), 82.42857142857142857142857143m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 21, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2077), 25.142857142857142857142857143m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 77, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2083), 71.714285714285714285714285714m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 66, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2088), 56.571428571428571428571428571m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 12, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2095), 23.285714285714285714285714286m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 73, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2101), 30.857142857142857142857142857m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 74, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2107), 42.285714285714285714285714286m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 53, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2112), 83.28571428571428571428571429m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 46, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2118), 47.571428571428571428571428571m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 35, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2124), 79m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 69, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2131), 50.714285714285714285714285714m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 11, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2137), 30.857142857142857142857142857m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 69, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2142), 65m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 73, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2147), 28.142857142857142857142857143m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 61, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2152), 42.857142857142857142857142857m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 31, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2159), 24.714285714285714285714285714m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 1, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2165), 78.428571428571428571428571429m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 8, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2170), 74.571428571428571428571428571m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 50, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2175), 53.428571428571428571428571429m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 24, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2181), 45.285714285714285714285714286m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 9, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2186), 22.142857142857142857142857143m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 48, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2209), 51.142857142857142857142857143m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 42, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2217), 62.714285714285714285714285714m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 74, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2221), 57.857142857142857142857142857m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 20, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2227), 47.571428571428571428571428571m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 27, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2233), 72.714285714285714285714285714m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 4, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2238), 61.571428571428571428571428571m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 69, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2245), 62.857142857142857142857142857m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 34, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2251), 79.142857142857142857142857143m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "DateTime", "Price" },
                values: new object[] { 39, new DateTime(2025, 2, 18, 22, 11, 40, 8, DateTimeKind.Local).AddTicks(2255), 41m });
        }
    }
}
