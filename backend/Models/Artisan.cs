namespace backend.Models
{
    public class Artisan
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Artisan(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static List<Artisan> All = new List<Artisan>
        {
            new Artisan(1, "Alice"),
            new Artisan(2, "Bob")
        };
    }
}
