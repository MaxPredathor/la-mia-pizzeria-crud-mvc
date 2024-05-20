using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace la_mia_pizzeria_static.Migrations
{
    public partial class AddCategoriaAndPizze : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pizze",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Immagine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezzo = table.Column<float>(type: "real", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizze", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pizze_Categorie_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorie",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categorie",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Pizze classiche" },
                    { 2, "Pizze bianche" },
                    { 3, "Pizze vegetariane" },
                    { 4, "Pizze di mare" }
                });

            migrationBuilder.InsertData(
                table: "Pizze",
                columns: new[] { "Id", "CategoriaId", "Descrizione", "Immagine", "Nome", "Prezzo" },
                values: new object[,]
                {
                    { 1, 1, "Pomodoro, mozzarella", "https:it.ooni.com/cdn/shop/articles/Margherita-9920.jpg?crop=center&height=800&v=1644590028&width=800", "Margherita", 5.99f },
                    { 2, 1, "Pomodoro, mozzarella, funghi, prosciutto, olive", "https:eu.tastescdns.net/thumbor/VJP6SNLk2DEU2dsGq68txsvJ1gg=/1050x1050/filters:quality(65):brightness(2):contrast(2):rgb(2,-2,0):sharpen(0.2,0.2,true)/it/recipe/U5RophhTF-GvUSAqWeas/8924d1f3ed0de2aeaf60f104c2d88f.jpeg", "Capricciosa", 7.99f },
                    { 3, 3, "Pomodoro, mozzarella, carciofi, funghi, prosciutto, olive", "https:www.italianstylecooking.net/wp-content/uploads/2022/01/Pizza-quattro-stagioni.jpg", "Quattro Stagioni", 8.99f },
                    { 4, 1, "Pomodoro, mozzarella, salame piccante", "https:www.pizzarecipe.org/wp-content/uploads/2019/01/Pizza-Diavola.jpg", "Diavola", 6.99f },
                    { 5, 1, "Pomodoro, mozzarella, prosciutto, funghi", "https:wips.plug.it/cips/buonissimo.org/cms/2023/11/pizza-con-prosciutto-cotto-e-fromaggi.jpg", "Prosciutto e Funghi", 7.49f },
                    { 6, 1, "Pomodoro, mozzarella di bufala, pomodorini", "https:encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSpawwdyXRRUEbi2rwTf8PPp-vS-MHbW9XZY5ArTC9ffg&s", "Bufalina", 9.99f },
                    { 7, 1, "Pomodoro, mozzarella, gorgonzola, fontina, parmigiano", "https:primochef.it/wp-content/uploads/2020/04/SH_pizza_quattro_formaggi.jpg", "Quattro Formaggi", 8.49f },
                    { 8, 3, "Pomodoro, mozzarella, verdure miste", "https:encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTwGtVkw2_Lii-qhmcEhf-G9HHm7CvIGp2pxg6Z1r8QDw&s", "Vegetariana", 7.99f },
                    { 9, 4, "Pomodoro, mozzarella, tonno, cipolla", "https:www.bofrost.it/on/demandware.static/-/Sites-IT-master-catalog/default/dwd5d1c55c/images/15196-Pizza-Tonno-e-Cipolla-R.jpg", "Tonno e Cipolla", 6.99f },
                    { 10, 2, "Mozzarella, rosmarino, olio d'oliva", "https:cdn.cook.stbm.it/thumbnails/ricette/144/144925/hd750x421.jpg", "Pizza Bianca", 6.49f },
                    { 11, 1, "Panna, mozzarella, pancetta, uova", "https:www.vincenzosplate.com/wp-content/uploads/2022/10/1500x1500-Photo-4_1951-How-to-Make-CARBONARA-PIZZA-Like-an-Italian-V1.jpg", "Carbonara", 8.99f },
                    { 12, 1, "Pomodoro, mozzarella, salsiccia, friarielli", "https:scattidigusto.b-cdn.net/wp-content/uploads/2017/11/pizza-salsiccia-friarielli-migliore-Napoli.jpg", "Salsiccia e Friarielli", 8.49f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pizze_CategoriaId",
                table: "Pizze",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pizze");

            migrationBuilder.DropTable(
                name: "Categorie");
        }
    }
}
