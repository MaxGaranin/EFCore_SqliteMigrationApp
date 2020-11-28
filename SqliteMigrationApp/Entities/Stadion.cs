using System.ComponentModel.DataAnnotations;

namespace SqliteMigrationApp.Entities
{
    public class Stadion
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public int Order { get; set; }
    }
}