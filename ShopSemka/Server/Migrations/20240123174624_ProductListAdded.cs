using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopSemka.Server.Migrations
{
    public partial class ProductListAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageURL", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Spoločenstvo prsteňa je fantasy román od spisovateľa J. R. R. Tolkiena. Predstavuje prvú časť trilógie Pán prsteňov.", "https://mrtns.sk/tovar/_xl/134/xl134254.jpg?v=17050651822", 11.39m, "Spoločenstvo prsteňa" },
                    { 2, "Hobbit, alebo cesta tam a späť je fantasy román J. R. R. Tolkiena vydaný 21. septembra 1937. V slovenčine vyšiel prvýkrát v roku 1973.", "https://mrtns.sk/tovar/_xl/134/xl134257.jpg?v=17050651812", 11.15m, "Hobbit, alebo cesta tam a späť" },
                    { 3, "Malý princ je najznámejšie dielo francúzskeho spisovateľa a pilota Antoineho de Saint-Exupéryho. Je to najslávnejší rozprávkový príbeh modernej literatúry.", "https://www.pantarhei.sk/media/catalog/product/4/6/998f08d-00460809-23.jpg", 11.35m, "Malý princ" },
                    { 4, "Zbohom zbraniam je román Ernesta Hemingwaya, dej sa odohráva na talianskom fronte počas Prvej svetovej vojny. Kniha bola vydaná v roku 1929.", "https://mrtns.sk/tovar/_xl/204/xl204133.jpg?v=16968287412", 9.99m, "Zbohom zbraniam" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
