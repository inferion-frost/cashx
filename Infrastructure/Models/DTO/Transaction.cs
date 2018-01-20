using Infrastructure.Models.Constants;

namespace Infrastructure.Models.DTO
{
    public class GetTransactionDTO
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public string Description { get; set; }
        public decimal Balance { get; set; }
        public TransactionType TransactionType { get; set; }
    }

    public class CreateTransactionDTO
    {
        public long AccountId { get; set; }
        public string Description { get; set; }
        public decimal Balance { get; set; }
        public TransactionType TransactionType { get; set; }
    }
}
