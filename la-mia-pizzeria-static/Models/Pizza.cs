using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    [Table("Pizze")]
    public class Pizza
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Il nome è obbligatorio.")]
        [StringLength(50, ErrorMessage = "Il nome non può superare i 50 caratteri.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "La descrizione è obbligatoria.")]
        [StringLength(250, ErrorMessage = "La descrizione non può superare i 250 caratteri.")]
        public string Descrizione { get; set; }
        [Required(ErrorMessage = "L'immagine è obbligatoria.")]
        [Url(ErrorMessage = "Il link dell'immagine deve essere un URL valido.")]
        public string Immagine { get; set; }
        [Required(ErrorMessage = "Il prezzo è obbligatorio.")]
        [Range(0.01, 10000.00, ErrorMessage = "Il prezzo deve essere compreso tra 0,01 e 10000,00.")]
        public float Prezzo { get; set; }

        public Pizza()
        {
        }
        public Pizza(string name,  string descrizione, string image, float price)
        {
            Nome = name;
            Descrizione = descrizione;
            Immagine = image;
            Prezzo = price;
        }
        public class PizzaContext : DbContext
        {
            public DbSet<Pizza> Pizza { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Pizzeria;Integrated Security=True;Trust Server Certificate=True");
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Pizza>().HasData(
                    new Pizza { Id = 1, Nome = "Margherita", Descrizione = "Pomodoro, mozzarella", Immagine = "https://it.ooni.com/cdn/shop/articles/Margherita-9920.jpg?crop=center&height=800&v=1644590028&width=800", Prezzo = 5.99f },
                    new Pizza { Id = 2, Nome = "Capricciosa", Descrizione = "Pomodoro, mozzarella, funghi, prosciutto, olive", Immagine = "https://eu.tastescdns.net/thumbor/VJP6SNLk2DEU2dsGq68txsvJ1gg=/1050x1050/filters:quality(65):brightness(2):contrast(2):rgb(2,-2,0):sharpen(0.2,0.2,true)/it/recipe/U5RophhTF-GvUSAqWeas/8924d1f3ed0de2aeaf60f104c2d88f.jpeg", Prezzo = 7.99f },
                    new Pizza { Id = 3, Nome = "Quattro Stagioni", Descrizione = "Pomodoro, mozzarella, carciofi, funghi, prosciutto, olive", Immagine = "https://www.italianstylecooking.net/wp-content/uploads/2022/01/Pizza-quattro-stagioni.jpg", Prezzo = 8.99f },
                    new Pizza { Id = 4, Nome = "Diavola", Descrizione = "Pomodoro, mozzarella, salame piccante", Immagine = "https://www.pizzarecipe.org/wp-content/uploads/2019/01/Pizza-Diavola.jpg", Prezzo = 6.99f },
                    new Pizza { Id = 5, Nome = "Prosciutto e Funghi", Descrizione = "Pomodoro, mozzarella, prosciutto, funghi", Immagine = "https://wips.plug.it/cips/buonissimo.org/cms/2023/11/pizza-con-prosciutto-cotto-e-fromaggi.jpg", Prezzo = 7.49f },
                    new Pizza { Id = 6, Nome = "Bufalina", Descrizione = "Pomodoro, mozzarella di bufala, pomodorini", Immagine = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSpawwdyXRRUEbi2rwTf8PPp-vS-MHbW9XZY5ArTC9ffg&s", Prezzo = 9.99f },
                    new Pizza { Id = 7, Nome = "Quattro Formaggi", Descrizione = "Pomodoro, mozzarella, gorgonzola, fontina, parmigiano", Immagine = "https://primochef.it/wp-content/uploads/2020/04/SH_pizza_quattro_formaggi.jpg", Prezzo = 8.49f },
                    new Pizza { Id = 8, Nome = "Vegetariana", Descrizione = "Pomodoro, mozzarella, verdure miste", Immagine = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTwGtVkw2_Lii-qhmcEhf-G9HHm7CvIGp2pxg6Z1r8QDw&s", Prezzo = 7.99f },
                    new Pizza { Id = 9, Nome = "Tonno e Cipolla", Descrizione = "Pomodoro, mozzarella, tonno, cipolla", Immagine = "https://www.bofrost.it/on/demandware.static/-/Sites-IT-master-catalog/default/dwd5d1c55c/images/15196-Pizza-Tonno-e-Cipolla-R.jpg", Prezzo = 6.99f },
                    new Pizza { Id = 10, Nome = "Pizza Bianca", Descrizione = "Mozzarella, rosmarino, olio d'oliva", Immagine = "https://cdn.cook.stbm.it/thumbnails/ricette/144/144925/hd750x421.jpg", Prezzo = 6.49f },
                    new Pizza { Id = 11, Nome = "Carbonara", Descrizione = "Panna, mozzarella, pancetta, uova", Immagine = "https://www.vincenzosplate.com/wp-content/uploads/2022/10/1500x1500-Photo-4_1951-How-to-Make-CARBONARA-PIZZA-Like-an-Italian-V1.jpg", Prezzo = 8.99f },
                    new Pizza { Id = 12, Nome = "Salsiccia e Friarielli", Descrizione = "Pomodoro, mozzarella, salsiccia, friarielli", Immagine = "https://scattidigusto.b-cdn.net/wp-content/uploads/2017/11/pizza-salsiccia-friarielli-migliore-Napoli.jpg", Prezzo = 8.49f }
                    );
            }
        }
    }
}
