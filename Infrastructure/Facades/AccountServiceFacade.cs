using System;
using System.Collections.Generic;
using AutoMapper;
using Infrastructure.Models.DTO;
using Infrastructure.Models.Entities;
using Infrastructure.Services;

namespace Infrastructure.Facades
{
    internal class AccountServiceFacade : IAccountServiceFacade
    {
        private readonly IMapper _mapper;
        private readonly IAccountService _accountService;

        public AccountServiceFacade(
            IMapper mapper,
            IAccountService accountService)
        {
            _mapper = mapper;
            _accountService = accountService;
        }

        public GetAccountDTO CreateAccount(long personId)
        {
            var createdAccount=  _accountService.CreateAccount(personId);
            return _mapper.Map<GetAccountDTO>(createdAccount);
        }

        public GetAccountDTO GetAccount(long accountId)
        {
            var foundAccount = _accountService.GetAccount(accountId);
            return _mapper.Map<GetAccountDTO>(foundAccount);
        }

        public ICollection<GetAccountDTO> GetAccounts(long personId)
        {
            ICollection<Account> foundAccounts = _accountService.GetAccounts(personId);
            return _mapper.Map<ICollection<GetAccountDTO>>(foundAccounts);
        }
    }
}
