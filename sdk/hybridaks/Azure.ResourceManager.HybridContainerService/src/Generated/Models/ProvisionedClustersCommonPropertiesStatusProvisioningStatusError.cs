// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The ProvisionedClustersCommonPropertiesStatusProvisioningStatusError. </summary>
    public partial class ProvisionedClustersCommonPropertiesStatusProvisioningStatusError
    {
        /// <summary> Initializes a new instance of <see cref="ProvisionedClustersCommonPropertiesStatusProvisioningStatusError"/>. </summary>
        internal ProvisionedClustersCommonPropertiesStatusProvisioningStatusError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProvisionedClustersCommonPropertiesStatusProvisioningStatusError"/>. </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        internal ProvisionedClustersCommonPropertiesStatusProvisioningStatusError(string code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary> Gets the code. </summary>
        public string Code { get; }
        /// <summary> Gets the message. </summary>
        public string Message { get; }
    }
}
