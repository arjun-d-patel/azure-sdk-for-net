// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Sharing status of current gallery. </summary>
    public partial class SharingStatus
    {
        /// <summary> Initializes a new instance of <see cref="SharingStatus"/>. </summary>
        internal SharingStatus()
        {
            Summary = new ChangeTrackingList<RegionalSharingStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="SharingStatus"/>. </summary>
        /// <param name="aggregatedState"> Aggregated sharing state of current gallery. </param>
        /// <param name="summary"> Summary of all regional sharing status. </param>
        internal SharingStatus(SharingState? aggregatedState, IReadOnlyList<RegionalSharingStatus> summary)
        {
            AggregatedState = aggregatedState;
            Summary = summary;
        }

        /// <summary> Aggregated sharing state of current gallery. </summary>
        public SharingState? AggregatedState { get; }
        /// <summary> Summary of all regional sharing status. </summary>
        public IReadOnlyList<RegionalSharingStatus> Summary { get; }
    }
}
