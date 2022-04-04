using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal.Data.Migrations
{
    public partial class CreateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sintomas",
                keyColumn: "SintomasId",
                keyValue: 1,
                columns: new[] { "ActualizadoEn", "CreadoEn" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 55, 33, 538, DateTimeKind.Local).AddTicks(3790), new DateTime(2022, 4, 3, 21, 55, 33, 538, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Sintomas",
                keyColumn: "SintomasId",
                keyValue: 2,
                columns: new[] { "ActualizadoEn", "CreadoEn" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 55, 33, 538, DateTimeKind.Local).AddTicks(3830), new DateTime(2022, 4, 3, 21, 55, 33, 538, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "Sintomas",
                keyColumn: "SintomasId",
                keyValue: 3,
                columns: new[] { "ActualizadoEn", "CreadoEn" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 55, 33, 538, DateTimeKind.Local).AddTicks(3850), new DateTime(2022, 4, 3, 21, 55, 33, 538, DateTimeKind.Local).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Sintomas",
                keyColumn: "SintomasId",
                keyValue: 4,
                columns: new[] { "ActualizadoEn", "CreadoEn" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 55, 33, 538, DateTimeKind.Local).AddTicks(3870), new DateTime(2022, 4, 3, 21, 55, 33, 538, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Sintomas",
                keyColumn: "SintomasId",
                keyValue: 5,
                columns: new[] { "ActualizadoEn", "CreadoEn" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 55, 33, 538, DateTimeKind.Local).AddTicks(3880), new DateTime(2022, 4, 3, 21, 55, 33, 538, DateTimeKind.Local).AddTicks(3880) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sintomas",
                keyColumn: "SintomasId",
                keyValue: 1,
                columns: new[] { "ActualizadoEn", "CreadoEn" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 16, 90, DateTimeKind.Local).AddTicks(6780), new DateTime(2022, 4, 3, 21, 51, 16, 90, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "Sintomas",
                keyColumn: "SintomasId",
                keyValue: 2,
                columns: new[] { "ActualizadoEn", "CreadoEn" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 16, 90, DateTimeKind.Local).AddTicks(6820), new DateTime(2022, 4, 3, 21, 51, 16, 90, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "Sintomas",
                keyColumn: "SintomasId",
                keyValue: 3,
                columns: new[] { "ActualizadoEn", "CreadoEn" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 16, 90, DateTimeKind.Local).AddTicks(6840), new DateTime(2022, 4, 3, 21, 51, 16, 90, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "Sintomas",
                keyColumn: "SintomasId",
                keyValue: 4,
                columns: new[] { "ActualizadoEn", "CreadoEn" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 16, 90, DateTimeKind.Local).AddTicks(6860), new DateTime(2022, 4, 3, 21, 51, 16, 90, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Sintomas",
                keyColumn: "SintomasId",
                keyValue: 5,
                columns: new[] { "ActualizadoEn", "CreadoEn" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 16, 90, DateTimeKind.Local).AddTicks(6880), new DateTime(2022, 4, 3, 21, 51, 16, 90, DateTimeKind.Local).AddTicks(6880) });
        }
    }
}
