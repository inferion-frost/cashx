using Infrastructure.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Facades
{
    public interface IPersonServiceFacade
    {
        GetPersonDTO CreatePerson(CreatePersonDTO createPersonDTO);
        GetPersonDTO UpdatePerson(UpdatePersonDTO updatePersonDTO);
        GetPersonDTO GetPerson(long personId);
        void DeletePerson(long personId);
        ICollection<GetPersonDTO> GetPeople();
    }
}
