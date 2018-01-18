using System;

namespace Infrastructure.Models.DTO
{
    [Serializable]
    public class CreatePersonDTO
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDate { get; set; }
    }

    [Serializable]
    public class UpdatePersonDTO
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDate { get; set; }
    }

    [Serializable]
    public class GetPersonDTO
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDate { get; set; }

        public override string ToString()
        {
            return $"Person:{Id},{FullName},{Email},{Phone},{BirthDate?.ToShortDateString()}";
        }
    }
}
