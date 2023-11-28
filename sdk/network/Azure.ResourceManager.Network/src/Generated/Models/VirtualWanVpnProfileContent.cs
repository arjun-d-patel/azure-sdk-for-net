// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Virtual Wan Vpn profile parameters Vpn profile generation. </summary>
    public partial class VirtualWanVpnProfileContent
    {
        /// <summary> Initializes a new instance of <see cref="VirtualWanVpnProfileContent"/>. </summary>
        public VirtualWanVpnProfileContent()
        {
        }

        /// <summary> VpnServerConfiguration partial resource uri with which VirtualWan is associated to. </summary>
        public ResourceIdentifier VpnServerConfigurationResourceId { get; set; }
        /// <summary> VPN client authentication method. </summary>
        public NetworkAuthenticationMethod? AuthenticationMethod { get; set; }
    }
}
