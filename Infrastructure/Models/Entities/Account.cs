using System;
using System.Collections.Generic;

namespace Infrastructure.Models.Entities
{
    internal class Account : BaseEntity
    {
        public Decimal Balance { get; set; }

        public long OwnerId { get; set; }

        public Person Owner { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
