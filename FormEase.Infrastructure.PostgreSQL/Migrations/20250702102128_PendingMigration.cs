using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormEase.Infrastructure.PostgreSQL.Migrations
{
    /// <inheritdoc />
    public partial class PendingMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8815f0d6-db8e-4606-8acb-12844e7b796b",
                column: "ConcurrencyStamp",
                value: "e066bf64-f266-46ae-887c-d2f56d6ca310");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d140eb54-ed6e-4ff2-9199-71fcbe722ef7",
                column: "ConcurrencyStamp",
                value: "389de957-cb1f-419b-860f-bd3138ef8333");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa902713-155c-47a6-acdb-39a4f696ebfa", "AQAAAAIAAYagAAAAEJxzRYYUOfRb7GF8nRPPlpATO8vl0E8MwuXRZWJrhETEjCcQQytjN9eIGkt1W3NRlw==", "8aa27633-398a-49a2-9990-92e427609f28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9104167-e98c-4b23-ab45-936a5defb0b5", "AQAAAAIAAYagAAAAEJ283VAlp3I4HsKLYvdStE51vQRP1YHnpUaiaDa/6DGMRrdvqZwEbVU55OimBDFPQg==", "6f5d1b2e-3b27-467c-be54-083f96245ded" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "893d0c8b-914f-4f67-a5ad-7c934b1c6bf4", "AQAAAAIAAYagAAAAEGTc2yhx4oC2uzaiv3+1pf0eR/C475GJPg8Bn7SgD9QhFyZH31gXl1L+KEU4EgTJ3g==", "4ad50ac6-52e9-4815-9554-4a0c7d03fad8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ade9cc9-9152-4209-ae22-f2e9e57b09a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "403f0625-6bac-4c03-b659-94281910083b", "AQAAAAIAAYagAAAAEJH9OmzbJt/JWCsB0zOZai7XN49XMKh2dSJEzcE0m3Txhf7jYIwXy58cNPFDmXKWzg==", "5157affb-4a4f-4863-ba37-04de06f82193" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb49ce85-c5c9-41d9-9665-321d430b7e2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7be33602-245a-473e-89b5-b82ade3e7340", "AQAAAAIAAYagAAAAENWs+1VAWlRLiCVy3LjUbNx7OwudrjCaCEBlRRf0wGKFhywKP/59D5MB0VpYkPc5FQ==", "001bd14c-05aa-44ef-81f0-0a8949da41d3" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000001"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000002"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000003"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000004"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000005"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000006"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000007"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000008"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000009"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000010"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000011"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000012"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000013"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000014"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000015"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000016"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000017"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000018"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000019"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000020"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000021"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000022"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000023"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000024"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000025"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000026"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000027"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000028"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000029"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000030"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000031"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000032"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000033"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000034"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000035"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000036"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000037"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000038"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000039"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000040"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000041"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000042"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000043"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000044"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000045"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000046"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000047"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000048"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000049"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000050"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 2, 10, 21, 25, 744, DateTimeKind.Utc).AddTicks(5528));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8815f0d6-db8e-4606-8acb-12844e7b796b",
                column: "ConcurrencyStamp",
                value: "fe06d027-c4ff-4bf4-bbc2-056f05bfc74b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d140eb54-ed6e-4ff2-9199-71fcbe722ef7",
                column: "ConcurrencyStamp",
                value: "13c35fe5-1344-4293-8559-a2b882fb1ba9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59addcc7-1a92-4c0f-aede-8fabf051e15c", "AQAAAAIAAYagAAAAEM5LzAEvJ92V9zw5L6gL0apyBSMCYgfPG+HZtLpdkDAD/B7xtdHk8enda4EGxsPJiw==", "4b4e615a-15f3-4e7f-b708-85c0c06299b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4818bbb-ad0c-4b01-8567-b9bb8003ac5d", "AQAAAAIAAYagAAAAEC+mRdBicg+73IvdQw1Ux9zxk8rBRxkc7rwC7rljz+rnfIhSKZCwseCMfJVH9iXA1w==", "349cffaf-b9c4-4635-90a6-da75aa2696fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30db3688-0377-4954-a8f1-dde50b6799b0", "AQAAAAIAAYagAAAAENld6Oi1xG+vngAoD/ZT1XEvUvAtTHWzZlRGmQEnvHGb+4cxrXGtmJh/NKEEqSi4AA==", "ffef2af2-5159-474f-b6dc-85ac89c425c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ade9cc9-9152-4209-ae22-f2e9e57b09a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac6ea372-9420-4807-a31e-cff2a130419f", "AQAAAAIAAYagAAAAEM2vdgS4I+uVHY8JN7naPHh4x8AtZ4dXxZLHKYlhi66wxD091fiVwTohZkJbALubmw==", "17d37e3d-de29-4cc6-b40c-9dd95d464f4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb49ce85-c5c9-41d9-9665-321d430b7e2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "371b7641-9ee8-4f06-a8d5-4bf41e878e25", "AQAAAAIAAYagAAAAEDanoLimVUXcy+rzkkOL3VGxjMlqVZDyRuHemeox9VEOizxaq22Uisp5nhIBF2E3VA==", "7b90a687-2040-48c5-930d-6e84f04ad8f1" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000001"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000002"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000003"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000004"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000005"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000006"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000007"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000008"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000009"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000010"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000011"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000012"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000013"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000014"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000015"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000016"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000017"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000018"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000019"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000020"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000021"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000022"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000023"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000024"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000025"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000026"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000027"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000028"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000029"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000030"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000031"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000032"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000033"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000034"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000035"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000036"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000037"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000038"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000039"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000040"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000041"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000042"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000043"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000044"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000045"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000046"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000047"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000048"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000049"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000050"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 30, 11, 50, 30, 804, DateTimeKind.Utc).AddTicks(6370));
        }
    }
}
