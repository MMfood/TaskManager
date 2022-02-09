using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskManager.Infrastructure.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "18c11c13-cf68-4760-b857-1794ce42959d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "83c26138-31d5-454f-97ca-76f2b5cd036c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d90e75c6-7da9-490e-aeb0-3d8c4827e193",
                column: "ConcurrencyStamp",
                value: "5406f418-7630-4d18-9bea-94e206bc812d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a55904b-910e-46c3-8df7-a138a2b73a8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "68778872-d96d-4f7e-9d25-d7539171e93e", "AQAAAAEAACcQAAAAEO+Gkh2PB15W9GZ6fuwsAPtq+cDJTmKTcjr3IdE8BFHMGezwd0n+WqZV0yKGL4u1OQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69e7930c-3df5-4261-99cf-0352eb018a91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "98440348-9e7f-42d8-9020-b9029ae48412", "AQAAAAEAACcQAAAAEGSVJz30w2fcsbeHuBVETjtrWKBmdp2yl6xtMh29SmdVjDXMl3MhbKXHeVckxUhA9A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e7930c-3df5-4261-99cf-0352eb018a91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bfb06b58-7d3c-415d-82f5-dcd5722948e3", "AQAAAAEAACcQAAAAEOVotprhfqKlL7UUZFWfA4m6GYGB4EULsNO9fbqooj1C4DWUiCBnsE9yQAuJIwNZuw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9009a034-7f66-455f-b76f-4f873dc93741",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ebda3e11-1753-4a9e-989f-80ad016f3d35", "AQAAAAEAACcQAAAAEEWoySA20OrZGn4xlB4TWtsgQhF1ZUml/NaR9Ew+7QAQe5nvot5im7dAXiQJhjimXA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "605efb8e-0fcf-425d-b631-b236d5e8b970");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "e9cb6c54-1dcb-42c2-8f84-57b8a115e38a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d90e75c6-7da9-490e-aeb0-3d8c4827e193",
                column: "ConcurrencyStamp",
                value: "38e4c5dd-5646-4668-ae57-7de0a4fef9db");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a55904b-910e-46c3-8df7-a138a2b73a8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d9fd763-2c6d-4f7b-ad7f-690d5c14f1d7", "AQAAAAEAACcQAAAAEI+maj/C2V8t1c3ugixZ93WxbVEMUmGUisAXPysL5GnRyr5jOku04INyJEgyE5unsw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69e7930c-3df5-4261-99cf-0352eb018a91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "146ac8f2-bcaa-49d7-9f9d-2acec9d2aba6", "AQAAAAEAACcQAAAAELZ9bB361NNL+ulyC9UqFkmsD1ZubuDlLgeZVEHItgrWqbB8nXnlrEymVEFLIMoKRA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e7930c-3df5-4261-99cf-0352eb018a91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b3dba74-8c33-4248-ae23-1a88d1b3eb32", "AQAAAAEAACcQAAAAEIaxB++5wUu5E6r87NASa2hzc+Qsym6Y1BHmmG8T/ooKWL9H1lbrz+6OYLofWsc/ow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9009a034-7f66-455f-b76f-4f873dc93741",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d23546b5-e450-4b4d-a082-11287d477313", "AQAAAAEAACcQAAAAEBJqbP3j5OBOIZ+NMTviD7jIt0ZAKBj34DJgUz9wxn1EUuYqdKL4dpKqprs62ilngw==" });
        }
    }
}
