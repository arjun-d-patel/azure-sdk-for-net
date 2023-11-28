// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> An Azure Cosmos DB SQL database event. </summary>
    public partial class RestorableSqlDatabase : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="RestorableSqlDatabase"/>. </summary>
        internal RestorableSqlDatabase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RestorableSqlDatabase"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="resource"> The resource of an Azure Cosmos DB SQL database event. </param>
        internal RestorableSqlDatabase(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ExtendedRestorableSqlDatabaseResourceInfo resource) : base(id, name, resourceType, systemData)
        {
            Resource = resource;
        }

        /// <summary> The resource of an Azure Cosmos DB SQL database event. </summary>
        public ExtendedRestorableSqlDatabaseResourceInfo Resource { get; }
    }
}
