using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormEase.Infrastructure.PostgreSQL.Migrations
{
    /// <inheritdoc />
    public partial class SeedTagsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "FirstUsed", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0005-000000000001"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5465), "Mathematics" },
                    { new Guid("00000000-0000-0000-0005-000000000002"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5472), "Algebra" },
                    { new Guid("00000000-0000-0000-0005-000000000003"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5474), "HR" },
                    { new Guid("00000000-0000-0000-0005-000000000004"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5477), "Workplace" },
                    { new Guid("00000000-0000-0000-0005-000000000005"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5479), "Science" },
                    { new Guid("00000000-0000-0000-0005-000000000006"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5483), "Physics" },
                    { new Guid("00000000-0000-0000-0005-000000000007"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5485), "Chemistry" },
                    { new Guid("00000000-0000-0000-0005-000000000008"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5487), "Biology" },
                    { new Guid("00000000-0000-0000-0005-000000000009"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5489), "Technology" },
                    { new Guid("00000000-0000-0000-0005-000000000010"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5492), "Programming" },
                    { new Guid("00000000-0000-0000-0005-000000000011"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5494), "Web Development" },
                    { new Guid("00000000-0000-0000-0005-000000000012"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5496), "Data Science" },
                    { new Guid("00000000-0000-0000-0005-000000000013"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5497), "AI" },
                    { new Guid("00000000-0000-0000-0005-000000000014"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5511), "Machine Learning" },
                    { new Guid("00000000-0000-0000-0005-000000000015"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5513), "Business" },
                    { new Guid("00000000-0000-0000-0005-000000000016"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5515), "Marketing" },
                    { new Guid("00000000-0000-0000-0005-000000000017"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5517), "Finance" },
                    { new Guid("00000000-0000-0000-0005-000000000018"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5520), "Startup" },
                    { new Guid("00000000-0000-0000-0005-000000000019"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5526), "Education" },
                    { new Guid("00000000-0000-0000-0005-000000000020"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5528), "E-Learning" },
                    { new Guid("00000000-0000-0000-0005-000000000021"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5530), "History" },
                    { new Guid("00000000-0000-0000-0005-000000000022"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5532), "Geography" },
                    { new Guid("00000000-0000-0000-0005-000000000023"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5534), "Literature" },
                    { new Guid("00000000-0000-0000-0005-000000000024"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5535), "Languages" },
                    { new Guid("00000000-0000-0000-0005-000000000025"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5537), "English" },
                    { new Guid("00000000-0000-0000-0005-000000000026"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5539), "Spanish" },
                    { new Guid("00000000-0000-0000-0005-000000000027"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5541), "Health" },
                    { new Guid("00000000-0000-0000-0005-000000000028"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5543), "Fitness" },
                    { new Guid("00000000-0000-0000-0005-000000000029"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5545), "Nutrition" },
                    { new Guid("00000000-0000-0000-0005-000000000030"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5552), "Mental Health" },
                    { new Guid("00000000-0000-0000-0005-000000000031"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5554), "Art" },
                    { new Guid("00000000-0000-0000-0005-000000000032"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5556), "Music" },
                    { new Guid("00000000-0000-0000-0005-000000000033"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5558), "Photography" },
                    { new Guid("00000000-0000-0000-0005-000000000034"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5561), "Design" },
                    { new Guid("00000000-0000-0000-0005-000000000035"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5563), "UX/UI" },
                    { new Guid("00000000-0000-0000-0005-000000000036"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5565), "Sports" },
                    { new Guid("00000000-0000-0000-0005-000000000037"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5566), "Football" },
                    { new Guid("00000000-0000-0000-0005-000000000038"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5568), "Basketball" },
                    { new Guid("00000000-0000-0000-0005-000000000039"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5570), "Entertainment" },
                    { new Guid("00000000-0000-0000-0005-000000000040"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5572), "Movies" },
                    { new Guid("00000000-0000-0000-0005-000000000041"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5574), "Gaming" },
                    { new Guid("00000000-0000-0000-0005-000000000042"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5576), "Social Media" },
                    { new Guid("00000000-0000-0000-0005-000000000043"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5578), "Cooking" },
                    { new Guid("00000000-0000-0000-0005-000000000044"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5580), "Travel" },
                    { new Guid("00000000-0000-0000-0005-000000000045"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5581), "Sustainability" },
                    { new Guid("00000000-0000-0000-0005-000000000046"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5583), "Environment" },
                    { new Guid("00000000-0000-0000-0005-000000000047"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5585), "Politics" },
                    { new Guid("00000000-0000-0000-0005-000000000048"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5587), "Society" },
                    { new Guid("00000000-0000-0000-0005-000000000049"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5589), "Survey" },
                    { new Guid("00000000-0000-0000-0005-000000000050"), new DateTime(2025, 6, 24, 6, 25, 27, 873, DateTimeKind.Utc).AddTicks(5591), "Feedback" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000001"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000002"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000003"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000004"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000005"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000006"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000007"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000008"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000009"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000010"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000011"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000012"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000013"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000014"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000015"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000016"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000017"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000018"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000019"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000020"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000021"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000022"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000023"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000024"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000025"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000026"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000027"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000028"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000029"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000030"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000031"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000032"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000033"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000034"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000035"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000036"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000037"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000038"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000039"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000040"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000041"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000042"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000043"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000044"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000045"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000046"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000047"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000048"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000049"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000050"));

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
    }
}
