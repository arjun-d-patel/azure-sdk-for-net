// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DeviceProvisioningServices;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> List of provisioning service descriptions. </summary>
    internal partial class ProvisioningServiceDescriptionListResult
    {
        /// <summary> Initializes a new instance of <see cref="ProvisioningServiceDescriptionListResult"/>. </summary>
        internal ProvisioningServiceDescriptionListResult()
        {
            Value = new ChangeTrackingList<DeviceProvisioningServiceData>();
        }

        /// <summary> Initializes a new instance of <see cref="ProvisioningServiceDescriptionListResult"/>. </summary>
        /// <param name="value"> List of provisioning service descriptions. </param>
        /// <param name="nextLink"> the next link. </param>
        internal ProvisioningServiceDescriptionListResult(IReadOnlyList<DeviceProvisioningServiceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of provisioning service descriptions. </summary>
        public IReadOnlyList<DeviceProvisioningServiceData> Value { get; }
        /// <summary> the next link. </summary>
        public string NextLink { get; }
    }
}
