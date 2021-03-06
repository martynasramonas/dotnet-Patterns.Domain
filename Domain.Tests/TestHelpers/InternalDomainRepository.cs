using System;

namespace Affecto.Patterns.Domain.Tests.TestHelpers
{
    internal class InternalDomainRepository : DomainRepository<InternalAggregateRoot>
    {
        public InternalDomainRepository(IDomainEventHandlerResolver eventHandlerResolver)
            : base(eventHandlerResolver)
        {
        }

        public override InternalAggregateRoot Find(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}