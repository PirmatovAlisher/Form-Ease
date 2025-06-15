using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormEase.Infrastructure.PostgreSQL.Migrations
{
    /// <inheritdoc />
    public partial class ExtendingUserIsBlocked : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBlocked",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "ConcurrencyStamp", "IsBlocked", "PasswordHash", "SecurityStamp" },
                values: new object[] { "939fd284-c85a-4845-b16c-76e843e64d53", false, "AQAAAAIAAYagAAAAENMbE6E/7KT0RW3q0E7vIOiQSCQAeP4S0OXOCsZ8djJu7TfGPi5DnixRZriaYZ0euQ==", "466be6ed-264f-4e57-9eca-aba280f99c7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb49ce85-c5c9-41d9-9665-321d430b7e2e",
                columns: new[] { "ConcurrencyStamp", "IsBlocked", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94ebccdb-0d82-4940-a444-03ebd069d1f6", false, "AQAAAAIAAYagAAAAEHdoe6gkvelKqMrIKJesvSrZd0aHRuxVPKtFCrprD6lPjSSKR82lekFdoKYxE9nFgQ==", "490fadb0-0f23-474b-bff9-3e86d4f6815d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBlocked",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8815f0d6-db8e-4606-8acb-12844e7b796b",
                column: "ConcurrencyStamp",
                value: "f1d953ec-9618-4391-93c8-b7164b78c85b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d140eb54-ed6e-4ff2-9199-71fcbe722ef7",
                column: "ConcurrencyStamp",
                value: "7e76df80-3af5-41fa-83a0-6f959e65a1d3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ade9cc9-9152-4209-ae22-f2e9e57b09a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12d21aa9-809a-4882-bae4-5dba4ff68f96", "AQAAAAIAAYagAAAAELv+fHhXcdvh0SBtAhhRMuQ0zuoS57D4UpvUFMGH0O/hlWBIRcukJPjHseCSo0wuGg==", "452c269d-fc0e-40c9-959e-1c84c0667ab5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb49ce85-c5c9-41d9-9665-321d430b7e2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d603c67e-be0e-462a-b966-d849208ef1ef", "AQAAAAIAAYagAAAAEHmDGAcKJqVPxEgpSPcKE2pZ6AaPkV1vv5zcLksP8b2XThDaXDfisHwsue1/53wr9g==", "4dda901f-4e51-42fb-86b9-9485e70f6dc0" });
        }
    }
}
