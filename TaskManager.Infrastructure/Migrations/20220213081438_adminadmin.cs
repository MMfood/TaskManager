using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskManager.Infrastructure.Migrations
{
    public partial class adminadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
