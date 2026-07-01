using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CartFlow.Migrations
{
    /// <inheritdoc />
    public partial class product_seed_created : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "DiscountId", "IsActive", "Name", "Price", "Sold", "Stock", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("0261e398-0648-4587-af80-cd76832f9324"), new Guid("019f08ba-b96f-73af-bed7-201a139d6f66"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kitap kategorisi örnek ürün 1", null, true, "Kitap Ürünü 1", 1062m, 2, 98, null, null },
                    { new Guid("047a442a-0d7a-4942-9400-6fbdfde190e6"), new Guid("019f08bb-1a94-76c5-9a80-049bb0539f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gıda kategorisi örnek ürün 3", null, true, "Gıda Ürünü 3", 1706m, 86, 134, null, null },
                    { new Guid("08465368-9042-4c4e-9692-0f1eaad4cf92"), new Guid("019f08bc-bf2c-7bd0-9a50-e6c286cfed60"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Müzik kategorisi örnek ürün 1", null, true, "Müzik Ürünü 1", 2431m, 81, 29, null, null },
                    { new Guid("0cf83315-057b-4491-9ae4-d9180dc2a16b"), new Guid("019f08bb-1a94-76c5-9a80-049bb0539f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gıda kategorisi örnek ürün 2", null, true, "Gıda Ürünü 2", 1569m, 79, 131, null, null },
                    { new Guid("0d5027f5-2b74-44f6-9283-7433b3dcf1b1"), new Guid("019f08bb-6b1f-7605-b8a0-c2c887cf4699"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bahçe kategorisi örnek ürün 2", null, true, "Bahçe Ürünü 2", 1717m, 17, 143, null, null },
                    { new Guid("0f256e5c-b710-413d-9545-8153d9a557aa"), new Guid("019f08bc-81c0-783c-bfd7-eef39eda9c5a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kozmetik kategorisi örnek ürün 2", null, true, "Kozmetik Ürünü 2", 2457m, 67, 23, null, null },
                    { new Guid("11feb522-b6e5-4925-b3e0-8227e61c97e3"), new Guid("019f08ba-b96f-73af-bed7-201a139d6f66"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kitap kategorisi örnek ürün 4", null, true, "Kitap Ürünü 4", 1473m, 23, 107, null, null },
                    { new Guid("12434a5c-3d58-41a4-8985-4f7e09ff8a9c"), new Guid("019f08b9-29a2-714a-a6f2-1d4a0734e73d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aksesuar kategorisi örnek ürün 4", null, true, "Aksesuar Ürünü 4", 918m, 8, 62, null, null },
                    { new Guid("1324f2ea-5a60-4ca2-bd96-3dbec3e66d45"), new Guid("019f08ba-8a2f-7489-b10e-de71178d9a20"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giyim kategorisi örnek ürün 1", null, true, "Giyim Ürünü 1", 877m, 57, 83, null, null },
                    { new Guid("13351535-9a3c-492b-9b85-6bad6241bf0c"), new Guid("019f08b8-f30b-7ed0-a389-087547932d37"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gayrimenkul kategorisi örnek ürün 4", null, true, "Gayrimenkul Ürünü 4", 770m, 70, 50, null, null },
                    { new Guid("14fdb833-77f2-493b-b20c-b2fbb7a67254"), new Guid("019f08ba-5838-7d1f-8298-2921c18d770c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spor kategorisi örnek ürün 5", null, true, "Spor Ürünü 5", 1240m, 50, 80, null, null },
                    { new Guid("1793b925-64b5-4861-93f2-3966b2c4ad60"), new Guid("019f08ba-efa5-787a-ab95-48dc207f7884"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oyun kategorisi örnek ürün 2", null, true, "Oyun Ürünü 2", 1384m, 44, 116, null, null },
                    { new Guid("18623cfa-7b1b-4dbc-be13-aa52762215af"), new Guid("019f08bc-4ff4-799f-9b8e-3badd35c0ff5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evcil Hayvan kategorisi örnek ürün 4", null, true, "Evcil Hayvan Ürünü 4", 2583m, 53, 197, null, null },
                    { new Guid("1f292b22-24dd-4950-96ab-9e9c13ffe46f"), new Guid("019f08a6-792e-716c-aa96-a77a670b615a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teknoloji kategorisi örnek ürün 1", null, true, "Teknoloji Ürünü 1", 137m, 7, 23, null, null },
                    { new Guid("20965ea0-ce83-470e-9638-2674ca3299da"), new Guid("019f08b9-29a2-714a-a6f2-1d4a0734e73d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aksesuar kategorisi örnek ürün 3", null, true, "Aksesuar Ürünü 3", 781m, 1, 59, null, null },
                    { new Guid("234db44a-993b-4cd8-89ee-9ae92cc392aa"), new Guid("019f08bb-d442-7fb7-a6cf-5325fb2b51f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alet kategorisi örnek ürün 4", null, true, "Alet Ürünü 4", 2287m, 87, 173, null, null },
                    { new Guid("24ec1441-8f30-4fbc-bc0a-8e273c3ad8b4"), new Guid("019f08bc-1283-75a5-a94f-e31609eb4d4e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seyahat kategorisi örnek ürün 1", null, true, "Seyahat Ürünü 1", 2024m, 4, 176, null, null },
                    { new Guid("2b068a3a-4625-4a86-8edf-1c178bf948aa"), new Guid("019f08b8-f30b-7ed0-a389-087547932d37"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gayrimenkul kategorisi örnek ürün 1", null, true, "Gayrimenkul Ürünü 1", 359m, 49, 41, null, null },
                    { new Guid("2bc88856-e96b-4e19-9622-65fc0d6f84c0"), new Guid("019f08bc-1283-75a5-a94f-e31609eb4d4e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seyahat kategorisi örnek ürün 2", null, true, "Seyahat Ürünü 2", 2161m, 11, 179, null, null },
                    { new Guid("2c0004ee-c113-4678-9a0b-3bb33e25b215"), new Guid("019f08bb-6b1f-7605-b8a0-c2c887cf4699"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bahçe kategorisi örnek ürün 4", null, true, "Bahçe Ürünü 4", 1991m, 31, 149, null, null },
                    { new Guid("3057dc36-24a1-40f1-a468-69cb6dac3ac9"), new Guid("019f08bc-81c0-783c-bfd7-eef39eda9c5a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kozmetik kategorisi örnek ürün 1", null, true, "Kozmetik Ürünü 1", 2320m, 60, 20, null, null },
                    { new Guid("32c4cb38-ef1c-489c-bcf8-7fa70b9d5b3a"), new Guid("019f08bb-1a94-76c5-9a80-049bb0539f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gıda kategorisi örnek ürün 4", null, true, "Gıda Ürünü 4", 1843m, 3, 137, null, null },
                    { new Guid("36eeeebe-eb18-4e26-83db-f09ceadcb990"), new Guid("019f08a6-792e-716c-aa96-a77a670b615a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teknoloji kategorisi örnek ürün 2", null, true, "Teknoloji Ürünü 2", 274m, 14, 26, null, null },
                    { new Guid("3910a585-41e0-46ba-98ca-468b8d2c9a27"), new Guid("019f08bc-e16d-7a9b-8d2d-3338247ad7c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Futbol kategorisi örnek ürün 3", null, true, "Futbol Ürünü 3", 2816m, 26, 44, null, null },
                    { new Guid("3c473a3c-fe57-41bd-bb1b-cfa749207ffb"), new Guid("019f08b9-29a2-714a-a6f2-1d4a0734e73d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aksesuar kategorisi örnek ürün 5", null, true, "Aksesuar Ürünü 5", 1055m, 15, 65, null, null },
                    { new Guid("40f6cbfe-66cb-43e1-85ee-8c853f655891"), new Guid("019f08ba-8a2f-7489-b10e-de71178d9a20"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giyim kategorisi örnek ürün 3", null, true, "Giyim Ürünü 3", 1151m, 71, 89, null, null },
                    { new Guid("466ef3c0-c2d9-4198-9f18-f272aaee8631"), new Guid("019f08a6-792e-716c-aa96-a77a670b615a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teknoloji kategorisi örnek ürün 5", null, true, "Teknoloji Ürünü 5", 685m, 35, 35, null, null },
                    { new Guid("4b549ee9-6bfb-48ef-8a7b-9c93f6263ccb"), new Guid("019f08bb-d442-7fb7-a6cf-5325fb2b51f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alet kategorisi örnek ürün 1", null, true, "Alet Ürünü 1", 1876m, 66, 164, null, null },
                    { new Guid("5914b56f-7705-4bbb-a853-3b82fd4c9ff4"), new Guid("019f08ba-5838-7d1f-8298-2921c18d770c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spor kategorisi örnek ürün 3", null, true, "Spor Ürünü 3", 966m, 36, 74, null, null },
                    { new Guid("5d6c926e-9585-40ff-b1ca-0cb0b37c84c5"), new Guid("019f08bc-bf2c-7bd0-9a50-e6c286cfed60"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Müzik kategorisi örnek ürün 3", null, true, "Müzik Ürünü 3", 2705m, 5, 35, null, null },
                    { new Guid("627fe19c-5969-4e47-8f0a-ca0d69c6cf71"), new Guid("019f08b9-29a2-714a-a6f2-1d4a0734e73d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aksesuar kategorisi örnek ürün 2", null, true, "Aksesuar Ürünü 2", 644m, 84, 56, null, null },
                    { new Guid("6781191d-f6c6-43b8-b509-f855009de671"), new Guid("019f08bc-4ff4-799f-9b8e-3badd35c0ff5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evcil Hayvan kategorisi örnek ürün 2", null, true, "Evcil Hayvan Ürünü 2", 2309m, 39, 191, null, null },
                    { new Guid("6dca607b-1701-4e74-9d6c-83d93b04e0ba"), new Guid("019f08bc-1283-75a5-a94f-e31609eb4d4e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seyahat kategorisi örnek ürün 4", null, true, "Seyahat Ürünü 4", 2435m, 25, 185, null, null },
                    { new Guid("6f9066aa-518a-433a-85f2-745dec20299a"), new Guid("019f08ba-b96f-73af-bed7-201a139d6f66"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kitap kategorisi örnek ürün 3", null, true, "Kitap Ürünü 3", 1336m, 16, 104, null, null },
                    { new Guid("71286aea-213f-43d5-bb2e-28dde23c4749"), new Guid("019f08bc-4ff4-799f-9b8e-3badd35c0ff5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evcil Hayvan kategorisi örnek ürün 3", null, true, "Evcil Hayvan Ürünü 3", 2446m, 46, 194, null, null },
                    { new Guid("71336fa8-4118-4e08-b2c7-a7a5dd0f3da5"), new Guid("019f08bb-d442-7fb7-a6cf-5325fb2b51f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alet kategorisi örnek ürün 3", null, true, "Alet Ürünü 3", 2150m, 80, 170, null, null },
                    { new Guid("7ce65e2a-5d85-46d9-8f9e-3d4f285386b8"), new Guid("019f08ba-8a2f-7489-b10e-de71178d9a20"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giyim kategorisi örnek ürün 5", null, true, "Giyim Ürünü 5", 1425m, 85, 95, null, null },
                    { new Guid("88ae29a7-a070-4cb8-9dfe-ddab20bb3b68"), new Guid("019f08bb-1a94-76c5-9a80-049bb0539f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gıda kategorisi örnek ürün 1", null, true, "Gıda Ürünü 1", 1432m, 72, 128, null, null },
                    { new Guid("9ac8d55c-d87e-4b46-80c1-4ca3900c9351"), new Guid("019f08a6-792e-716c-aa96-a77a670b615a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teknoloji kategorisi örnek ürün 6", null, true, "Teknoloji Ürünü 6", 822m, 42, 38, null, null },
                    { new Guid("a0781b94-9419-4ae0-a5cc-7f2cee2ec837"), new Guid("019f08ba-efa5-787a-ab95-48dc207f7884"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oyun kategorisi örnek ürün 5", null, true, "Oyun Ürünü 5", 1795m, 65, 125, null, null },
                    { new Guid("a38d379c-b943-446e-9995-dc733e820ce2"), new Guid("019f08ba-efa5-787a-ab95-48dc207f7884"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oyun kategorisi örnek ürün 3", null, true, "Oyun Ürünü 3", 1521m, 51, 119, null, null },
                    { new Guid("a41a23aa-b996-45ee-b8b3-71d39a571e59"), new Guid("019f08b8-f30b-7ed0-a389-087547932d37"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gayrimenkul kategorisi örnek ürün 2", null, true, "Gayrimenkul Ürünü 2", 496m, 56, 44, null, null },
                    { new Guid("a4727782-2a4b-49d3-93c7-4202b1a4b6a9"), new Guid("019f08a6-792e-716c-aa96-a77a670b615a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teknoloji kategorisi örnek ürün 3", null, true, "Teknoloji Ürünü 3", 411m, 21, 29, null, null },
                    { new Guid("a86df4b5-0b5b-41e5-8845-1dd5d12fba76"), new Guid("019f08b8-f30b-7ed0-a389-087547932d37"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gayrimenkul kategorisi örnek ürün 3", null, true, "Gayrimenkul Ürünü 3", 633m, 63, 47, null, null },
                    { new Guid("ae4a3e70-3dd5-428f-882d-0138aa2bec07"), new Guid("019f08bb-6b1f-7605-b8a0-c2c887cf4699"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bahçe kategorisi örnek ürün 1", null, true, "Bahçe Ürünü 1", 1580m, 10, 140, null, null },
                    { new Guid("afa18abd-aa00-471a-96eb-f3a4fad0a3f9"), new Guid("019f08bc-bf2c-7bd0-9a50-e6c286cfed60"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Müzik kategorisi örnek ürün 2", null, true, "Müzik Ürünü 2", 2568m, 88, 32, null, null },
                    { new Guid("bc6103fa-46f0-4e08-95b8-0f8d3b156cde"), new Guid("019f08bc-e16d-7a9b-8d2d-3338247ad7c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Futbol kategorisi örnek ürün 2", null, true, "Futbol Ürünü 2", 2679m, 19, 41, null, null },
                    { new Guid("c33c4990-3106-4dfb-8ae3-6fe1bbf62cb3"), new Guid("019f08ba-efa5-787a-ab95-48dc207f7884"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oyun kategorisi örnek ürün 1", null, true, "Oyun Ürünü 1", 1247m, 37, 113, null, null },
                    { new Guid("c340637c-4891-4ec5-9639-4b694e065319"), new Guid("019f08ba-5838-7d1f-8298-2921c18d770c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spor kategorisi örnek ürün 2", null, true, "Spor Ürünü 2", 829m, 29, 71, null, null },
                    { new Guid("c59a61cc-38a8-4509-b52e-d214b6bd82a0"), new Guid("019f08ba-b96f-73af-bed7-201a139d6f66"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kitap kategorisi örnek ürün 5", null, true, "Kitap Ürünü 5", 1610m, 30, 110, null, null },
                    { new Guid("c86af925-583b-4290-ab68-da8f691ae5c7"), new Guid("019f08bc-81c0-783c-bfd7-eef39eda9c5a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kozmetik kategorisi örnek ürün 3", null, true, "Kozmetik Ürünü 3", 2594m, 74, 26, null, null },
                    { new Guid("c95c3c9e-e5a7-4306-b5e7-7eec3144327d"), new Guid("019f08a6-792e-716c-aa96-a77a670b615a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teknoloji kategorisi örnek ürün 4", null, true, "Teknoloji Ürünü 4", 548m, 28, 32, null, null },
                    { new Guid("d0e5cee4-05ab-4922-b8b8-a1418dea1a47"), new Guid("019f08bc-e16d-7a9b-8d2d-3338247ad7c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Futbol kategorisi örnek ürün 1", null, true, "Futbol Ürünü 1", 2542m, 12, 38, null, null },
                    { new Guid("d28254cc-56bc-47bd-864d-0e178830b7b6"), new Guid("019f08bb-9b46-7db5-91c5-bcb874f42aff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanat kategorisi örnek ürün 3", null, true, "Sanat Ürünü 3", 2002m, 52, 158, null, null },
                    { new Guid("dcaee9df-1af7-4a53-9467-55546f4ddcbf"), new Guid("019f08ba-b96f-73af-bed7-201a139d6f66"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kitap kategorisi örnek ürün 2", null, true, "Kitap Ürünü 2", 1199m, 9, 101, null, null },
                    { new Guid("dd795d21-3775-43a3-b431-cf23fd1bd2ae"), new Guid("019f08ba-8a2f-7489-b10e-de71178d9a20"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giyim kategorisi örnek ürün 4", null, true, "Giyim Ürünü 4", 1288m, 78, 92, null, null },
                    { new Guid("de134ad5-da0f-48ac-8e55-bcf801770f4b"), new Guid("019f08ba-5838-7d1f-8298-2921c18d770c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spor kategorisi örnek ürün 4", null, true, "Spor Ürünü 4", 1103m, 43, 77, null, null },
                    { new Guid("de1ad4eb-a460-48b3-bf66-96212dbeaf26"), new Guid("019f08ba-5838-7d1f-8298-2921c18d770c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spor kategorisi örnek ürün 1", null, true, "Spor Ürünü 1", 692m, 22, 68, null, null },
                    { new Guid("e11f6d49-4e30-45ba-b79e-278c5a0e697d"), new Guid("019f08ba-efa5-787a-ab95-48dc207f7884"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oyun kategorisi örnek ürün 4", null, true, "Oyun Ürünü 4", 1658m, 58, 122, null, null },
                    { new Guid("e34af255-11f5-4ba7-8ae7-6cfedb6f5762"), new Guid("019f08bb-6b1f-7605-b8a0-c2c887cf4699"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bahçe kategorisi örnek ürün 3", null, true, "Bahçe Ürünü 3", 1854m, 24, 146, null, null },
                    { new Guid("e90ef6b0-a66a-41aa-a2ea-4475f94239ad"), new Guid("019f08bb-9b46-7db5-91c5-bcb874f42aff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanat kategorisi örnek ürün 2", null, true, "Sanat Ürünü 2", 1865m, 45, 155, null, null },
                    { new Guid("ea6ccb86-1a28-4500-9edb-836df99b06d8"), new Guid("019f08bc-4ff4-799f-9b8e-3badd35c0ff5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evcil Hayvan kategorisi örnek ürün 1", null, true, "Evcil Hayvan Ürünü 1", 2172m, 32, 188, null, null },
                    { new Guid("ebe56a59-4a80-494e-943d-c1141d3fc04c"), new Guid("019f08bb-9b46-7db5-91c5-bcb874f42aff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanat kategorisi örnek ürün 1", null, true, "Sanat Ürünü 1", 1728m, 38, 152, null, null },
                    { new Guid("ed3ebdb5-0db9-4a36-899d-bf6e86679fa4"), new Guid("019f08bb-d442-7fb7-a6cf-5325fb2b51f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alet kategorisi örnek ürün 2", null, true, "Alet Ürünü 2", 2013m, 73, 167, null, null },
                    { new Guid("f07149b9-ab05-45ce-b960-b1c0d84289e8"), new Guid("019f08b9-29a2-714a-a6f2-1d4a0734e73d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aksesuar kategorisi örnek ürün 1", null, true, "Aksesuar Ürünü 1", 507m, 77, 53, null, null },
                    { new Guid("f10e41c8-556a-41e8-bbff-e52cee233c12"), new Guid("019f08bc-1283-75a5-a94f-e31609eb4d4e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seyahat kategorisi örnek ürün 3", null, true, "Seyahat Ürünü 3", 2298m, 18, 182, null, null },
                    { new Guid("fbe8c1bd-552b-453c-8da1-27a445725977"), new Guid("019f08bb-9b46-7db5-91c5-bcb874f42aff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanat kategorisi örnek ürün 4", null, true, "Sanat Ürünü 4", 2139m, 59, 161, null, null },
                    { new Guid("fc496a28-e985-4193-b1e8-9face21d32a6"), new Guid("019f08ba-8a2f-7489-b10e-de71178d9a20"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giyim kategorisi örnek ürün 2", null, true, "Giyim Ürünü 2", 1014m, 64, 86, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0261e398-0648-4587-af80-cd76832f9324"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("047a442a-0d7a-4942-9400-6fbdfde190e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08465368-9042-4c4e-9692-0f1eaad4cf92"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0cf83315-057b-4491-9ae4-d9180dc2a16b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d5027f5-2b74-44f6-9283-7433b3dcf1b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f256e5c-b710-413d-9545-8153d9a557aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11feb522-b6e5-4925-b3e0-8227e61c97e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12434a5c-3d58-41a4-8985-4f7e09ff8a9c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1324f2ea-5a60-4ca2-bd96-3dbec3e66d45"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13351535-9a3c-492b-9b85-6bad6241bf0c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14fdb833-77f2-493b-b20c-b2fbb7a67254"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1793b925-64b5-4861-93f2-3966b2c4ad60"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18623cfa-7b1b-4dbc-be13-aa52762215af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f292b22-24dd-4950-96ab-9e9c13ffe46f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20965ea0-ce83-470e-9638-2674ca3299da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("234db44a-993b-4cd8-89ee-9ae92cc392aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24ec1441-8f30-4fbc-bc0a-8e273c3ad8b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b068a3a-4625-4a86-8edf-1c178bf948aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2bc88856-e96b-4e19-9622-65fc0d6f84c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c0004ee-c113-4678-9a0b-3bb33e25b215"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3057dc36-24a1-40f1-a468-69cb6dac3ac9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32c4cb38-ef1c-489c-bcf8-7fa70b9d5b3a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36eeeebe-eb18-4e26-83db-f09ceadcb990"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3910a585-41e0-46ba-98ca-468b8d2c9a27"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c473a3c-fe57-41bd-bb1b-cfa749207ffb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40f6cbfe-66cb-43e1-85ee-8c853f655891"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("466ef3c0-c2d9-4198-9f18-f272aaee8631"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b549ee9-6bfb-48ef-8a7b-9c93f6263ccb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5914b56f-7705-4bbb-a853-3b82fd4c9ff4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d6c926e-9585-40ff-b1ca-0cb0b37c84c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("627fe19c-5969-4e47-8f0a-ca0d69c6cf71"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6781191d-f6c6-43b8-b509-f855009de671"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6dca607b-1701-4e74-9d6c-83d93b04e0ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f9066aa-518a-433a-85f2-745dec20299a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71286aea-213f-43d5-bb2e-28dde23c4749"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71336fa8-4118-4e08-b2c7-a7a5dd0f3da5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ce65e2a-5d85-46d9-8f9e-3d4f285386b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88ae29a7-a070-4cb8-9dfe-ddab20bb3b68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ac8d55c-d87e-4b46-80c1-4ca3900c9351"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0781b94-9419-4ae0-a5cc-7f2cee2ec837"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a38d379c-b943-446e-9995-dc733e820ce2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a41a23aa-b996-45ee-b8b3-71d39a571e59"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4727782-2a4b-49d3-93c7-4202b1a4b6a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a86df4b5-0b5b-41e5-8845-1dd5d12fba76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae4a3e70-3dd5-428f-882d-0138aa2bec07"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("afa18abd-aa00-471a-96eb-f3a4fad0a3f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc6103fa-46f0-4e08-95b8-0f8d3b156cde"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c33c4990-3106-4dfb-8ae3-6fe1bbf62cb3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c340637c-4891-4ec5-9639-4b694e065319"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c59a61cc-38a8-4509-b52e-d214b6bd82a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c86af925-583b-4290-ab68-da8f691ae5c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c95c3c9e-e5a7-4306-b5e7-7eec3144327d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d0e5cee4-05ab-4922-b8b8-a1418dea1a47"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d28254cc-56bc-47bd-864d-0e178830b7b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcaee9df-1af7-4a53-9467-55546f4ddcbf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dd795d21-3775-43a3-b431-cf23fd1bd2ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de134ad5-da0f-48ac-8e55-bcf801770f4b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de1ad4eb-a460-48b3-bf66-96212dbeaf26"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e11f6d49-4e30-45ba-b79e-278c5a0e697d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e34af255-11f5-4ba7-8ae7-6cfedb6f5762"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e90ef6b0-a66a-41aa-a2ea-4475f94239ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea6ccb86-1a28-4500-9edb-836df99b06d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ebe56a59-4a80-494e-943d-c1141d3fc04c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed3ebdb5-0db9-4a36-899d-bf6e86679fa4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f07149b9-ab05-45ce-b960-b1c0d84289e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f10e41c8-556a-41e8-bbff-e52cee233c12"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fbe8c1bd-552b-453c-8da1-27a445725977"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc496a28-e985-4193-b1e8-9face21d32a6"));
        }
    }
}
