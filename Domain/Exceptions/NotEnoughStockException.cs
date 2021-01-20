using System;

namespace Domain.Exceptions
{
    public class NotEnoughStockException : DomainException
    {
        public override string Code { get; } = "not_enough_stock";
        public Guid Id { get; }
        public NotEnoughStockException(Guid id) : base($"not enough item whit Id {id} in stock")
            => Id = id;
    }
}
