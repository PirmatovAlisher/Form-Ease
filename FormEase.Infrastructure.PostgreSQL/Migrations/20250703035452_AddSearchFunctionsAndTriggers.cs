using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormEase.Infrastructure.PostgreSQL.Migrations
{
	/// <inheritdoc />
	public partial class AddSearchFunctionsAndTriggers : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{

			// Function to update the search vector for a given template_id
			migrationBuilder.Sql(@"
        CREATE OR REPLACE FUNCTION update_template_search_vector(template_id UUID) RETURNS VOID AS $$
        BEGIN
            UPDATE ""Templates""
            SET ""SearchVector"" = to_tsvector('english',
                COALESCE(""Title"", '') || ' ' ||
                COALESCE(""Description"", '') || ' ' ||
                (SELECT COALESCE(STRING_AGG(COALESCE(q.""Title"", '') || ' ' || COALESCE(q.""Description"", ''), ' '), '')
                 FROM ""Questions"" q WHERE q.""TemplateId"" = template_id) || ' ' ||
                (SELECT COALESCE(STRING_AGG(COALESCE(c.""Content"", ''), ' '), '')
                 FROM ""Comments"" c WHERE c.""TemplateId"" = template_id)
            )
            WHERE ""Id"" = template_id;
        END;
        $$ LANGUAGE plpgsql;
    ");

			// Initial population of the SearchVector for existing data
			migrationBuilder.Sql(@"
        DO $$
        DECLARE
            temp_id UUID;
        BEGIN
            FOR temp_id IN SELECT ""Id"" FROM ""Templates"" LOOP
                PERFORM update_template_search_vector(temp_id);
            END LOOP;
        END $$;
    ");

			migrationBuilder.Sql(@"
        CREATE INDEX IF NOT EXISTS ix_templates_searchvector ON ""Templates"" USING GIN (""SearchVector"");
    ");


			// Trigger on Templates table for changes to Title or Description
			migrationBuilder.Sql(@"
        CREATE OR REPLACE FUNCTION trg_templates_update_search_vector_func() RETURNS TRIGGER AS $$
        BEGIN
            PERFORM update_template_search_vector(NEW.""Id"");
            RETURN NEW;
        END;
        $$ LANGUAGE plpgsql;

        CREATE TRIGGER trg_templates_update_search_vector
        AFTER INSERT OR UPDATE OF ""Title"", ""Description"" ON ""Templates""
        FOR EACH ROW EXECUTE FUNCTION trg_templates_update_search_vector_func();
    ");

			// Trigger on Questions table for changes to Title or Description
			migrationBuilder.Sql(@"
        CREATE OR REPLACE FUNCTION trg_questions_update_template_search_vector_func() RETURNS TRIGGER AS $$
        BEGIN
            IF TG_OP = 'DELETE' THEN
                PERFORM update_template_search_vector(OLD.""TemplateId"");
            ELSE
                PERFORM update_template_search_vector(NEW.""TemplateId"");
            END IF;
            RETURN NULL; -- AFTER triggers don't need to return NEW/OLD for row-level
        END;
        $$ LANGUAGE plpgsql;

        CREATE TRIGGER trg_questions_update_template_search_vector
        AFTER INSERT OR UPDATE OF ""Title"", ""Description"" OR DELETE ON ""Questions""
        FOR EACH ROW EXECUTE FUNCTION trg_questions_update_template_search_vector_func();
    ");


			// Trigger on Comments table for changes to Content
			migrationBuilder.Sql(@"
        CREATE OR REPLACE FUNCTION trg_comments_update_template_search_vector_func() RETURNS TRIGGER AS $$
        BEGIN
            IF TG_OP = 'DELETE' THEN
                PERFORM update_template_search_vector(OLD.""TemplateId"");
            ELSE
                PERFORM update_template_search_vector(NEW.""TemplateId"");
            END IF;
            RETURN NULL; -- AFTER triggers don't need to return NEW/OLD for row-level
        END;
        $$ LANGUAGE plpgsql;

        CREATE TRIGGER trg_comments_update_template_search_vector
        AFTER INSERT OR UPDATE OF ""Content"" OR DELETE ON ""Comments""
        FOR EACH ROW EXECUTE FUNCTION trg_comments_update_template_search_vector_func();
    ");


			migrationBuilder.UpdateData(
				table: "AspNetRoles",
				keyColumn: "Id",
				keyValue: "8815f0d6-db8e-4606-8acb-12844e7b796b",
				column: "ConcurrencyStamp",
				value: "8c3d30d0-b428-48af-93a8-954408c98863");

			migrationBuilder.UpdateData(
				table: "AspNetRoles",
				keyColumn: "Id",
				keyValue: "d140eb54-ed6e-4ff2-9199-71fcbe722ef7",
				column: "ConcurrencyStamp",
				value: "d155bb2d-bafc-487d-be76-b95e31c37daf");

			migrationBuilder.UpdateData(
				table: "AspNetUsers",
				keyColumn: "Id",
				keyValue: "00000000-0000-0000-0000-000000000001",
				columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
				values: new object[] { "b5ad5605-0cfe-4edc-aef9-69f81f586ba2", "AQAAAAIAAYagAAAAEL34DLhVW7BxQQcpJFrj64fPpR/fil8aGqHqQDkAJBJ8DsXQ8FTOMDyPQvbUaXEi1Q==", "13fcffb1-4c3f-4c03-8d5a-f266de0de523" });

			migrationBuilder.UpdateData(
				table: "AspNetUsers",
				keyColumn: "Id",
				keyValue: "00000000-0000-0000-0000-000000000002",
				columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
				values: new object[] { "a449fe94-ab93-4714-a7b0-12a8bbbd2ced", "AQAAAAIAAYagAAAAEH06FGpswU3Ri+9YKJe22Vjj3JpU1th76pLmJpOy3QC91PDezZ1udvFS5Rqq5VHYDA==", "690b9225-c2e7-4bfd-843b-2432a598e724" });

			migrationBuilder.UpdateData(
				table: "AspNetUsers",
				keyColumn: "Id",
				keyValue: "00000000-0000-0000-0000-000000000003",
				columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
				values: new object[] { "3b80c285-ded6-4e28-8836-6648894666cc", "AQAAAAIAAYagAAAAEIrfEh44W5TcLfj/+NKjpcgRBhIF24X+kzQpwIPrHwUiZ7WBWcvG7zrVNgy5kz33MA==", "3e0e252c-1e70-45ad-ac30-4cbfcb058a59" });

			migrationBuilder.UpdateData(
				table: "AspNetUsers",
				keyColumn: "Id",
				keyValue: "2ade9cc9-9152-4209-ae22-f2e9e57b09a7",
				columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
				values: new object[] { "c382a033-34f7-47b8-a77a-29f8fad16a9a", "AQAAAAIAAYagAAAAEIjjvGVoS03Dr826MXXDRDF04NpcMckbhUgUs1+njgvW0eW4ar5K+psIib1Mn7l+7A==", "d7baa982-e5c9-4014-9a07-1549e8cef242" });

			migrationBuilder.UpdateData(
				table: "AspNetUsers",
				keyColumn: "Id",
				keyValue: "bb49ce85-c5c9-41d9-9665-321d430b7e2e",
				columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
				values: new object[] { "972d0a37-b255-4b53-8a57-c4d709874f62", "AQAAAAIAAYagAAAAEFWrmScthixoVNBk4IyEJJsOimPJ5bTcw1Ia+fr/yxnYwDOsdvCJwxpypewl0xUmDA==", "a66cd1e4-6531-4b53-b84b-10a049618a12" });

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000001"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 161, DateTimeKind.Utc).AddTicks(9910));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000002"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 161, DateTimeKind.Utc).AddTicks(9917));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000003"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 161, DateTimeKind.Utc).AddTicks(9920));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000004"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 161, DateTimeKind.Utc).AddTicks(9922));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000005"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 161, DateTimeKind.Utc).AddTicks(9924));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000006"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 161, DateTimeKind.Utc).AddTicks(9927));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000007"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 161, DateTimeKind.Utc).AddTicks(9929));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000008"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 161, DateTimeKind.Utc).AddTicks(9931));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000009"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 161, DateTimeKind.Utc).AddTicks(9933));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000010"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 161, DateTimeKind.Utc).AddTicks(9937));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000011"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 161, DateTimeKind.Utc).AddTicks(9939));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000012"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 161, DateTimeKind.Utc).AddTicks(9941));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000013"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 161, DateTimeKind.Utc).AddTicks(9942));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000014"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 161, DateTimeKind.Utc).AddTicks(9963));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000015"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 161, DateTimeKind.Utc).AddTicks(9965));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000016"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 161, DateTimeKind.Utc).AddTicks(9967));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000017"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 161, DateTimeKind.Utc).AddTicks(9968));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000018"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(37));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000019"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(40));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000020"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(42));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000021"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(44));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000022"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(46));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000023"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(48));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000024"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(49));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000025"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(51));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000026"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(53));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000027"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(55));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000028"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(57));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000029"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(59));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000030"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(68));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000031"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(70));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000032"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(72));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000033"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(73));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000034"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(77));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000035"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(79));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000036"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(81));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000037"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(83));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000038"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(84));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000039"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(86));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000040"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(88));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000041"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(90));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000042"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(92));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000043"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(94));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000044"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(96));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000045"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(98));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000046"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(100));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000047"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(102));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000048"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(104));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000049"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(106));

			migrationBuilder.UpdateData(
				table: "Tags",
				keyColumn: "Id",
				keyValue: new Guid("00000000-0000-0000-0005-000000000050"),
				column: "FirstUsed",
				value: new DateTime(2025, 7, 3, 3, 54, 52, 162, DateTimeKind.Utc).AddTicks(108));
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{

			migrationBuilder.Sql("DROP FUNCTION IF EXISTS update_template_search_vector(UUID);");
			migrationBuilder.Sql("DROP TRIGGER IF EXISTS trg_templates_update_search_vector ON \"Templates\";");
			migrationBuilder.Sql("DROP TRIGGER IF EXISTS trg_questions_update_template_search_vector ON \"Questions\";");
			migrationBuilder.Sql("DROP TRIGGER IF EXISTS trg_comments_update_template_search_vector ON \"Comments\";");


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
		}
	}
}
