using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormEase.Infrastructure.PostgreSQL.Migrations
{
    /// <inheritdoc />
    public partial class ExtendingUserFullName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8815f0d6-db8e-4606-8acb-12844e7b796b",
                column: "ConcurrencyStamp",
                value: "06f078f1-2e4e-4f97-b445-9d2385107efc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d140eb54-ed6e-4ff2-9199-71fcbe722ef7",
                column: "ConcurrencyStamp",
                value: "2e444ab2-a66e-47f3-a232-6675eb0d3104");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ade9cc9-9152-4209-ae22-f2e9e57b09a7",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d825d130-bf54-455a-9270-ee6e5ca4cbdb", "Ali", "Pandya", "AQAAAAIAAYagAAAAELf4+gVdJSI30u0JjxCF1A7NM24ts5O2lXk9GAoRRFuQ2eHq54PMGtJ0QfH3fBf7VQ==", "a59acb75-2d34-4089-a5cb-0ff876084fa7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb49ce85-c5c9-41d9-9665-321d430b7e2e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9577d208-105c-47d8-81fa-11a1220d8158", "Alisher", "Pirmatov", "AQAAAAIAAYagAAAAEGmVDPCgvH2iUzpADXEswMQ5PQqXJBFqyw3/kc4t94CFhZBsA66nqAsJAp8oFsv6RA==", "207451bf-5e2b-44ee-8cfb-20a4509c3ca7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8815f0d6-db8e-4606-8acb-12844e7b796b",
                column: "ConcurrencyStamp",
                value: "9a3ebc1f-62cd-4ce0-8177-b731447e7c86");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d140eb54-ed6e-4ff2-9199-71fcbe722ef7",
                column: "ConcurrencyStamp",
                value: "245156d5-c6e8-4919-b6ba-c43adbd8713f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ade9cc9-9152-4209-ae22-f2e9e57b09a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "939fd284-c85a-4845-b16c-76e843e64d53", "AQAAAAIAAYagAAAAENMbE6E/7KT0RW3q0E7vIOiQSCQAeP4S0OXOCsZ8djJu7TfGPi5DnixRZriaYZ0euQ==", "466be6ed-264f-4e57-9eca-aba280f99c7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb49ce85-c5c9-41d9-9665-321d430b7e2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94ebccdb-0d82-4940-a444-03ebd069d1f6", "AQAAAAIAAYagAAAAEHdoe6gkvelKqMrIKJesvSrZd0aHRuxVPKtFCrprD6lPjSSKR82lekFdoKYxE9nFgQ==", "490fadb0-0f23-474b-bff9-3e86d4f6815d" });
        }
    }
}
