using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizze = new List<Pizza>();
            pizze.Add(new Pizza("Margherita", "Pomodoro, mozzarella", "https://it.ooni.com/cdn/shop/articles/Margherita-9920.jpg?crop=center&height=800&v=1644590028&width=800", 5.99f));
            pizze.Add(new Pizza("Capricciosa", "Pomodoro, mozzarella, funghi, prosciutto, olive", "https://eu.tastescdns.net/thumbor/VJP6SNLk2DEU2dsGq68txsvJ1gg=/1050x1050/filters:quality(65):brightness(2):contrast(2):rgb(2,-2,0):sharpen(0.2,0.2,true)/it/recipe/U5RophhTF-GvUSAqWeas/8924d1f3ed0de2aeaf60f104c2d88f.jpeg", 7.99f));
            pizze.Add(new Pizza("Quattro Stagioni", "Pomodoro, mozzarella, carciofi, funghi, prosciutto, olive", "https://www.italianstylecooking.net/wp-content/uploads/2022/01/Pizza-quattro-stagioni.jpg", 8.99f));
            pizze.Add(new Pizza("Diavola", "Pomodoro, mozzarella, salame piccante", "https://www.pizzarecipe.org/wp-content/uploads/2019/01/Pizza-Diavola.jpg", 6.99f));
            pizze.Add(new Pizza("Prosciutto e Funghi", "Pomodoro, mozzarella, prosciutto, funghi", "https://wips.plug.it/cips/buonissimo.org/cms/2023/11/pizza-con-prosciutto-cotto-e-fromaggi.jpg", 7.49f));
            pizze.Add(new Pizza("Bufalina", "Pomodoro, mozzarella di bufala, pomodorini", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSpawwdyXRRUEbi2rwTf8PPp-vS-MHbW9XZY5ArTC9ffg&s", 9.99f));
            pizze.Add(new Pizza("Quattro Formaggi", "Pomodoro, mozzarella, gorgonzola, fontina, parmigiano", "https://primochef.it/wp-content/uploads/2020/04/SH_pizza_quattro_formaggi.jpg", 8.49f));
            pizze.Add(new Pizza("Vegetariana", "Pomodoro, mozzarella, verdure miste", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTwGtVkw2_Lii-qhmcEhf-G9HHm7CvIGp2pxg6Z1r8QDw&s", 7.99f));
            pizze.Add(new Pizza("Tonno e Cipolla", "Pomodoro, mozzarella, tonno, cipolla", "https://www.bofrost.it/on/demandware.static/-/Sites-IT-master-catalog/default/dwd5d1c55c/images/15196-Pizza-Tonno-e-Cipolla-R.jpg", 6.99f));
            pizze.Add(new Pizza("Pizza Bianca", "Mozzarella, rosmarino, olio d'oliva", "https://cdn.cook.stbm.it/thumbnails/ricette/144/144925/hd750x421.jpg", 6.49f));
            pizze.Add(new Pizza("Carbonara", "Panna, mozzarella, pancetta, uova", "https://www.vincenzosplate.com/wp-content/uploads/2022/10/1500x1500-Photo-4_1951-How-to-Make-CARBONARA-PIZZA-Like-an-Italian-V1.jpg", 8.99f));
            pizze.Add(new Pizza("Salsiccia e Friarielli", "Pomodoro, mozzarella, salsiccia, friarielli", "https://scattidigusto.b-cdn.net/wp-content/uploads/2017/11/pizza-salsiccia-friarielli-migliore-Napoli.jpg", 8.49f));       
            return View(pizze);
        }
        public IActionResult Detail(Pizza pizza)
        {
            return View(pizza);
        }
    }
}
 