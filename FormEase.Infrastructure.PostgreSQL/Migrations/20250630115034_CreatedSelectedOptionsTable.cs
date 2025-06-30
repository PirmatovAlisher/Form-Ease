using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormEase.Infrastructure.PostgreSQL.Migrations
{
    /// <inheritdoc />
    public partial class CreatedSelectedOptionsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Answers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateTable(
                name: "SelectedOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AnswerId = table.Column<Guid>(type: "uuid", nullable: false),
                    OptionId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelectedOptions_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedOptions_QuestionOptions_OptionId",
                        column: x => x.OptionId,
                        principalTable: "QuestionOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_SelectedOptions_AnswerId",
                table: "SelectedOptions",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedOptions_OptionId",
                table: "SelectedOptions",
                column: "OptionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SelectedOptions");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Answers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8815f0d6-db8e-4606-8acb-12844e7b796b",
                column: "ConcurrencyStamp",
                value: "1a0bac98-2b5b-4f6f-8ac1-a78d563a127e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d140eb54-ed6e-4ff2-9199-71fcbe722ef7",
                column: "ConcurrencyStamp",
                value: "59b7449b-4efb-4263-9ad3-f116b5c98277");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8570883-8d9e-40b3-8905-f8b6f297283e", "AQAAAAIAAYagAAAAECv0bZ6f5/jX4QIdrQ2w0r/qSo57WjME8m9h+o25fk+YqdE55d9ooiRdkkqHjBCA4A==", "26e0ffdf-bc3b-4ab5-b1b5-494c8e53668b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7fe4b7a-e636-4692-9f1d-2c654f7bd5fb", "AQAAAAIAAYagAAAAELrtOgX8U0x1lz7mt7sn2mIFIOg6wTZvAwKmxuuheYFiMBHZbi/JwuKjKCpImKVEPA==", "2b6e27f6-e0bb-42e6-9512-9b28675fa524" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b3a19d9-9510-48e2-86ee-ee5a96dfc9d3", "AQAAAAIAAYagAAAAEBOMenXg9ylFqy/TPpEDaKHkC/MDisXdJJMteY1MJIg5YbehMdJaRBmWHZTARzGrtQ==", "a5d32409-d78e-412d-b965-cca8ce510992" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ade9cc9-9152-4209-ae22-f2e9e57b09a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "181df1b7-252c-47fe-830a-d3f83aecaee8", "AQAAAAIAAYagAAAAECZ35rQhRQwJDNNPoq2HyP08/8SUdkM81wHuQ2pzkX7V0PToauSB0MmcbnM6Y89l5A==", "b65aac8c-1fd3-4f75-ba48-d594ab03f294" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb49ce85-c5c9-41d9-9665-321d430b7e2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "612e750a-c402-4736-bce4-e6befbb94d0e", "AQAAAAIAAYagAAAAEEjrSDRPQeTFW9w5Z5HqXcwAm530P70tGcs1p57N0avfRoJfsDvoAISpPpRM6fJnJQ==", "098b0e09-5f81-4780-a0cd-0788813e645d" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000001"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000002"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000003"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000004"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000005"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000006"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000007"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000008"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000009"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000010"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000011"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000012"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000013"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000014"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000015"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000016"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000017"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000018"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000019"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000020"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000021"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000022"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000023"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000024"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000025"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000026"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000027"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000028"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000029"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000030"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000031"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000032"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000033"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000034"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000035"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000036"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000037"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000038"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000039"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000040"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000041"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000042"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000043"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000044"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000045"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000046"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000047"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000048"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000049"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000050"),
                column: "FirstUsed",
                value: new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5591));
        }
    }
}
