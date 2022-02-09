using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskManager.Infrastructure.Migrations
{
    public partial class testAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "2c9992b1-bbe7-4029-9e1c-505183038c15");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6e38752-84ae-4352-a0b6-bf47b3fd460a",
                column: "ConcurrencyStamp",
                value: "842d1ae6-fce4-4a28-be05-adbdbfbb7578");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d90e75c6-7da9-490e-aeb0-3d8c4827e193",
                column: "ConcurrencyStamp",
                value: "76f89925-e00e-4b60-877d-72a71ffac99e");

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
                keyValue: "79e7930c-3df5-4261-99cf-0352eb018a91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b5c9a71f-3523-4659-9415-22cc9b48b928", "AQAAAAEAACcQAAAAENbbu/gnCStr51KrXLgl6j3yWgyQNRejA9MhxYwlo7LXOI0/zN9J/Rc0GwiszV6zcg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9009a034-7f66-455f-b76f-4f873dc93741",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fda3374d-336f-49ac-bfdb-c3acde15be6b", "AQAAAAEAACcQAAAAEHNDweT16eu+N76vRv7nxpzF1nv1CdwzI6PyiLmmiSRtXfMXaBTpCz/H6TyLIOaxIQ==" });
        }
    }
}
