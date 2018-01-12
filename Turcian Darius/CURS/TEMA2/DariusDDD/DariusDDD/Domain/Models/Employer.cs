using DariusDDD.Domain.Services.Entities;

namespace DariusDDD.Domain.Models
{
    public class Employer:EmployerEntity
    {
        public Employer(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
