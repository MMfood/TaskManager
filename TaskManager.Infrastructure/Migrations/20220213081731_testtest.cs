using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskManager.Infrastructure.Migrations
{
    public partial class testtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "5ad69cc4-713c-448d-97c4-3aa2c510bceb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "9d77e840-65cd-4a1c-951b-22008e5b92f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d90e75c6-7da9-490e-aeb0-3d8c4827e193",
                column: "ConcurrencyStamp",
                value: "8f39ab83-a78e-4332-81a7-5eddaf91e064");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e7930c-3df5-4261-99cf-0352eb018a91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e567f8d-facf-4be6-b82b-8fd18f260ae2", "AQAAAAEAACcQAAAAEH46Obe1GEaQVmfxXd34wW4GMMVBVXsKe7fzQu7S5iYoijMaToLyIpaiNTR5yhFQTg==" });
        }
    }
}
