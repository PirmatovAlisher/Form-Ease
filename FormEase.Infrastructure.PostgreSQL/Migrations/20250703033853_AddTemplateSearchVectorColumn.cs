using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NpgsqlTypes;

#nullable disable

namespace FormEase.Infrastructure.PostgreSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddTemplateSearchVectorColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<NpgsqlTsVector>(
                name: "SearchVector",
                table: "Templates",
                type: "TSVECTOR",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8815f0d6-db8e-4606-8acb-12844e7b796b",
                column: "ConcurrencyStamp",
                value: "d4e943f1-6067-4163-a552-b937a4491fcb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d140eb54-ed6e-4ff2-9199-71fcbe722ef7",
                column: "ConcurrencyStamp",
                value: "077a7366-de48-43c8-b13a-b6cf3fcd2bfc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3276f06d-e473-43b6-ba9d-0a35e1d94c91", "AQAAAAIAAYagAAAAELEZl/+8iZnoIR0Px/0siec3/SPzkQdmltii8sYiLBA4EIWgfgx5PO79IeftmJjaPQ==", "fa7651fc-3e67-413b-8100-daded0347b85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69d8bef6-30d0-41fb-b53b-fb8b0fef44fb", "AQAAAAIAAYagAAAAEFaBZcAjmqcJXnocWxBYzrf/gIjgEAvp67U23cqAzERqIKCTB1c0YNxilNaoF/wcOA==", "5ef8b9cc-46a1-43bd-98c7-c6aaf1119963" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc7f6223-2fb5-40a9-918b-a4b995124315", "AQAAAAIAAYagAAAAECbEnszJRlkDM6Sz9QWIXWBQrGigwJCt/8IDIfL5WT2Cs9pL5E++idneQWjE2p3vzw==", "8f87bd8e-17b9-4420-91f1-47ca2b01e16c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ade9cc9-9152-4209-ae22-f2e9e57b09a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2ff670e-b9ab-42b1-a1c5-bba66710afe9", "AQAAAAIAAYagAAAAEPPT/nojwroy3vhfM0n6ZC3aYeV+3IvXCYZHL5Rb3acfnT4Rdw2Py2CQF69PJc5a7Q==", "f6250342-6747-4a34-b592-5267c57ca89d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb49ce85-c5c9-41d9-9665-321d430b7e2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5352c47a-3d22-484d-a208-79006230d6e1", "AQAAAAIAAYagAAAAEJ4tYMBbfAGqYNhUm6ICIdhkb/UQK42x113YlP3jkGiQqLrT3o2WgEGV85sMcMBy7A==", "df83d719-4dd7-4283-9ddc-258d2d6c0090" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000001"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000002"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000003"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000004"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000005"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000006"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000007"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000008"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000009"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000010"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000011"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000012"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000013"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000014"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000015"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000016"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000017"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000018"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000019"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000020"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000021"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000022"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000023"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000024"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000025"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000026"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000027"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000028"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000029"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000030"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000031"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000032"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000033"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000034"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000035"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000036"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000037"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000038"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000039"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000040"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000041"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000042"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000043"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000044"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000045"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000046"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000047"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000048"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000049"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000050"),
                column: "FirstUsed",
                value: new DateTime(2025, 7, 3, 3, 38, 49, 951, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.CreateIndex(
                name: "IX_Templates_SearchVector",
                table: "Templates",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Templates_SearchVector",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "SearchVector",
                table: "Templates");

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
    }
}
