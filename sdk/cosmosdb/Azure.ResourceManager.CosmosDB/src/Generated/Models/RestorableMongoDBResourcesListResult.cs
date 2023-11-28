// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The List operation response, that contains the restorable MongoDB resources. </summary>
    internal partial class RestorableMongoDBResourcesListResult
    {
        /// <summary> Initializes a new instance of <see cref="RestorableMongoDBResourcesListResult"/>. </summary>
        internal RestorableMongoDBResourcesListResult()
        {
            Value = new ChangeTrackingList<RestorableMongoDBResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="RestorableMongoDBResourcesListResult"/>. </summary>
        /// <param name="value"> List of restorable MongoDB resources, including the database and collection names. </param>
        internal RestorableMongoDBResourcesListResult(IReadOnlyList<RestorableMongoDBResourceData> value)
        {
            Value = value;
        }

        /// <summary> List of restorable MongoDB resources, including the database and collection names. </summary>
        public IReadOnlyList<RestorableMongoDBResourceData> Value { get; }
    }
}
