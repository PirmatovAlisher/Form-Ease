using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormEase.Infrastructure.PostgreSQL.Migrations
{
    /// <inheritdoc />
    public partial class TemplateImageMakeOptional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Templates",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8815f0d6-db8e-4606-8acb-12844e7b796b",
                column: "ConcurrencyStamp",
                value: "aad08463-f299-42da-986c-0c08b1162164");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d140eb54-ed6e-4ff2-9199-71fcbe722ef7",
                column: "ConcurrencyStamp",
                value: "d8e3f585-8d48-4b97-b906-0f096fdec6a5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b5b5384-2547-4627-bde4-ad828639712e", "AQAAAAIAAYagAAAAEPtgSWSQzFOv4QbuQPVyhUTW+LGEirV+gCWJPgR27NesELDgLcpWfDh+WgDAg+Wtkw==", "b7758838-ebaa-4d71-895b-14f569fa8d40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac9ddcd7-32ee-474f-bb5e-9e720fe3f1f4", "AQAAAAIAAYagAAAAEM1RmcMoKRzvNrtBMUins2xr5XLqQ9eTsiiV2dfwJ36o6H1rcGft50u+/8fkHjGh2A==", "310a1302-0f9b-4677-ab08-ca1f4d9c8d67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86cefb80-9410-430d-9288-ccc91cdebf7c", "AQAAAAIAAYagAAAAEApSZIwK0S5omcY/jF7qM0nsK35X97Viwcuu/4bPBEzp03KdVjwZT6nZGi28XGzDDg==", "6f82e709-99b9-45f5-9533-e6c49f3e6fa2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ade9cc9-9152-4209-ae22-f2e9e57b09a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34c1937c-7aac-4816-a3ec-9f4853dd3728", "AQAAAAIAAYagAAAAEAiYXSMbaXA+o3OMGXOzOZzQUzJvgAoYBpv0LyzAq5Qie8uxQ6AH8RGGdVeNuVrgJg==", "32bb104b-dcf5-4843-94ca-4f23c178b35f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb49ce85-c5c9-41d9-9665-321d430b7e2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffd521b9-235e-4407-9dc9-0d01886df395", "AQAAAAIAAYagAAAAEP82KXkypBVtYbMLf7doA0QQBvf6X4WJ8+C8CNfRrSyKjRcemAcrTY2Qq3IY5DZ1Yw==", "f384c48d-4930-4fe8-b5fa-ca3604e85395" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Templates",
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
                value: "4f030001-fb1f-46bb-9376-5f08472a5dcd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d140eb54-ed6e-4ff2-9199-71fcbe722ef7",
                column: "ConcurrencyStamp",
                value: "d82f1c3c-ba50-466a-83a0-7ac58a8e2227");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3ec5d0c-bc65-4423-9167-418834eb4f8f", "AQAAAAIAAYagAAAAEFArmMf5dThaDuX+UVdsSqFlIdYt9+nPhEGZd3ikojlRdJ+9lfWT6i3m/VjP3Cx9mg==", "dad87a9c-f3e5-4fb9-a97e-4ee59bf70453" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "036d795f-6dac-47d0-8e53-463490dd95da", "AQAAAAIAAYagAAAAEJM/U33IaNIWKbB8WgBNn8fHxIBviz9z7yVVLdq84ATlD1yPausb/05ZJOvjK2EfSQ==", "3bc29d36-7cf2-4b48-b1c4-cf2563c778c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60cf0812-be4f-41b7-8e43-5e4a7a64fa3d", "AQAAAAIAAYagAAAAEOdOQ57Ao/tLQHZrMBiRd980xQy0ysddsL/MAfxSb6tuOkS+wOtyvCbdntumtt/kkQ==", "04f184a8-479f-445a-9a9b-4aa9e16e0371" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ade9cc9-9152-4209-ae22-f2e9e57b09a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "870d0886-3b40-42df-98f0-26d10793aabd", "AQAAAAIAAYagAAAAEP8PLNq/m6jk536GiKwdJSLjMa6REibK+dt6o+F28v44Jk/MiZLcuK1uSY+5Tr/nwg==", "3ce36301-a0ed-4eef-957b-39d6408597d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb49ce85-c5c9-41d9-9665-321d430b7e2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac5c633f-2e31-482d-84b4-e311ae08a006", "AQAAAAIAAYagAAAAEM3aUg38rsOHQlV3/45+e33ZwVotIEY90zNjv6+oT3umCMLWPBPse3vMlolKduXYyw==", "3d085922-6f09-4a87-bc40-78dbb6d4b4fd" });
        }
    }
}
