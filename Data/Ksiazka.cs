namespace Biblioteka.Data
{
    public class Ksiazka
    {
        public int Id { get; set; }   // Klucz główny, unikalny identyfikator książki
        public string Tytul { get; set; }   // Tytuł książki
        public string Autor { get; set; }   // Autor książki
        public int Rok { get; set; } // Rok wydania ksiazkis
        public bool Dostepna { get; set; } = true; // Czy książka jest dostępna do wypożyczenia
    }
}
