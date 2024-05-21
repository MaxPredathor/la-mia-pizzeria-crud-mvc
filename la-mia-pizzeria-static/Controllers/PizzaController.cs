using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        // Funzione che prende tutte le categorie dal DB

        public List<Categoria> GetAllCategories()
        {
            return _context.Categoria.ToList();
        }
        // Funzione che prende tutti gli ingredienti dal DB

        public List<Ingrediente> GetAllIngredienti()
        {
            return _context.Ingrediente.ToList();
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

        [HttpGet]
        public IActionResult Create()
        {
            PizzaFormModel model = new PizzaFormModel();
            model.Pizza = new Pizza();
            model.Categorie = GetAllCategories();
            model.Ingredienti = GetAllIngredienti();
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

                foreach (var ingredienteId in model.SelectedIngredienti)
                {
                    _context.PizzaIngrediente.Add(new PizzaIngrediente
                    {
                        PizzaId = model.Pizza.Id,
                        IngredienteId = ingredienteId
                    });
                }

                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            model.Categorie = GetAllCategories();
            model.Ingredienti = GetAllIngredienti();
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Pizza pizza = _context.Pizza
                .Include(p => p.PizzaIngredienti)
                .FirstOrDefault(p => p.Id == id);

            if (pizza == null)
            {
                return NotFound();
            }

            PizzaFormModel model = new PizzaFormModel
            {
                Pizza = pizza,
                Categorie = GetAllCategories(),
                Ingredienti = GetAllIngredienti(),
                SelectedIngredienti = pizza.PizzaIngredienti.Select(pi => pi.IngredienteId).ToList()
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

                var existingIngredients = _context.PizzaIngrediente
                    .Where(pi => pi.PizzaId == model.Pizza.Id)
                    .ToList();

                _context.PizzaIngrediente.RemoveRange(existingIngredients);
                _context.SaveChanges();

                foreach (var ingredienteId in model.SelectedIngredienti)
                {
                    _context.PizzaIngrediente.Add(new PizzaIngrediente
                    {
                        PizzaId = model.Pizza.Id,
                        IngredienteId = ingredienteId
                    });
                }

                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            model.Categorie = GetAllCategories();
            model.Ingredienti = GetAllIngredienti();
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
 