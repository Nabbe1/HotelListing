using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class AddedNewCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "ShortName" },
                values: new object[] { "Finland", "FN" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "ShortName" },
                values: new object[] { "Morocco", "MR" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Name" },
                values: new object[] { "Tegelviksplan 1", "Helsinki Resort and Spa" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Name", "Rating" },
                values: new object[] { "Agadir", "Grand Hotel Alazera", 5.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "ShortName" },
                values: new object[] { "Jamaica", "JM" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "ShortName" },
                values: new object[] { "Cayman Island", "CI" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Name" },
                values: new object[] { "Negril", "Sandals Resort and Spa" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Name", "Rating" },
                values: new object[] { "Nassua", "Grand Palldium", 4.0 });
        }
    }
}
