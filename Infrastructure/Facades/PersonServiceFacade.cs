using System;
using System.Collections.Generic;
using AutoMapper;
using Infrastructure.Models.DTO;
using Infrastructure.Models.Entities;
using Infrastructure.Services;

namespace Infrastructure.Facades
{
    internal class PersonServiceFacade : IPersonServiceFacade
    {
        private readonly IMapper _mapper;
        private readonly IPersonService _personService;

        public PersonServiceFacade(
            IMapper mapper, 
            IPersonService personService)
        {
            _mapper = mapper;
            _personService = personService;
        }

        public GetPersonDTO CreatePerson(CreatePersonDTO createPersonDTO)
        {
            var person = _mapper.Map<Person>(createPersonDTO);
             _personService.CreatePerson(person);
            return _mapper.Map<GetPersonDTO>(person);
        }

        public void DeletePerson(long personId)
        {
            _personService.DeletePerson(personId);
        }

        public ICollection<GetPersonDTO> GetPeople()
        {
            return _mapper.Map<ICollection<GetPersonDTO>>(
                _personService.GetPeople());
        }

        public GetPersonDTO GetPerson(long personId)
        {
            return _mapper.Map<GetPersonDTO>(_personService.GetPerson(personId));
        }

        public GetPersonDTO UpdatePerson(UpdatePersonDTO updatePersonDTO)
        {
            var person = _mapper.Map<Person>(updatePersonDTO);
            _personService.UpdatePerson(person);
            return _mapper.Map<GetPersonDTO>(person);
        }
    }
}
