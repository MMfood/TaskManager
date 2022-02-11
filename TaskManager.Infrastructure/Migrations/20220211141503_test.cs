using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskManager.Infrastructure.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "bf53a194-456c-4f4e-94a7-5fd696cf93fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "2a36808a-b8ec-4135-9d28-b091127c565f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d90e75c6-7da9-490e-aeb0-3d8c4827e193",
                column: "ConcurrencyStamp",
                value: "dc04909a-5bed-405b-a85e-7308e874fc96");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e7930c-3df5-4261-99cf-0352eb018a91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b502827c-7146-4d83-bfdb-301b2380a622", "AQAAAAEAACcQAAAAEM7y6CSGSNsZbfeuW8cwNHBC9IXRcy78skuzJvJ55YSf7ZPbGgd/jjmwZ1lGU5WugQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "4067a66c-c310-4a7d-a305-a30d1f024b47");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "dd60a2aa-0592-4d48-b45e-397c4dacb55f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d90e75c6-7da9-490e-aeb0-3d8c4827e193",
                column: "ConcurrencyStamp",
                value: "645b451f-798a-4a98-b62b-667e65c9c2c4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e7930c-3df5-4261-99cf-0352eb018a91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e49a9c1-dbe3-4045-9d4e-e177e81d5db9", "AQAAAAEAACcQAAAAEM2E9r9zbdR/BegHpIzu+J+zA6cQRY84sLZM9Y5KqOGgcBWZsv4WqZcdLRRQ7ZZirw==" });
        }
    }
}
