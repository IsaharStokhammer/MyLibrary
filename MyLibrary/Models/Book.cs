namespace MyLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GenreId { get; set; }
        public Genre Genre { get; set; }
        public decimal Width { get; set; }
        public decimal Heigt { get; set; }
        public Shelf shelf { get; set; }
        public int ShlfId { get; set; }
    }
}
