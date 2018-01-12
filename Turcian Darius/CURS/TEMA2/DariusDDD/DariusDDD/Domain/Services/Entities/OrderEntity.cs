using System;

namespace DariusDDD.Domain.Services.Entities
{
    public class OrderEntity
    {
        public OrderEntity(DateTime createdOrderDate)
        {
            Date = createdOrderDate;
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
    }
}
