using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskManager.Infrastructure.Migrations
{
    public partial class admin : Migration
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
                value: "2c9992b1-bbe7-4029-9e1c-505183038c15");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d90e75c6-7da9-490e-aeb0-3d8c4827e193",
                column: "ConcurrencyStamp",
                value: "76f89925-e00e-4b60-877d-72a71ffac99e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "a6e38752-84ae-4352-a0b6-bf47b3fd460a", "842d1ae6-fce4-4a28-be05-adbdbfbb7578", "UserRole", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a55904b-910e-46c3-8df7-a138a2b73a8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "03909893-30b4-4e2a-a0fa-acf8a9e8f64c", "AQAAAAEAACcQAAAAEGwlJJHSfC3vAu3oRhZMKraGWI1Xr7rU5Ne5kYUNJFmHp6xucZYmUqZTEedy07a5EQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69e7930c-3df5-4261-99cf-0352eb018a91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "faf07a8e-a9dc-4658-b30b-f1f46dc8b793", "AQAAAAEAACcQAAAAEE3vHfyy0pe6Jmaqo6pGVkBkBToTCKgRtBMx8T1onFr3i5KllgKTIu7u7TqBTo5C8w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9009a034-7f66-455f-b76f-4f873dc93741",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fda3374d-336f-49ac-bfdb-c3acde15be6b", "AQAAAAEAACcQAAAAEHNDweT16eu+N76vRv7nxpzF1nv1CdwzI6PyiLmmiSRtXfMXaBTpCz/H6TyLIOaxIQ==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "79e7930c-3df5-4261-99cf-0352eb018a91", 0, "b5c9a71f-3523-4659-9415-22cc9b48b928", "admin@admin.com", false, true, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENbbu/gnCStr51KrXLgl6j3yWgyQNRejA9MhxYwlo7LXOI0/zN9J/Rc0GwiszV6zcg==", null, false, "6I5VNHIJTSZNOT3KDWKNFUV5PVYBHGXN", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a6e38752-84ae-4352-a0b6-bf47b3fd460a", "79e7930c-3df5-4261-99cf-0352eb018a91" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a6e38752-84ae-4352-a0b6-bf47b3fd460a", "79e7930c-3df5-4261-99cf-0352eb018a91" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6e38752-84ae-4352-a0b6-bf47b3fd460a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e7930c-3df5-4261-99cf-0352eb018a91");

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
                value: "ebab6cb7-d6b7-4b52-8953-4a43f2aeb869");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d90e75c6-7da9-490e-aeb0-3d8c4827e193",
                column: "ConcurrencyStamp",
                value: "446ee5c1-4ea2-48cc-9b02-107f79cb7edf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a55904b-910e-46c3-8df7-a138a2b73a8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "01a60a8c-d6de-432f-a5b1-420c242117f2", "AQAAAAEAACcQAAAAEABs8/6+kYi0KjuwZbOO+YIqjQbSw09yYIAbtwZ0xNoPEuTpY4+EPuQsYLBAw3FF2w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69e7930c-3df5-4261-99cf-0352eb018a91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8f9b1d0-16ad-44ba-af04-3815f8144c45", "AQAAAAEAACcQAAAAEG6D2zXVGqWxnl2/LgGdw0njhFOnvQpv9cZwDGNh5Qc/T6DNJ4anTkqBuotCx4uoqw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9009a034-7f66-455f-b76f-4f873dc93741",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8dfaa0d-06c4-4549-8232-f807570e0c21", "AQAAAAEAACcQAAAAEIJLGrw5BH9IDsO/pQBli/uau8OsoW4yyGvBKJMh8gu2LdhbISMKbzjJXjHAHJL7sw==" });
        }
    }
}
