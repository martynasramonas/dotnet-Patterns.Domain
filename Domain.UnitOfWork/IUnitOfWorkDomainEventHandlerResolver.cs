﻿using System.Collections.Generic;

namespace Affecto.Patterns.Domain.UnitOfWork
{
    /// <summary>
    /// Resolves domain event handlers that use the Unit of Work pattern.
    /// </summary>
    public interface IUnitOfWorkDomainEventHandlerResolver
    {
        /// <summary>
        /// Resolves the set of event handlers registered for handling the given domain event. These event handlers use the Unit of Work pattern.
        /// </summary>
        /// <typeparam name="TEvent">The type of the domain event.</typeparam>
        /// <typeparam name="TUnitOfWork">The type of the Unit of Work context.</typeparam>
        /// <param name="domainEvent">The domain event instance.</param>
        /// <returns>A collection of event handler instances.</returns>
        IEnumerable<IUnitOfWorkDomainEventHandler<TEvent, TUnitOfWork>> Resolve<TEvent, TUnitOfWork>(TEvent domainEvent)
            where TEvent : class, IDomainEvent
            where TUnitOfWork : class, IUnitOfWork;
    }
}