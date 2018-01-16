using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Models.Entities
{
    internal class Person : BaseEntity
    {
        [Required]
        [Index("UNIQUE_PERSON_UX", 1)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        [Index("UNIQUE_PERSON_UX", 2)]
        public string Email { get; set; }

        [Phone]
        [Required]
        [Index("UNIQUE_PERSON_UX", 3)]
        public string Phone { get; set; }

        [Required]
        [Index("UNIQUE_PERSON_UX", 4)]
        public DateTime? BirthDate { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
