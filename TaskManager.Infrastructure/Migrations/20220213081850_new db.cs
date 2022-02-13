using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskManager.Infrastructure.Migrations
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "570c3229-bbab-4581-b7d1-01860d923e78");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "594b0810-2c0f-4c16-b842-d8bf386680de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d90e75c6-7da9-490e-aeb0-3d8c4827e193",
                column: "ConcurrencyStamp",
                value: "e9efe8ed-7ae9-4cf0-bea9-6376b56861aa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e7930c-3df5-4261-99cf-0352eb018a91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "89c892b9-b5aa-4257-af73-0d99af3e977d", "AQAAAAEAACcQAAAAEDIFho39WuhiDFMrOqWRUAfNHYjGG4LxwqzwG2BTiMuupQCd/PvG1zi/0ZMdH5N8qg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "04a20c4e-6c83-4fc3-b716-2f1867cdbffd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "201eed7d-d098-490f-a79f-71bfdcc49b6e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d90e75c6-7da9-490e-aeb0-3d8c4827e193",
                column: "ConcurrencyStamp",
                value: "2f2b9cef-d095-48f7-8a61-281806928f57");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e7930c-3df5-4261-99cf-0352eb018a91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eda32ead-bbbe-4ebb-b836-1f7567591763", "AQAAAAEAACcQAAAAEDjbp2TJN6h//GchBbVcOhSsulPvXuYamWcuArXaoMi//BwINjm10kStGleijGnZzA==" });
        }
    }
}
