using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_static.Models
{
    public class Ingrediente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<PizzaIngrediente> PizzaIngredienti { get; set; } = new List<PizzaIngrediente>();
    }

    public class PizzaIngrediente
    {
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }

        public int IngredienteId { get; set; }
        public Ingrediente Ingrediente { get; set; }
    }
}
