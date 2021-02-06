using Microsoft.EntityFrameworkCore.Migrations;

namespace KalkulatorWaluty.Migrations
{
    public partial class Waluty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Waluty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrzelicznikDoDolara = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waluty", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Waluty",
                columns: new[] { "Id", "Nazwa", "PrzelicznikDoDolara", "Symbol" },
                values: new object[,]
                {
                    { 1, "Dolar", 1.0, "USD" },
                    { 2, "Złoty", 0.26629999999999998, "PLN" },
                    { 3, "Euro", 1.1977, "EUR" },
                    { 4, "Frank Szwajcarski", 1.1074999999999999, "CHF" },
                    { 5, "Funt Szterling", 1.369, "GBP" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Waluty");
        }
    }
}
