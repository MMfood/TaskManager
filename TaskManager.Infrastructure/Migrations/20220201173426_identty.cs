using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskManager.Infrastructure.Migrations
{
    public partial class identty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey("PK_AspNetUserTokens", "AspNetUserTokens");
            migrationBuilder.DropPrimaryKey("PK_AspNetUserLogins", "AspNetUserLogins");

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

            migrationBuilder.AddPrimaryKey("PK_AspNetUserTokens", "AspNetUserTokens", new string[] { "UserId", "LoginProvider", "Name" });
            migrationBuilder.AddPrimaryKey("PK_AspNetUserLogins", "AspNetUserLogins", new string[] { "LoginProvider", "ProviderKey" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "9695bd56-6f3b-485d-9beb-3e37f102b8e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d90e75c6-7da9-490e-aeb0-3d8c4827e193",
                column: "ConcurrencyStamp",
                value: "ef04206a-177e-4fe0-9338-5bbdbbec750a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a55904b-910e-46c3-8df7-a138a2b73a8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d39e5397-39f8-44d8-9375-b9c069727401", "AQAAAAEAACcQAAAAEJ+3nnTg8KzqdS8V+UWWv4OcBPPaK3RP9UDi+/PNlChOh363kFHsrQQ8IX9jZ7hZQQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69e7930c-3df5-4261-99cf-0352eb018a91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "762fa281-9713-472d-b4fc-279f6707db94", "AQAAAAEAACcQAAAAEM+w0yrkhONu95glXWKAJgpJNID0dEmzcccVmWNURe6xNfd8czf5Xllcey21Nwhe0A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9009a034-7f66-455f-b76f-4f873dc93741",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6449e1ee-a5f1-4079-ab1d-fd1e27b922df", "AQAAAAEAACcQAAAAEMiJfisR76isUfEcv2R4sPbTH1gfEjeslWXCznrpDdb+qxw3sSiUCZAzbTBsOpgaCw==" });
        }
    }
}
