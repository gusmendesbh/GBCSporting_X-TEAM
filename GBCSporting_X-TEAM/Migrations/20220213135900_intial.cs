using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBCSporting_X_TEAM.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2022, 2, 13, 8, 58, 59, 477, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2022, 2, 13, 8, 58, 59, 477, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 3,
                column: "DateOpened",
                value: new DateTime(2022, 2, 13, 8, 58, 59, 477, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 4,
                column: "DateOpened",
                value: new DateTime(2022, 2, 13, 8, 58, 59, 477, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 5,
                column: "DateOpened",
                value: new DateTime(2022, 2, 13, 8, 58, 59, 477, DateTimeKind.Local).AddTicks(3703));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2022, 2, 12, 19, 38, 48, 865, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2022, 2, 12, 19, 38, 48, 865, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 3,
                column: "DateOpened",
                value: new DateTime(2022, 2, 12, 19, 38, 48, 865, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 4,
                column: "DateOpened",
                value: new DateTime(2022, 2, 12, 19, 38, 48, 865, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 5,
                column: "DateOpened",
                value: new DateTime(2022, 2, 12, 19, 38, 48, 865, DateTimeKind.Local).AddTicks(9780));
        }
    }
}
