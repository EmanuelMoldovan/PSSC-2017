using System;
using DariusDDD.Domain.Services.Entities;

namespace DariusDDD.Domain.Models
{
    public class Order : OrderEntity
    {
        public Order(string clientName, string email, string phone, int carId, DateTime createdDate) : base(createdDate)
        {
            this.ClientName = clientName;
            this.Email = email;
            this.Phone = phone;
            this.CarId = carId;
        }

        public string ClientName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CarId { get; set; }
    }
}
