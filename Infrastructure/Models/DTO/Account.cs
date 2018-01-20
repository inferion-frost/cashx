using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.DTO
{
    public class GetAccountDTO
    {
        public long Id { get; set; }
        public long OwnerId { get; set; }
        public decimal Balance { get; set; }
    }
}
