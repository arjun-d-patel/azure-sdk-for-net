// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Cognitive Services account commitment quota. </summary>
    public partial class CommitmentQuota
    {
        /// <summary> Initializes a new instance of <see cref="CommitmentQuota"/>. </summary>
        internal CommitmentQuota()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CommitmentQuota"/>. </summary>
        /// <param name="quantity"> Commitment quota quantity. </param>
        /// <param name="unit"> Commitment quota unit. </param>
        internal CommitmentQuota(long? quantity, string unit)
        {
            Quantity = quantity;
            Unit = unit;
        }

        /// <summary> Commitment quota quantity. </summary>
        public long? Quantity { get; }
        /// <summary> Commitment quota unit. </summary>
        public string Unit { get; }
    }
}
