// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> Description of the shared access key. </summary>
    public partial class DeviceProvisioningServicesSharedAccessKey
    {
        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesSharedAccessKey"/>. </summary>
        /// <param name="keyName"> Name of the key. </param>
        /// <param name="rights"> Rights that this key has. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public DeviceProvisioningServicesSharedAccessKey(string keyName, DeviceProvisioningServicesAccessKeyRight rights)
        {
            Argument.AssertNotNull(keyName, nameof(keyName));

            KeyName = keyName;
            Rights = rights;
        }

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesSharedAccessKey"/>. </summary>
        /// <param name="keyName"> Name of the key. </param>
        /// <param name="primaryKey"> Primary SAS key value. </param>
        /// <param name="secondaryKey"> Secondary SAS key value. </param>
        /// <param name="rights"> Rights that this key has. </param>
        internal DeviceProvisioningServicesSharedAccessKey(string keyName, string primaryKey, string secondaryKey, DeviceProvisioningServicesAccessKeyRight rights)
        {
            KeyName = keyName;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            Rights = rights;
        }

        /// <summary> Name of the key. </summary>
        public string KeyName { get; set; }
        /// <summary> Primary SAS key value. </summary>
        public string PrimaryKey { get; set; }
        /// <summary> Secondary SAS key value. </summary>
        public string SecondaryKey { get; set; }
        /// <summary> Rights that this key has. </summary>
        public DeviceProvisioningServicesAccessKeyRight Rights { get; set; }
    }
}
