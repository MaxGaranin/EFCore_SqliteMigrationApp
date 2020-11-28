using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SqliteMigrationApp.Entities
{
    public class Team : IEntity
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual Coach Coach { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual Stadion Stadion { get; set; }
    }
}