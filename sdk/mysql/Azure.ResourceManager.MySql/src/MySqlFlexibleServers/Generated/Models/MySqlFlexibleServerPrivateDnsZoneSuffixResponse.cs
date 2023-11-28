// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> The response of get private dns zone suffix. </summary>
    public partial class MySqlFlexibleServerPrivateDnsZoneSuffixResponse
    {
        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerPrivateDnsZoneSuffixResponse"/>. </summary>
        internal MySqlFlexibleServerPrivateDnsZoneSuffixResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerPrivateDnsZoneSuffixResponse"/>. </summary>
        /// <param name="privateDnsZoneSuffix"> Represents the private DNS zone suffix. </param>
        internal MySqlFlexibleServerPrivateDnsZoneSuffixResponse(string privateDnsZoneSuffix)
        {
            PrivateDnsZoneSuffix = privateDnsZoneSuffix;
        }

        /// <summary> Represents the private DNS zone suffix. </summary>
        public string PrivateDnsZoneSuffix { get; }
    }
}
