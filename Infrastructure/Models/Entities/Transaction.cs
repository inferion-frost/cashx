using Infrastructure.Models.Constants;
using Infrastructure.Models.Extensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Models.Entities
{
    internal class Transaction : BaseEntity
    {
        [NotMapped]
        public TransactionType TransactionType { get; set; }

        [Required]
        public string Type
        {
            get { return TransactionType.ToString(); }
            set { TransactionType = value.Parse<TransactionType>(); }
        }

        [Required]
        public string Description { get; set; }
        
        [Required]
        public decimal Balance { get; set; }

        public Account Account { get; set; }

        public long AccountId { get; set; }
    }
}
