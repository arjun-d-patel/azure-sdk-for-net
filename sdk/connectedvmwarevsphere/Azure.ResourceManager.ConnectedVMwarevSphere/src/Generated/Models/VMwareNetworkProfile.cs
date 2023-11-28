// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> Specifies the network interfaces of the virtual machine. </summary>
    internal partial class VMwareNetworkProfile
    {
        /// <summary> Initializes a new instance of <see cref="VMwareNetworkProfile"/>. </summary>
        public VMwareNetworkProfile()
        {
            NetworkInterfaces = new ChangeTrackingList<VMwareNetworkInterface>();
        }

        /// <summary> Initializes a new instance of <see cref="VMwareNetworkProfile"/>. </summary>
        /// <param name="networkInterfaces"> Gets or sets the list of network interfaces associated with the virtual machine. </param>
        internal VMwareNetworkProfile(IList<VMwareNetworkInterface> networkInterfaces)
        {
            NetworkInterfaces = networkInterfaces;
        }

        /// <summary> Gets or sets the list of network interfaces associated with the virtual machine. </summary>
        public IList<VMwareNetworkInterface> NetworkInterfaces { get; }
    }
}
