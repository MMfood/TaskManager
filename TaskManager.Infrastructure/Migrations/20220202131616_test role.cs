using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskManager.Infrastructure.Migrations
{
    public partial class testrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d90e75c6-7da9-490e-aeb0-3d8c4827e193", "4a55904b-910e-46c3-8df7-a138a2b73a8a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a5e38752-84ae-4352-a0b6-bf47b3fd460a", "69e7930c-3df5-4261-99cf-0352eb018a91" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d90e75c6-7da9-490e-aeb0-3d8c4827e193", "9009a034-7f66-455f-b76f-4f873dc93741" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a55904b-910e-46c3-8df7-a138a2b73a8a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69e7930c-3df5-4261-99cf-0352eb018a91");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9009a034-7f66-455f-b76f-4f873dc93741");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "00671e51-b52f-4a28-b908-8854940bb9e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "ee61a457-c512-44ad-a259-380275e3478a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d90e75c6-7da9-490e-aeb0-3d8c4827e193",
                column: "ConcurrencyStamp",
                value: "ae9e865b-528c-41a6-91c9-19410058ce2a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e7930c-3df5-4261-99cf-0352eb018a91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "36008bc7-831e-45e0-8dbf-efa1407c97c7", "AQAAAAEAACcQAAAAEO7ydLGEFlq6t1wtyTXH67Van1ZgN6wEjB4N8utMuK8Tscnul+aU03/NOvV6mQCL7Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: "79e7930c-3df5-4261-99cf-0352eb018a91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "76ad127d-3ee0-423d-9f63-064cc8224a69", "AQAAAAEAACcQAAAAEPX3AfbbG18xJHxcIJziNh5EnXb03qgbeJKLeFF2xG5xqM2hcnPjKbr0tgzGoBNdkg==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "69e7930c-3df5-4261-99cf-0352eb018a91", 0, "6bf665dc-4dc0-4f20-8ea2-fcf61cecd592", "kostya@manager.com", false, true, null, "KOSTYA@MANAGER.COM", "KOSTYA@MANAGER.COM", "AQAAAAEAACcQAAAAEC04cu/D/Eh/SLAFDrBwcxfNJCjuZdw7EbwUDUehPnjKFQKUh6ikuQp/EpFFdbV4Qw==", null, false, "7I5VNHIJTSZNOT3KDWKNFUV5PVYBHGXN", false, "kostya@manager.com" },
                    { "9009a034-7f66-455f-b76f-4f873dc93741", 0, "0bd29712-568a-4581-91fb-df7958524c54", "performer1@employee.com", false, true, null, "PERFORMER1@EMPLOYEE.COM", "PERFORMER1@EMPLOYEE.COM", "AQAAAAEAACcQAAAAELlIcUnNs88NJ0y/54P4ucgV3FEpD9zgytrBNddneWbWvy+NeAnd9FYT5PW3zp4Kww==", null, false, "7I5VNHIJTSZNOT3KDWKNUUV5PVYBHGXN", false, "performer1@employee.com" },
                    { "4a55904b-910e-46c3-8df7-a138a2b73a8a", 0, "f545aa36-3637-4009-ba34-a1b73f2ed9c9", "performer2@employee.com", false, true, null, "PERFORMER2@EMPLOYEE.COM", "PERFORMER2@EMPLOYEE.COM", "AQAAAAEAACcQAAAAECiX11Mic4933IuCnUgoLlE4o+yR0cd6fj0lMOMty64CWMxDkXdH9DtdTYZOMZmcXA==", null, false, "7I5VNHIJTSZNOT3KDWKNULV5PVYBHGXN", false, "performer2@employee.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a5e38752-84ae-4352-a0b6-bf47b3fd460a", "69e7930c-3df5-4261-99cf-0352eb018a91" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d90e75c6-7da9-490e-aeb0-3d8c4827e193", "9009a034-7f66-455f-b76f-4f873dc93741" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d90e75c6-7da9-490e-aeb0-3d8c4827e193", "4a55904b-910e-46c3-8df7-a138a2b73a8a" });
        }
    }
}
