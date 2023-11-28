// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This is the replication status of the gallery image version. </summary>
    public partial class ReplicationStatus
    {
        /// <summary> Initializes a new instance of <see cref="ReplicationStatus"/>. </summary>
        internal ReplicationStatus()
        {
            Summary = new ChangeTrackingList<RegionalReplicationStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="ReplicationStatus"/>. </summary>
        /// <param name="aggregatedState"> This is the aggregated replication status based on all the regional replication status flags. </param>
        /// <param name="summary"> This is a summary of replication status for each region. </param>
        internal ReplicationStatus(AggregatedReplicationState? aggregatedState, IReadOnlyList<RegionalReplicationStatus> summary)
        {
            AggregatedState = aggregatedState;
            Summary = summary;
        }

        /// <summary> This is the aggregated replication status based on all the regional replication status flags. </summary>
        public AggregatedReplicationState? AggregatedState { get; }
        /// <summary> This is a summary of replication status for each region. </summary>
        public IReadOnlyList<RegionalReplicationStatus> Summary { get; }
    }
}
