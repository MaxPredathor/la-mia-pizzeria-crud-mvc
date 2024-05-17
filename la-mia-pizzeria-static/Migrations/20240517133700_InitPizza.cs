using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace la_mia_pizzeria_static.Migrations
{
    public partial class InitPizza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizze",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Immagine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezzo = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizze", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pizze",
                columns: new[] { "Id", "Descrizione", "Immagine", "Nome", "Prezzo" },
                values: new object[,]
                {
                    { 1, "Pomodoro, mozzarella", "https://it.ooni.com/cdn/shop/articles/Margherita-9920.jpg?crop=center&height=800&v=1644590028&width=800", "Margherita", 5.99f },
                    { 2, "Pomodoro, mozzarella, funghi, prosciutto, olive", "https://eu.tastescdns.net/thumbor/VJP6SNLk2DEU2dsGq68txsvJ1gg=/1050x1050/filters:quality(65):brightness(2):contrast(2):rgb(2,-2,0):sharpen(0.2,0.2,true)/it/recipe/U5RophhTF-GvUSAqWeas/8924d1f3ed0de2aeaf60f104c2d88f.jpeg", "Capricciosa", 7.99f },
                    { 3, "Pomodoro, mozzarella, carciofi, funghi, prosciutto, olive", "https://www.italianstylecooking.net/wp-content/uploads/2022/01/Pizza-quattro-stagioni.jpg", "Quattro Stagioni", 8.99f },
                    { 4, "Pomodoro, mozzarella, salame piccante", "https://www.pizzarecipe.org/wp-content/uploads/2019/01/Pizza-Diavola.jpg", "Diavola", 6.99f },
                    { 5, "Pomodoro, mozzarella, prosciutto, funghi", "https://wips.plug.it/cips/buonissimo.org/cms/2023/11/pizza-con-prosciutto-cotto-e-fromaggi.jpg", "Prosciutto e Funghi", 7.49f },
                    { 6, "Pomodoro, mozzarella di bufala, pomodorini", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSpawwdyXRRUEbi2rwTf8PPp-vS-MHbW9XZY5ArTC9ffg&s", "Bufalina", 9.99f },
                    { 7, "Pomodoro, mozzarella, gorgonzola, fontina, parmigiano", "https://primochef.it/wp-content/uploads/2020/04/SH_pizza_quattro_formaggi.jpg", "Quattro Formaggi", 8.49f },
                    { 8, "Pomodoro, mozzarella, verdure miste", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTwGtVkw2_Lii-qhmcEhf-G9HHm7CvIGp2pxg6Z1r8QDw&s", "Vegetariana", 7.99f },
                    { 9, "Pomodoro, mozzarella, tonno, cipolla", "https://www.bofrost.it/on/demandware.static/-/Sites-IT-master-catalog/default/dwd5d1c55c/images/15196-Pizza-Tonno-e-Cipolla-R.jpg", "Tonno e Cipolla", 6.99f },
                    { 10, "Mozzarella, rosmarino, olio d'oliva", "https://cdn.cook.stbm.it/thumbnails/ricette/144/144925/hd750x421.jpg", "Pizza Bianca", 6.49f },
                    { 11, "Panna, mozzarella, pancetta, uova", "https://www.vincenzosplate.com/wp-content/uploads/2022/10/1500x1500-Photo-4_1951-How-to-Make-CARBONARA-PIZZA-Like-an-Italian-V1.jpg", "Carbonara", 8.99f },
                    { 12, "Pomodoro, mozzarella, salsiccia, friarielli", "https://scattidigusto.b-cdn.net/wp-content/uploads/2017/11/pizza-salsiccia-friarielli-migliore-Napoli.jpg", "Salsiccia e Friarielli", 8.49f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pizze");
        }
    }
}
