// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServices;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> The response model for a list of Vaults. </summary>
    internal partial class RecoveryServicesVaultListResult
    {
        /// <summary> Initializes a new instance of <see cref="RecoveryServicesVaultListResult"/>. </summary>
        internal RecoveryServicesVaultListResult()
        {
            Value = new ChangeTrackingList<RecoveryServicesVaultData>();
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryServicesVaultListResult"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        internal RecoveryServicesVaultListResult(IReadOnlyList<RecoveryServicesVaultData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<RecoveryServicesVaultData> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
