using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Helga_portfolio.Migrations
{
    public partial class NewPasswordForAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "871f2cb7-6501-41b5-9324-5d94cca1486f",
                column: "ConcurrencyStamp",
                value: "bfb2fdfb-4bfa-481d-929f-71ef9e9d240e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f753b4f-2929-4c33-8161-ca1a20a0c302",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eaf83244-10b7-4b42-8b25-2698caee2ebc", "AQAAAAEAACcQAAAAEJsW/DpfazI8nIcjCHsQ94GNxHrzeJlAYLyjxgfTImei0eOgYYhZtSyh/7FW4/ZqBQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3ac54093-a696-4fdb-8630-5106e491c817"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 13, 21, 36, 28, 946, DateTimeKind.Utc).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("c54568a4-0725-446d-8c54-ef00bb737db2"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 13, 21, 36, 28, 946, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("fc4106a3-232f-4d61-904a-4a698bebd1c8"),
                column: "DateAdded",
                value: new DateTime(2021, 8, 13, 21, 36, 28, 946, DateTimeKind.Utc).AddTicks(4202));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "871f2cb7-6501-41b5-9324-5d94cca1486f",
                column: "ConcurrencyStamp",
                value: "cb50abe3-8556-4298-8594-554f7de31b56");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f753b4f-2929-4c33-8161-ca1a20a0c302",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bec3e3fc-4f4b-4924-bf6e-b33b48e7211d", "AQAAAAEAACcQAAAAEB/I1bZPmWKXRqTbMDiFsqKMkw5QWT4tg/KPqv+Un8PmdZQ6O70FsbDXNQedUb0Izg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3ac54093-a696-4fdb-8630-5106e491c817"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 25, 6, 22, 15, 606, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("c54568a4-0725-446d-8c54-ef00bb737db2"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 25, 6, 22, 15, 606, DateTimeKind.Utc).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("fc4106a3-232f-4d61-904a-4a698bebd1c8"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 25, 6, 22, 15, 606, DateTimeKind.Utc).AddTicks(6472));
        }
    }
}
