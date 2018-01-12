using DariusDDD.Domain.Enums;

namespace DariusDDD.Domain.Models.ValueObjects
{
    public class Money
    {
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
    }
}
