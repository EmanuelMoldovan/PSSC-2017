using System;

namespace DariusDDD.Domain.Services.Entities
{
    public class CarEntity
    {
        public CarEntity(DateTime date, string creator)
        {
            CreatedDate = date;
            Creator = creator;
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Creator { get; set; }
    }
}
