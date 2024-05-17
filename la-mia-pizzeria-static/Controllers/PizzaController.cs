using la_mia_pizzeria_static.Migrations;
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }     

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pizza data)
        {
            if (ModelState.IsValid)
            {
                _context.Pizza.Add(data);
                _context.SaveChanges();
                return RedirectToAction("Index");               
            }
            {
                return View(data);
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
            return View(pizza);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Pizza data)
        {
            if(ModelState.IsValid)
            {
                _context.Pizza.Update(data);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(data);
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
 