using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Infrastructure.Models.DTO;
using Infrastructure.Models.Entities;
using Infrastructure.Services;

namespace Infrastructure.Facades
{
    internal class TransactionServiceFacade : ITransactionServiceFacade
    {
        private readonly IMapper _mapper;
        private readonly ITransactionService _transactionService;

        public TransactionServiceFacade(
            IMapper mapper,
            ITransactionService transactionService)
        {
            _mapper = mapper;
            _transactionService = transactionService;
        }

        public GetTransactionDTO CreateTransaction(CreateTransactionDTO createTransactionDTO)
        {
            var transaction = _mapper.Map<Transaction>(createTransactionDTO);
            _transactionService.CreateTransaction(transaction);
            return _mapper.Map<GetTransactionDTO>(transaction);
        }

        public ICollection<GetTransactionDTO> GetTransactions(long accountId)
        {
            var transactions = _transactionService.GetTransactions(accountId);
            return _mapper.Map<ICollection<GetTransactionDTO>>(transactions);
        }
    }
}
