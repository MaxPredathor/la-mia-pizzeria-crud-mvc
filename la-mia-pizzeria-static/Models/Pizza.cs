namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string Immagine { get; set; }
        public float Prezzo { get; set; }

        public Pizza(string name,  string descrizione, string image, float price)
        {
            Nome = name;
            Descrizione = descrizione;
            Immagine = image;
            Prezzo = price;
        }
    }
}
