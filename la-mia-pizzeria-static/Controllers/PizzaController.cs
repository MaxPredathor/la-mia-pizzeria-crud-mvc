using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using static la_mia_pizzeria_static.Models.Pizza;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        private readonly PizzaContext _context;
        public PizzaController(PizzaContext context)    
        {
            this._context = context;
        }
        public IActionResult Index()
        {        
            var pizza = _context.Pizza.ToList();
            return View(pizza);
        }
        public IActionResult Detail(int id)
        {
            Pizza pizza = _context.Pizza.FirstOrDefault(x => x.Id == id);
            if(pizza == null)
            {
                return NotFound();
            }
            return View(pizza);
        }

        // Funzione che prende tutte le categorie dal DB
        public List<Categoria> GetAllCategories()
        {
            return _context.Categoria.ToList();
        }

        [HttpGet]
        public IActionResult Create()
        {
            PizzaFormModel model = new PizzaFormModel();
            model.Pizza = new Pizza();
            model.Categorie = GetAllCategories();
            return View(model);
        }     

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PizzaFormModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Pizza.Add(model.Pizza);
                _context.SaveChanges();
                return RedirectToAction("Index");               
            }
            {
                model.Categorie = GetAllCategories();
                return View(model);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Pizza pizza = _context.Pizza.Find(id);
            if (pizza == null)
            {
                return NotFound();
            }
            PizzaFormModel model = new PizzaFormModel
            {
                Pizza = pizza,
                Categorie = GetAllCategories()
            };

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PizzaFormModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Update(model.Pizza);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            model.Categorie = GetAllCategories();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            Pizza pizza = _context.Pizza.Find(id);
            if (pizza != null)
            {
                _context.Pizza.Remove(pizza);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
 