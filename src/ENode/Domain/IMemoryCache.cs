﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ENode.Domain
{
    /// <summary>Represents a high speed memory cache to get or set aggregate.
    /// </summary>
    public interface IMemoryCache
    {
        /// <summary>Get an aggregate from memory cache.
        /// </summary>
        /// <param name="aggregateRootId"></param>
        /// <param name="aggregateRootType"></param>
        /// <returns></returns>
        Task<IAggregateRoot> GetAsync(object aggregateRootId, Type aggregateRootType);
        /// <summary>Get a strong type aggregate from memory cache.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="aggregateRootId"></param>
        /// <returns></returns>
        Task<T> GetAsync<T>(object aggregateRootId) where T : class, IAggregateRoot;
        /// <summary>Refresh the aggregate memory cache by replaying events of event store.
        /// </summary>
        Task<IAggregateRoot> RefreshAggregateFromEventStoreAsync(string aggregateRootTypeName, string aggregateRootId);
        /// <summary>Start background tasks.
        /// </summary>
        void Start();
        /// <summary>Stop background tasks.
        /// </summary>
        void Stop();
    }
}
