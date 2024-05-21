namespace la_mia_pizzeria_static.Models
{
    public class PizzaFormModel
    {
        public Pizza Pizza { get; set; }
        public List<Categoria>? Categorie { get; set; }
        public List<Ingrediente>? Ingredienti { get; set; }
        public List<int> SelectedIngredienti { get; set; } = new List<int>();
    }
}
