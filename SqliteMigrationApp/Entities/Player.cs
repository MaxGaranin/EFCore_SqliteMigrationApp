using System.ComponentModel.DataAnnotations.Schema;

namespace SqliteMigrationApp.Entities
{
    [Table("TeamPlayer")]
    public class Player : Person
    {
        public int Number { get; set; }

        public int TeamId { get; set; }

        public virtual Team Team { get; set; }

        public virtual Player Mentor { get; set; }
    }
}