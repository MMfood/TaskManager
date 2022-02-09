using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskManager.Infrastructure.Migrations
{
    public partial class roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "756e3532-db24-40cc-a42b-69eaf71b9f13");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "71da77c5-6913-43cf-9b2a-4041653b7ea6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d90e75c6-7da9-490e-aeb0-3d8c4827e193",
                column: "ConcurrencyStamp",
                value: "89ca1c17-0deb-48fb-875b-6bfaaf3c29d7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a55904b-910e-46c3-8df7-a138a2b73a8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f545aa36-3637-4009-ba34-a1b73f2ed9c9", "AQAAAAEAACcQAAAAECiX11Mic4933IuCnUgoLlE4o+yR0cd6fj0lMOMty64CWMxDkXdH9DtdTYZOMZmcXA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69e7930c-3df5-4261-99cf-0352eb018a91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6bf665dc-4dc0-4f20-8ea2-fcf61cecd592", "AQAAAAEAACcQAAAAEC04cu/D/Eh/SLAFDrBwcxfNJCjuZdw7EbwUDUehPnjKFQKUh6ikuQp/EpFFdbV4Qw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e7930c-3df5-4261-99cf-0352eb018a91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "76ad127d-3ee0-423d-9f63-064cc8224a69", "AQAAAAEAACcQAAAAEPX3AfbbG18xJHxcIJziNh5EnXb03qgbeJKLeFF2xG5xqM2hcnPjKbr0tgzGoBNdkg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9009a034-7f66-455f-b76f-4f873dc93741",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0bd29712-568a-4581-91fb-df7958524c54", "AQAAAAEAACcQAAAAELlIcUnNs88NJ0y/54P4ucgV3FEpD9zgytrBNddneWbWvy+NeAnd9FYT5PW3zp4Kww==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "067e6aee-739e-4dec-b93a-990b39c8bf96");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "4a7cc1f3-fe95-4d6a-acdd-2c4d42309e9b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d90e75c6-7da9-490e-aeb0-3d8c4827e193",
                column: "ConcurrencyStamp",
                value: "9fc18ae1-0e7f-4866-8670-b86ccf7360f4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a55904b-910e-46c3-8df7-a138a2b73a8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7cc83b55-dfc2-4c9e-a487-866433be6b03", "AQAAAAEAACcQAAAAEChi0g9vKrYoLZcfoAMeCN0A9MSzPlDXmF5I/ygnCG0UIWV7jnexExiYUYHbV2UzfA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69e7930c-3df5-4261-99cf-0352eb018a91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c49f026-5f92-4d86-ad5c-778e0c5b8527", "AQAAAAEAACcQAAAAEOeIipR9rwgxVkuXutnosQ8+ryknzaGcrWPOTSUW5uLApAFoSgr8bFYgy9i5fi91WA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e7930c-3df5-4261-99cf-0352eb018a91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2f811bf2-7331-481d-b16e-529b0c395bae", "AQAAAAEAACcQAAAAEPw2gWW2JQeaqhO3VksvYXylJuJgCDxmSZxbOyAHELVWCh9t20gCK3mbG3OdyUVHLQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9009a034-7f66-455f-b76f-4f873dc93741",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cddf89b2-7ca6-4428-bc8b-221c01f95bdf", "AQAAAAEAACcQAAAAEBZ+Qf9Cb+4zjJQ/VFPNUo/wMyL9Axy4du+3v4YOj7LYBqbTmnxxSzFxN1/7+tcyoQ==" });
        }
    }
}
