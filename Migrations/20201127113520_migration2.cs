using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicDating.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "32b87edb-0851-4ab0-95e2-2e082510b91b", "a6a5d65e-e228-40ff-a2f6-42c6bb85fd51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "014ca478-2d3d-4f5e-b2e5-5f9b0ee990ec", "abd31b70-0bd9-4cca-8ec6-f4ee7046e66d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "LastName", "SecurityStamp" },
                values: new object[] { "d75d7dae-6b9a-4d65-aee7-2ba0e9c2135b", "1", "941ffcc4-e372-4584-b31f-69ba39eb5b6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "LastName", "SecurityStamp" },
                values: new object[] { "c834fc5c-d304-439d-8862-3505cfd699a0", "2", "3002497f-c0ed-488d-a585-fc560a08bc28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "LastName", "SecurityStamp" },
                values: new object[] { "e6c1a4c3-6f48-4a8a-b59c-02b47458a311", "3", "c412373f-c9dd-4338-8632-b492d28f5b32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "LastName", "SecurityStamp" },
                values: new object[] { "7eafb9d6-146a-45c5-bc27-0277b4f1d468", "4", "45919dd6-fadc-4f29-a4b1-58b6f09ec310" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "134d8ff3-3d07-4795-b5f1-a4ac993e3dc2", "747a3da1-db3b-410a-ac44-0c628913e1ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4b84eef7-ca75-4a1f-8d4d-97c3ff0657d4", "49645804-4d2c-4385-81ab-cf88111cd367" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "LastName", "SecurityStamp" },
                values: new object[] { "8a489ffd-611d-4370-9acc-35a5f7b9ca1e", "Kirschberg", "14bf45ae-b949-44d2-bd71-e6275173c4f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "LastName", "SecurityStamp" },
                values: new object[] { "3308c518-a991-4414-bbc7-835908f9cf6d", "Kirschberg", "bad7cf6d-6d64-4b6b-8044-df9684bf2cf9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "LastName", "SecurityStamp" },
                values: new object[] { "3a3eb1c1-74f2-4218-85a9-b2d22b9b2fb7", "Kirschberg", "0f88f8b4-afbe-403b-80db-b47449ed397f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "LastName", "SecurityStamp" },
                values: new object[] { "89810816-56fe-4870-a253-b5fcc3c18e3d", "Kirschberg", "f5951cd5-3772-47cb-997b-fa224d868404" });
        }
    }
}
