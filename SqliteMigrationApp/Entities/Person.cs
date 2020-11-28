using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqliteMigrationApp.Entities
{
    public abstract class Person : IEntity
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(100)]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }
    }
}
