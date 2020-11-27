using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicDating.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "199cab6c-1923-43dc-b538-c72eb40f2c41", "08f9da5f-6051-4c62-8358-4fb2279b2f61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ce79c426-6e1f-4b6a-8912-d909d1347bde", "8531b0d8-c90b-425d-b2c3-3265e2714bd6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41b5f064-94dc-440b-a161-258663279e2f", "7a278964-4aa4-4319-ad1c-0d9ac229eba8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ffd4430c-68db-41f8-95da-e7097821709e", "c02f48a7-6c00-4968-a18a-b6972fa1b19c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "581a263a-e44f-464b-8154-6af7f49f9808", "4480070d-d7be-4c03-8859-21a901ababff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aa0e84e0-b598-48ca-a7d0-b6277bc02c3c", "e4c80d7a-bcb8-480a-8626-9150d8273df2" });

            migrationBuilder.UpdateData(
                table: "UserInstrumentGenre",
                keyColumn: "UserInstrumentGenreId",
                keyValue: 3,
                column: "GenreId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "UserInstrumentGenre",
                keyColumn: "UserInstrumentGenreId",
                keyValue: 4,
                column: "GenreId",
                value: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d75d7dae-6b9a-4d65-aee7-2ba0e9c2135b", "941ffcc4-e372-4584-b31f-69ba39eb5b6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c834fc5c-d304-439d-8862-3505cfd699a0", "3002497f-c0ed-488d-a585-fc560a08bc28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e6c1a4c3-6f48-4a8a-b59c-02b47458a311", "c412373f-c9dd-4338-8632-b492d28f5b32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7eafb9d6-146a-45c5-bc27-0277b4f1d468", "45919dd6-fadc-4f29-a4b1-58b6f09ec310" });

            migrationBuilder.UpdateData(
                table: "UserInstrumentGenre",
                keyColumn: "UserInstrumentGenreId",
                keyValue: 3,
                column: "GenreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "UserInstrumentGenre",
                keyColumn: "UserInstrumentGenreId",
                keyValue: 4,
                column: "GenreId",
                value: 1);
        }
    }
}
