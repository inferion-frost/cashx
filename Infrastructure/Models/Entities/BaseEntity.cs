using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Models.Entities
{
    internal class BaseEntity
    {
        public long Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }
    }
}
