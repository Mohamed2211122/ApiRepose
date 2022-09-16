namespace Task.Data.Models
{
    public class Certification
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
